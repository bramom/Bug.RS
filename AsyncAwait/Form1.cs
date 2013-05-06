using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Result:\n";            
        }

        private string work(bool raiseException)
        {
            Thread.Sleep(3000);
            if (raiseException)
                throw new ArgumentException(Thread.CurrentThread.ManagedThreadId.ToString());

            return Thread.CurrentThread.ManagedThreadId.ToString();
        }

        private void print(string prefix, string value)
        {
            label1.Text += string.Format("{0}: {1}\n", prefix, value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label1.Text = "Result:\n";
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            print("sync", work(chkRaiseException.Checked));
        }

        private void btnAsyncTask_Click(object sender, EventArgs e)
        {
            //get UI thread context 
            var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            //create and start the Task 
            var someTask = Task<string>.Factory.StartNew(() => work(chkRaiseException.Checked));

            someTask.ContinueWith(
                    x => print("task", someTask.Result.ToString()),
                    uiScheduler
                );
        }

        private void btnAsyncTaskEx_Click(object sender, EventArgs e)
        {
            TaskScheduler.UnobservedTaskException += (s, args) =>
            {
                foreach (var ex in args.Exception.Flatten().InnerExceptions)
                {
                    MessageBox.Show(ex.Message);                    
                }

                args.SetObserved();
            };

            //get UI thread context 
            var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            //create and start the Task 
            var someTask = Task<string>.Factory.StartNew(() => work(chkRaiseException.Checked));

            someTask.ContinueWith(
                    x => print("task ex", someTask.Result.ToString()),
                    uiScheduler
                );
        }

        private async void btnASync_Click(object sender, EventArgs e)
        {
            var someTask = Task<string>.Factory.StartNew(() => work(chkRaiseException.Checked));
            await someTask;
            print("async", someTask.Result.ToString());
        }

        private Task<string> workTask(bool raiseException)
        {
            return Task<string>.Factory.StartNew(() => work(raiseException));
        }

        private async void btnAsyncAwait_Click(object sender, EventArgs e)
        {
            print("async", await workTask(chkRaiseException.Checked));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            System.Diagnostics.Process.Start("http://bug.rs");
        }
    }
}
