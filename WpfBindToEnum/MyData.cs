using System.ComponentModel;

namespace WpfApplication1
{
    public class MyData : INotifyPropertyChanged
    {
        private Days meetingDays;

        public Days MeetingDays
        {
            get { return meetingDays; }
            set
            {
                switch (value)
                {
                    case Days.None:
                    case Days.WorkingDays:
                    case Days.All:
                        meetingDays = value;
                        break;
                    default:
                        meetingDays ^= value;
                        break;
                }                

                if (null != this.PropertyChanged)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MeetingDays"));
                    PropertyChanged(this, new PropertyChangedEventArgs("MeetingDaysValue"));
                }
            }
        }

        public byte MeetingDaysValue { get { return (byte)meetingDays; } }


        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}