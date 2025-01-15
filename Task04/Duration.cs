
using System.Numerics;

namespace Task04
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #region Constructors
        public Duration()
        {
            
        }
        public Duration(int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
        }
        public Duration(int Sec)
        {
            Hours = Sec / 3600;
            Minutes = (Sec % 3600) / 60 ;
            Seconds = Sec - (Hours*3600) - (Minutes*60);
        }
        #endregion

        #region Methods OverRide
        public override bool Equals(object? obj)
        {
            /*GetType() => Get The Type Of this Class */
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration D = (Duration)obj;
            return (Hours == D.Hours) && (Minutes == D.Minutes) && (Seconds == D.Seconds);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public override string ToString()
        {
            if (Hours != 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            else
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
        }
        #endregion

        #region Method OverLoading
        public static Duration operator + (Duration d1, Duration d2)
        {
            return new Duration()
            {
                Hours = d1.Hours + d2.Hours,
                Minutes = d1.Minutes + d2.Minutes,
                Seconds = d1.Seconds + d2.Seconds
            };
        }
        public static Duration operator - (Duration d1, Duration d2)
        {
            return new Duration()
            {
                Hours = d1.Hours - d2.Hours,
                Minutes = d1.Minutes - d2.Minutes,
                Seconds = d1.Seconds - d2.Seconds
            };
        }
        public static Duration operator + (Duration d1, int sec)
        {
            int H = sec / 3600;
            int M = (sec % 3600) / 60;
            int S = sec - (H * 3600) - (M * 60);
            return new Duration()
            {
                Hours = d1.Hours + H ,
                Minutes = d1.Minutes + M ,
                Seconds = d1.Seconds + S
            };
        }
        public static Duration operator +(int sec, Duration d1)
        {
            int H = sec / 3600;
            int M = (sec % 3600) / 60;
            int S = sec - (H * 3600) - (M * 60);
            return new Duration()
            {
                Hours = d1.Hours + H,
                Minutes = d1.Minutes + M,
                Seconds = d1.Seconds + S
            };
        }
        public static Duration operator ++(Duration d)
        {
            return new Duration()
            {
                Hours = d.Hours,
                Minutes = d.Minutes + 1,
                Seconds = d.Seconds
            };
        }
        public static Duration operator -- (Duration d)
        {
            return new Duration()
            {
                Hours = d.Hours,
                Minutes = d.Minutes - 1,
                Seconds = d.Seconds
            };
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            if (d1.Hours > d2.Hours)
            {
                return true;
            }
            else if (d1.Minutes > d2.Minutes)
            {
                return true;
            }
            else if (d1.Seconds > d2.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1.Hours < d2.Hours)
            {
                return true;
            }
            else if (d1.Minutes < d2.Minutes)
            {
                return true;
            }
            else if (d1.Seconds < d2.Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator == (Duration d1, Duration d2)
        {
            if ((d1.Hours == d2.Hours) && (d1.Minutes == d2.Minutes) && (d1.Seconds==d2.Seconds))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Duration d1, Duration d2)
        {
            if ((d1.Hours != d2.Hours) && (d1.Minutes != d2.Minutes) && (d1.Seconds != d2.Seconds))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator true(Duration d)
        {
            return d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0;
        }
        public static bool operator false(Duration d)
        {
            return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
        }

        public static explicit operator DateTime(Duration D)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,D.Hours,D.Minutes,D.Seconds);       
        }
        #endregion


    }
}
