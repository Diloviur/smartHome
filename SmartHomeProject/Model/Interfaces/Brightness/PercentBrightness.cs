namespace SmartHomeProject.Model.Interfaces.Brightness
{
    public class PercentBrightness : IBrightnessable
    {
        private int _brightness;
        public PercentBrightness(int brightnessInPercent)
        {
            Brightness = brightnessInPercent;
        }
        public int Brightness
        {
            get { return _brightness; }
            set
            {
                if (value >= 0 && value <= 100)
                    _brightness = value;
            }
        }
    }
}
