using System;

namespace SmartHomeProject.Model.Interfaces.Timers
{
    public class Timer : ITimerable
    {
        private TimeSpan TimerTime;
        public DateTime StartingTime { private set; get; }
        public Timer()
        {
            TimerTime = new TimeSpan(0);
        }
        public void SetTimer(int days = 0, int hours = 0, int minutes = 0, int seconds = 0, int millisec = 0)
        {
            StartingTime = DateTime.Now;
            TimerTime = new TimeSpan(days, hours, minutes, seconds, millisec);
        }
        public TimeSpan TimeSpanRemainingTime()
        {
            if (TimerTime.Ticks != 0)
                return StartingTime.Add(TimerTime).Subtract(DateTime.Now);
            else
                return TimerTime;
        }
        public string RemainingTime()
        {
            return TimeSpanRemainingTime().ToString();
        }

    }
}
