using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;

namespace InvadersWin8.Logic
{
    public class Screen
    {
        private readonly Canvas _canvas;

        public Screen(Canvas canvas)
        {
            _canvas = canvas;
        }

        public void Clear()
        {
            _canvas.Children.Clear();
        }

        public void Add(Rectangle rectangle)
        {
            _canvas.Children.Add(rectangle);
        }

        public void AddBorder()
        {
            _canvas.Children.Add(Utility.CreateBorder());
        }

        internal void Remove(Rectangle rectangle)
        {
            _canvas.Children.Remove(rectangle);
        }
    }
}
