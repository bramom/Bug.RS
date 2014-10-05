using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Shapes;
using InvadersWin8.Logic;

namespace InvadersWin8.Model
{
    public class Invader: Sprite
    {
        public Invader(Point position, Point direction)
            : base(position, direction)
        {
        }

        public override Rectangle Render()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.StrokeThickness = 0;
            rectangle.Height = Utility.SPRITE_HEIGHT;
            rectangle.Width = Utility.SPRITE_WIDTH;
            _participant = rectangle;

            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/invader.png", UriKind.RelativeOrAbsolute));
            _participant.Fill = ib;

            _participant.SetValue(Canvas.LeftProperty, _position.X);
            _participant.SetValue(Canvas.TopProperty, _position.Y);

            return _participant;
        }

        public override void Update()
        {
            Point oldPosition = new Point(_position.X, _position.Y);

            _position.X += _direction.X;

            if (_position.X < Utility.MARGIN)
            {
                _position.X = Utility.MARGIN;
                _direction.X = Math.Abs(_direction.X);
                _position.Y += _direction.Y;
            }

            if (_position.X > Utility.MAX_X)
            {
                _position.X = Utility.MAX_X;
                _direction.X = Math.Abs(_direction.X) * -1;
                _position.Y += _direction.Y;
            }

            MoveTo(oldPosition, _position);
        }
    }
}
