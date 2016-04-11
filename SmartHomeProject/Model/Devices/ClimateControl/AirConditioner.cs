using SmartHomeProject.Model.Interfaces.Program;
using System;
using System.Collections.Generic;

namespace SmartHomeProject.Model.Devices.ClimateControl
{
    public class AirConditioner : Kolorifer, IProgramable
    {
        private List<string> _programList;

        private string _program;
        public AirConditioner(string name, string location, int speedInPercent, double temperatureCelsius, string program)
            : base(name, location, speedInPercent, temperatureCelsius)
        {
            //На самом деле лист программ должен быть записан в перечисление. Текущее значение может сверяться с ним.
            //Пользователь должен иметь возможность вносить в лист свои собственные программы.
            //Иногда для экономии памяти, лист правильно оформить в виде статического массива с несколькими заразервированными полями для программ пользователя.
            //Для упрощения кода, здесь специально использованны именно такие меры 
            _programList = new List<string> 
            { 
                "default",
                "winter", 
                "spring",
                "summer",
                "autumn",
            };
            Program = program;
        }
        public void AddProgramToProgramList(string programName)
        {
            _programList.Add(programName);
        }
        public IList<string> GetProgramList()
        {
            return _programList.AsReadOnly();
        }
        public string Program 
        {
            get { return _program; }
            set 
            {
                if (_programList.Contains(value))
                    _program = value;
                else
                    _program = _programList[0];
            }
        }
        public override string ToString()
        {
            return String.Format("Устройство: {0}.\nПоложение: {1}.\nТемпература: {2}.\nСкорость: {3}.\nПрограмма: {4}.\nСтатус: {5}.", Name, Location, Temperature.ToString(), Speed.ToString(), Program, IsEnable.ToString());
        }
    }
}
