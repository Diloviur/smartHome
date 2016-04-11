using SmartHomeProject.Model.Interfaces.Brightness;
using SmartHomeProject.Model.Interfaces.Timers;
using System;
using System.Collections.Generic;

namespace SmartHomeProject.Model.Devices.Lighting
{
    public class LedLight : LightingBase, IBrightnessable, ITimerable
    {
        private IBrightnessable _brightnessProperty;
        private ITimerable _timerProperty;
        public LedLight(string name, string location, int power, IBrightnessable brightnessProperty = null, ITimerable timerProperty = null)
            : base(name, location, power)
        {
            BrightnessProperty = brightnessProperty;
            TimerProperty = timerProperty;
        }
        public ITimerable TimerProperty 
        {
            set { _timerProperty = value; } 
        }
        public IBrightnessable BrightnessProperty
        {
            set { _brightnessProperty = value; }
        }
        public void SetTimer(int days, int hours, int minutes, int seconds, int millisec)
        {
            if (_timerProperty != null)
                _timerProperty.SetTimer(days, hours, minutes, seconds, millisec);
            else
                throw new System.ArgumentException("TimerIsAbsentForThisLedLight->SetTheTimerPropertyAtFirst");
        }
        public string RemainingTime()
        {
            if (_timerProperty != null)
                return _timerProperty.RemainingTime();
            else
                throw new System.ArgumentException("TimerIsAbsentForThisLedLight->SetTheTimerPropertyAtFirst");
        }
        public int Brightness
        {
            get 
            {
                if (_brightnessProperty != null)
                    return _brightnessProperty.Brightness; 
                else
                    throw new System.ArgumentException("BrightnessIsAbsentForThisLedLight->SetTheBrightnessPropertyAtFirst");
            }
            set 
            {
                if (_brightnessProperty != null)
                    _brightnessProperty.Brightness = value; 
                else
                    throw new System.ArgumentException("BrightnessIsAbsentForThisLedLight->SetTheBrightnessPropertyAtFirst");
            }
        }
        public override string ToString()
        {
            return String.Format("Устройство: {0}.\nПоложение: {1}.\nМощность: {2}.\nТаймер: {3}.\nЯркость: {4}.\nСтатус: {5}."
                , Name
                , Location
                , Power.ToString()
                , _timerProperty!=null ? "TimerIsSet: " + RemainingTime() : "TimerIsAbsent"
                , _brightnessProperty != null ? "BrightnessIsSet: " + Brightness.ToString(): "BrightnessIsAbsent"
                , IsEnable.ToString());
        }
    }
}
