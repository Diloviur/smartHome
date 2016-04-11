using SmartHomeProject.Model.Interfaces.Temperature;
using System;
using System.Collections.Generic;

namespace SmartHomeProject.Model.Devices.ClimateControl
{
    public class WarmFloor : DeviceCore, ITemperatureable
    {
        private ITemperatureable _temperatureCelsius;
        public WarmFloor(string name, string location, double temperatureCelsius)
            : base(name, location)
        {
            _temperatureCelsius = new TemperatureCelsius(temperatureCelsius);
        }
        public double Temperature
        {
            get { return _temperatureCelsius.Temperature; }
            set { _temperatureCelsius.Temperature = value; }
        }
        public override string ToString()
        {
            return String.Format("Устройство: {0}.\nПоложение: {1}.\nТемпература: {2}.\nСтатус: {3}.", Name, Location, Temperature.ToString(), IsEnable.ToString());
        }
    }
}
