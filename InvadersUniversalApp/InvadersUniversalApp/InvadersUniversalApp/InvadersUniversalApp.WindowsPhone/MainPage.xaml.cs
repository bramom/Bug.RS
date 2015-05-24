using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using InvadersWin8.Logic;

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

            this.NavigationCacheMode = NavigationCacheMode.Required;

            Window.Current.SizeChanged += Current_SizeChanged;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
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

        void Current_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            // Get the new view state
            var CurrentViewState = ApplicationView.GetForCurrentView().Orientation;

            if (CurrentViewState == ApplicationViewOrientation.Portrait)
            {
                PageCanvas.Margin = new Thickness(0, 50, 0, 0);
                PageScaleTransform.ScaleX = 0.55;
                PageScaleTransform.ScaleY = 0.55;
            }

            if (CurrentViewState == ApplicationViewOrientation.Landscape)
            {
                PageCanvas.Margin = new Thickness(40, 0, 40, 0);
                PageScaleTransform.ScaleX = 0.66;
                PageScaleTransform.ScaleY = 0.66;
            }
        }

    }
}
