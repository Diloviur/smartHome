namespace SmartHomeProject.Model.Interfaces.Timers
{
    public interface ITimerable
    {
        void SetTimer(int days, int hours, int minutes, int seconds, int millisec);
        string RemainingTime();
    }

}
