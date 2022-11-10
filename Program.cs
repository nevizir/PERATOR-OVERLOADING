using System;

namespace PERATOR_OVERLOADING
{
    class Time
    {
        public int hours;
        public int minutes;
        public int seconds;

        public Time()
        {
            hours = 0; minutes = 0; seconds = 0; 
        }
        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void Show()
        {
            Console.WriteLine($"Time::  {hours}:{minutes}:{seconds}");
        }
       
        public void ExactTime()
        {
            this.hours = DateTime.Now.Hour;
            this.minutes = DateTime.Now.Minute;
            this.seconds = DateTime.Now.Second;
        }

        public static Time operator ++(Time time)
        {
            time.seconds += 1;
            return time;
        }
        public static Time operator --(Time time)
        {
            time.seconds -= 1;
            return time;
        }

        public static bool operator >(Time left, Time right)
        {
            return left.hours > right.hours;
        }
        public static bool operator <(Time left, Time right)
        {
            return !(left > right);
        }
        public static bool operator >=(Time left, Time right)
        {
            return left.hours >= right.hours;
        }
        public static bool operator <=(Time left, Time right)
        {
            return !(left >= right);
        }
        public static bool operator ==(Time left, Time right)
        {
            return left.hours == right.hours;
        }
        public static bool operator !=(Time left, Time right)
        {
            return !(left == right);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Time time = new Time();
            time.Show();
            time.ExactTime();
            time.Show();
        }
    }
}
