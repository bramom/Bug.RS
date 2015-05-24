using InvadersWin8.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;

namespace InvadersWin8.Model
{
    public abstract class Sprite
    {
        protected Point _position;
        protected Point _direction;
        protected Rectangle _participant;

        public double SetDirectionX { set { _direction.X = value; } }

        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Point Direction
        {
            get { return _direction; }
            set { value = _direction; }
        }

        public Rectangle Participant { get { return _participant; } }

        public bool StopSprite { get; set; }

        public Sprite(Point position, Point direction)
        {
            _position = position;
            _direction = direction;
        }

        public abstract Rectangle Render();

        public abstract void Update();

        public void MoveTo(Point from, Point to, EventHandler<object> completed = null)
        {
            TranslateTransform trans = new TranslateTransform();

            _participant.Name = "MyTarget";
            _participant.RenderTransform = trans;

            DoubleAnimation anim1 = new DoubleAnimation() { From = from.X, To = to.X, Duration = TimeSpan.FromMilliseconds(Utility.GAME_TICK_MS - 1) };
            DoubleAnimation anim2 = new DoubleAnimation() { From = from.Y, To = to.Y, Duration = TimeSpan.FromMilliseconds(Utility.GAME_TICK_MS - 1) };

            Storyboard.SetTarget(anim1, _participant);
            Storyboard.SetTargetName(anim1, _participant.Name);
            Storyboard.SetTargetProperty(anim1, "(Canvas.Left)");

            Storyboard.SetTarget(anim2, _participant);
            Storyboard.SetTargetName(anim2, _participant.Name);
            Storyboard.SetTargetProperty(anim2, "(Canvas.Top)");

            Storyboard sb = new Storyboard();
            sb.Children.Add(anim1);
            sb.Children.Add(anim2);

            if (completed == null)
                sb.Completed += (object sender, object e) => { };
            else
                sb.Completed += completed;

            sb.Begin();
        }
    }
}
