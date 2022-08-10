using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DurationApp
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get;set; }
        public int Seconds { get;set; }
        public Duration(){}
        public Duration(int _hours,int _minutes,int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }

        public Duration(int _duration)
        {
            TimeSpan t = TimeSpan.FromSeconds(_duration);
            Hours=t.Hours;
            Minutes=t.Minutes;
            Seconds=t.Seconds;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            if (Hours==0)
            {
                return $"Output: Minutes: {Minutes} , Seconds: {Seconds}";
            }
            else
            {
                return $"Output: Hours: {Hours}, Minutes: {Minutes} , Seconds: {Seconds}";
            }
        }

        public static Duration operator +(Duration right,Duration left)
        {
            return new Duration
                { Hours = right.Hours + left.Hours,Minutes = right.Minutes+left.Minutes, Seconds = left.Seconds + right.Seconds };
        }
        public static Duration operator +(Duration left, int _seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(_seconds);
            return new Duration
            { Hours = left.Hours + t.Hours, Minutes = left.Minutes + t.Minutes, Seconds = t.Seconds + left.Seconds };
        }
        public static Duration operator +(int _seconds, Duration right)
        {
            TimeSpan t = TimeSpan.FromSeconds(_seconds);
            return new Duration
            { Hours = right.Hours + t.Hours, Minutes = right.Minutes + t.Minutes, Seconds = t.Seconds + right.Seconds };
        }

        public static Duration operator ++(Duration param)
        {
            int seconds = param.Seconds + (param.Minutes * 60) + (param.Hours * 60 * 60) + 60;
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            return new Duration {Hours = t.Hours, Minutes = t.Minutes, Seconds = t.Seconds};
        }

        public static Duration operator --(Duration param)
        {
            int seconds = param.Seconds +( param.Minutes * 60) + (param.Hours * 60 * 60)-60;
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            return new Duration { Hours = t.Hours, Minutes = t.Minutes, Seconds = t.Seconds };
        }
        public static bool operator >(Duration left, Duration right)
        {
            int secondsLeft = left.Seconds + (left.Minutes * 60) + (left.Hours * 60 * 60) ;
            int secondsRight= right.Seconds + (right.Minutes * 60) + (right.Hours * 60 * 60);
            return secondsLeft > secondsRight;
        }
        public static bool operator <(Duration left, Duration right)
        {
            int secondsLeft = left.Seconds + (left.Minutes * 60) + (left.Hours * 60 * 60);
            int secondsRight = right.Seconds + (right.Minutes * 60) + (right.Hours * 60 * 60);
            return secondsLeft < secondsRight;
        }
        public static bool operator <=(Duration left, Duration right)
        {
            int secondsLeft = left.Seconds + (left.Minutes * 60) + (left.Hours * 60 * 60);
            int secondsRight = right.Seconds + (right.Minutes * 60) + (right.Hours * 60 * 60);
            return secondsLeft <= secondsRight;
        }
        public static bool operator >=(Duration left, Duration right)
        {
            int secondsLeft = left.Seconds + (left.Minutes * 60) + (left.Hours * 60 * 60);
            int secondsRight = right.Seconds + (right.Minutes * 60) + (right.Hours * 60 * 60);
            return secondsLeft >= secondsRight;
        }
        public static bool operator ==(Duration left, Duration right)
        {
            int secondsLeft = left.Seconds + (left.Minutes * 60) + (left.Hours * 60 * 60);
            int secondsRight = right.Seconds + (right.Minutes * 60) + (right.Hours * 60 * 60);
            return secondsLeft == secondsRight;
        }
        public static bool operator !=(Duration left, Duration right)
        {
            int secondsLeft = left.Seconds + (left.Minutes * 60) + (left.Hours * 60 * 60);
            int secondsRight = right.Seconds + (right.Minutes * 60) + (right.Hours * 60 * 60);
            return secondsLeft != secondsRight;
        }
        public static implicit operator bool(Duration param)
        {
            return param is not null;
        }
    }
}
