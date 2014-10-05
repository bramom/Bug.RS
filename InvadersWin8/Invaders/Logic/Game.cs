using System;
using Windows.Foundation;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using InvadersWin8.Model;

namespace InvadersWin8.Logic
{
    public class Game
    {
        private Ship _ship;
        private Invader _invader;
        private Bullet _bullet;

        private Screen _screen;
        private Action gameOver;
        private Canvas _canvas;
        private Timer timer;
        private bool reinitialize;     

        public Game(Canvas canvas, Action gameOverAction)
        {
            _canvas = canvas;
            gameOver = gameOverAction;
            timer = new Timer(Loop, Utility.GAME_TICK_MS);
            reinitialize = false;
        }

        public void Initialize() 
        {
            _screen = new Screen(_canvas);
            _screen.Clear();

            var shipPosition = new Point(Utility.MARGIN, Utility.MAX_Y);
            _ship = new Ship(shipPosition);
            _ship.Fire = FireBullet;
            _screen.Add(_ship.Render());

            var invaderPosition = new Point(Utility.MARGIN, Utility.MARGIN);
            var invaderDirection = new Point(Utility.ATOM_SIZE, Utility.ATOM_SIZE * 3);
            _invader = new Invader(invaderPosition, invaderDirection);
            _screen.Add(_invader.Render());

            _bullet = new Bullet();
            _bullet.Remove = RemoveBullet;

            _screen.AddBorder();
        }

        public void Start()
        {
            if (reinitialize)
                Initialize();

            reinitialize = true;

            Window.Current.CoreWindow.KeyDown += KeyboardHandler;
            timer.Start();
        }

        public GameStatus CheckStatus()
        {
            Point s = _ship.Position;
            Point i = _invader.Position;
            Point b = _bullet.Position;
            double s_width = _ship.Participant.Width;
            double i_width = _invader.Participant.Width;
            double i_height = _invader.Participant.Height;

            bool enemyCrashedSprite = 
                (s.Y < i.Y + i_height) && ((i.X > s.X && i.X < s.X + s_width / 2) || (i.X <= s.X && s.X < i.X + i_width / 2));

            if (enemyCrashedSprite)
                return GameStatus.EnemyCrashedIntoSprite;

            bool bulletCrashedTheEnemy =
                (b.Y > i.Y && b.Y < (i.Y + i_height)) && (b.X > i.X && (b.X - i.X) < i_width);

            if (bulletCrashedTheEnemy)
                return GameStatus.BulletCrashedTheEnemy;

            return GameStatus.None;
        }

        public void Loop()
        {
            _ship.Update();
            _invader.Update();
            _bullet.Update();

            GameStatus gameStatus = CheckStatus();

            if (gameStatus == GameStatus.EnemyCrashedIntoSprite)
            {
                timer.Stop();
                Window.Current.CoreWindow.KeyDown -= KeyboardHandler;
                Message = "Game over!";
                gameOver();
            }

            if (gameStatus == GameStatus.BulletCrashedTheEnemy)
            {
                timer.Stop();
                Window.Current.CoreWindow.KeyDown -= KeyboardHandler;
                Message = "Your are the winner! :)";
                gameOver();
            }
        }

        public void KeyboardHandler(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            switch (args.VirtualKey)
            {
                case VirtualKey.Left:
                    _ship.StopSprite = false;
                    _ship.SetDirectionX = - 2 * Utility.ATOM_SIZE;
                    break;
                case VirtualKey.Right:
                    _ship.StopSprite = false;
                    _ship.SetDirectionX = 2 * Utility.ATOM_SIZE;
                    break;
                case VirtualKey.Down:
                    _ship.StopSprite = true;
                    break;
                case VirtualKey.Up:
                    _ship.Fire();
                    break;
                default:
                    //lblInfo.Text = "not a command";
                    break;
            }
        }

        public void FireBullet()
        {
            if (_bullet.Participant == null)
            {
                _bullet.SetPosition(_ship);
                _screen.Add(_bullet.Render());
            }
        }

        public void RemoveBullet()
        {
            _screen.Remove(_bullet.Participant);
        }

        public string Message { get; set; }
    }
}
