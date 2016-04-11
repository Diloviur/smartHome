using System;

namespace SmartHomeProject.Model.Devices.Lighting
{
    public class SimpleLight : LightingBase
    {
        public SimpleLight(string name, string location, int power)
            : base(name, location, power){ }
        public override string ToString()
        {
            return String.Format("Устройство: {0}.\nПоложение: {1}.\nМощность: {2}.\nСтатус: {3}.", Name, Location, Power.ToString(), IsEnable.ToString());
        }
    }
}
