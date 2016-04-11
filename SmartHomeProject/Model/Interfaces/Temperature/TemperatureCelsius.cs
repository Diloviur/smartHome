namespace SmartHomeProject.Model.Interfaces.Temperature
{
    public class TemperatureCelsius : ITemperatureable
    {
        private double _temperature;
        public TemperatureCelsius(double temperatureCelsius)
        {
            Temperature = temperatureCelsius;
        }
        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }
    }
}
