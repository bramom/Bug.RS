using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace InvadersWin8.Logic
{
    public class Utility
    {
        public const int SPRITE_WIDTH = 90;
        public const int SPRITE_HEIGHT = 60;        
        public const int WORLD_WIDTH = 8;
        public const int WORLD_HEIGHT = 6;
        public const int ATOM_SIZE = 15;
        public const int MARGIN = 2;
        public const int BULLET_SIZE = 5;
        public const int GAME_TICK_MS = 120;

        public static int MAX_X { get { return MARGIN + (WORLD_WIDTH - 1) * SPRITE_WIDTH; } }
        public static int MAX_Y { get { return MARGIN + WORLD_HEIGHT * SPRITE_WIDTH - SPRITE_HEIGHT; } }

        public static Rectangle CreateBorder()
        {
            var rectangle = new Rectangle();
            rectangle.Stroke = new SolidColorBrush(Color.FromArgb(100, 174, 169, 169));
            rectangle.StrokeThickness = 2;
            rectangle.Height = 2 * Utility.MARGIN + Utility.WORLD_HEIGHT * Utility.SPRITE_WIDTH;
            rectangle.Width = 2 * Utility.MARGIN + Utility.WORLD_WIDTH * Utility.SPRITE_WIDTH;
            return rectangle;
        }
    }
}
