using System;

namespace WpfApplication1
{    
    [Flags]
    public enum Days : byte
    {
        None = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40,
        /// <summary>
        /// Monday to Friday
        /// </summary>
        WorkingDays = Monday | Tuesday | Wednesday | Thursday | Friday,
        /// <summary>
        /// All days in week
        /// </summary>
        All = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday
    }
}
