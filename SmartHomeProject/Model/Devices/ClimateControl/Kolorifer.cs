using SmartHomeProject.Model.Interfaces.Speed;
using SmartHomeProject.Model.Interfaces.Temperature;
using System;
using System.Collections.Generic;

namespace SmartHomeProject.Model.Devices.ClimateControl
{
    public class Kolorifer : Fan, ITemperatureable
    {
        private ITemperatureable _temperatureCelsius;
        public Kolorifer(string name, string location, int speedInPercent, double temperatureCelsius)
            : base(name, location, speedInPercent)
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
            return String.Format("Устройство: {0}.\nПоложение: {1}.\nТемпература: {2}.\nСкорость: {3}.\nСтатус: {4}.", Name, Location, Temperature.ToString(), Speed.ToString(), IsEnable.ToString());
        }
    }
}
