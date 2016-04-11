using SmartHomeProject.Model.Interfaces.Power;

namespace SmartHomeProject.Model.Devices.Lighting
{
    public abstract class LightingBase : DeviceCore, IPowerable
    {
        private IPowerable _powerProperty;
        public LightingBase(string name, string location, int powerInWatts)
            : base(name, location)
        {
            _powerProperty = new WattPower(powerInWatts);
        }
        public int Power
        {
            get { return _powerProperty.Power; }
            set { _powerProperty.Power = value; }
        }
    }
}
