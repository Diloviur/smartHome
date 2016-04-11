namespace SmartHomeProject.Model.Interfaces.Power
{
    public class WattPower : IPowerable
    {
        private int _power;
        public WattPower(int powerInWatts)
        {
            Power = powerInWatts;
        }
        public int Power
        {
            get { return _power; }
            set
            {
                if (value > 0)
                    _power = value;
            }
        }
    }
}
