using System;
using Windows.UI.Xaml;

namespace InvadersWin8.Logic
{
    public class Timer
    {
        readonly DispatcherTimer timer;

        public Timer(Action gameLoop, double milliseconds)
        {
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(milliseconds)
            };

            timer.Tick += (object sender, object e) => gameLoop();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
