using SmartHomeProject.Model.Devices;
using SmartHomeProject.Model.Devices.Lighting;
using SmartHomeProject.Model.Devices.ClimateControl;
using System;
using System.Collections.Generic;
using SmartHomeProject.Model.Interfaces.Timers;
using SmartHomeProject.Model.Interfaces.Brightness;

namespace SmartHomeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var ti = new LedLight("LED_1", "WC", 80, null, new Timer());
            ti.SetTimer(0, 0, 0, 10, 0);
            ti.BrightnessProperty = new PercentBrightness(50);

            var cond = new AirConditioner("Cond_1", "Bedroom", 100, 26, "spring");
            Console.WriteLine(cond.ToString());
            Console.WriteLine();

            Console.WriteLine("Введите имя новой программы: ");
            cond.AddProgramToProgramList(Console.ReadLine());
            Console.WriteLine();

            //need to catch this exeption
            //cond.GetProgramList().RemoveAt(5);

            Console.WriteLine("Список доступных программ для кондиционера:");
            foreach (string program in cond.GetProgramList())
            {
                Console.WriteLine(program);
            }
            Console.WriteLine();
            Console.WriteLine("Выберите одну программу из списка:");
            cond.Program = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(cond.ToString());
            Console.WriteLine();

            List<DeviceCore> devices = new List<DeviceCore>();
            devices.Add(new SimpleLight("Lightbulb_1", "WC", 40));
            devices.Add(new AirConditioner("Cond_1", "Bedroom", 100, 26, "Spring"));
            devices.Add(new Fan("Fan_1", "Street", 80));
            devices.Add(new Kolorifer("Kolorifer_1", "Bathroom", 20, 25.3));
            devices.Add(new WarmFloor("WarmFloor_1", "Bedroom", 30.5));
            devices.Add(new SimpleLight("Lightbulb_2", "Corridor", 60));
            devices.Add(new WarmFloor("WarmFloor_2", "Corridor", 25));
            devices.Add(ti);

            devices[1].PowerStatusSwitcher();
            devices[3].PowerStatusSwitcher();
            devices[4].PowerStatusSwitcher();
            devices[5].PowerStatusSwitcher();
            devices[6].PowerStatusSwitcher();

            System.Threading.Thread.Sleep(2000);

            foreach (var device in devices)
            {
                Console.WriteLine(device.ToString());
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
