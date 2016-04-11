using SmartHomeProject.Model.Interfaces.Speed;
using System;
using System.Collections.Generic;

namespace SmartHomeProject.Model.Devices.ClimateControl
{
    public class Fan : DeviceCore, ISpeedable
    {
        private ISpeedable _percentSpeed;
        public Fan(string name, string location, int speedInPercent)
            : base(name, location)
        {
            _percentSpeed = new PercentSpeed(speedInPercent);
        }
        public int Speed
        {
            get { return _percentSpeed.Speed; }
            set { _percentSpeed.Speed = value; }
        }
        public override string ToString()
        {
            return String.Format("Устройство: {0}.\nПоложение: {1}.\nСкорость: {2}.\nСтатус: {3}.", Name, Location, Speed.ToString(), IsEnable.ToString());
        }
    }
}
