using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using InvadersWin8.Logic;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace InvadersUniversalApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Game game;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ManipulationMode = ManipulationModes.All;
            game = new Game(canvas, GameOver);
            game.Initialize();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {            
            game.Start();           
            help.Visibility = Visibility.Collapsed;
        }

        private void GameOver()
        {
            lblInfo.Text = game.Message;           
            help.Visibility = Visibility.Visible;
        }
    }
}