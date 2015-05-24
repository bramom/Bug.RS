using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using InvadersWin8.Logic;

namespace InvadersWin8.Model
{
    public class Bullet:Sprite
    {
        public Action Remove;

        public Bullet(): base(new Point(), new Point())
        {
        }

        public override Rectangle Render()
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Fill = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            rectangle.Height = Utility.BULLET_SIZE * 2;
            rectangle.Width = Utility.BULLET_SIZE;

            rectangle.SetValue(Canvas.LeftProperty, _position.X);
            rectangle.SetValue(Canvas.TopProperty, _position.Y);
            _participant = rectangle;

            return rectangle;
        }

        public override void Update()
        {
            Point oldPosition = new Point(_position.X, _position.Y);

            if (_participant != null && _position.Y > Utility.MARGIN)
            {
                _position.Y -= 2 * Utility.ATOM_SIZE;
                                
                MoveTo(oldPosition, _position);
            }
            else
            {
                Remove();
                _participant = null;
            }
        }

        internal void SetPosition(Ship s)
        {
            double x = s.Position.X + (s.Participant.Width -  Utility.BULLET_SIZE) / 2;
            double y = s.Position.Y - Utility.BULLET_SIZE;

            _position = new Point(x, y);
        }
    }
}
