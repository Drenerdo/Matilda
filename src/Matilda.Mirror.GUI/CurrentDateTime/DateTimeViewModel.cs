using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matilda.Mirror.GUI.CurrentDateTime
{
   public class DateTimeViewModel : PropertyChangedBase
    {
        private string currentTime;
        public string CurrentTime
        {
            get
            {
                return currentTime;
            }
            set
            {
                if (currentTime != value)
                {
                    currentTime = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string currentDate;
        public string CurrentDate
        {
            get
            {
                return currentDate;
            }
            set
            {
                if (currentDate != value)
                {
                    currentDate = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string currentWeekDay;
        public string CurrentWeekDay
        {
            get
            {
                return currentWeekDay;
            }
            set
            {
                if (currentWeekDay != value)
                {
                    currentWeekDay = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public DateTimeViewModel()
        {
            GetDateTime();
        }
        private void GetDateTime()
        {
            DateTime now = DateTime.Now;
            CurrentWeekDay = now.DayOfWeek.ToString();
            CurrentDate = now.ToString("MMMM dd, yyyy");
            CurrentTime = now.ToString("hh:mm tt");

        }
    }
}
