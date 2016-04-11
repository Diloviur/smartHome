using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHomeProject.Model.Interfaces.Speed
{
    public class PercentSpeed : ISpeedable
    {
        private int _speed;
        public PercentSpeed(int speedInPercent)
        {
            Speed = speedInPercent;
        }
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value >= 0 && value <= 100)
                    _speed = value;
            }
        }
    }
}
