using System;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Shapes;
using InvadersWin8.Logic;

namespace InvadersWin8.Model
{
    public class Ship : Sprite
    {
        public Action Fire;

        //public Ship(Point position)
        //    : base(position, new Point())
        //{
        //}

        public Ship(Point position, Canvas canvas)
            : base(position, new Point())
        {
            ParentCanvas = canvas;
        }

        public Canvas ParentCanvas { get; set; }

        public override Rectangle Render()
        {
            Rectangle rectangle = new Rectangle();

            //rectangle.ManipulationMode = ManipulationModes.All;
            //rectangle.ManipulationDelta += rectangle_ManipulationDelta;
            //rectangle.Tapped += rectangle_Tapped;

            ParentCanvas.ManipulationMode = ManipulationModes.All;
            ParentCanvas.ManipulationDelta += rectangle_ManipulationDelta;
            ParentCanvas.Tapped += rectangle_Tapped;

            rectangle.StrokeThickness = 3;
            rectangle.Height = Utility.SPRITE_HEIGHT;
            rectangle.Width = Utility.SPRITE_WIDTH;
            _participant = rectangle;

            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/ship 90x60.png", UriKind.RelativeOrAbsolute));
            _participant.Fill = ib;
            _participant.SetValue(Canvas.LeftProperty, _position.X);
            _participant.SetValue(Canvas.TopProperty, _position.Y);

            return _participant;
        }

        public override void Update()
        {
            Point oldPosition = new Point(_position.X, _position.Y);

            if (!StopSprite)
                _position.X += _direction.X;

            if (_position.X < Utility.MARGIN)
            {
                _position.X = Utility.MARGIN;
                _direction.X = 0;                
            }

            if (_position.X > Utility.MAX_X)
            {
                _position.X = Utility.MAX_X;
                _direction.X = 0;
            }

            MoveTo(oldPosition, _position);
        }

        void rectangle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SetDirectionX = 0;
            Fire();
        }

        public void rectangle_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            StopSprite = false;
            SetDirectionX = Math.Sign(e.Delta.Translation.X) * 2 * Utility.ATOM_SIZE;
        }
    }
}
