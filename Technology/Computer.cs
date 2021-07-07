using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer
    {
        public const string Brand = "Apple";
        public double StorageCapacity { get; set; }
        public double EnergyConsumption { get; set; }
        public double ScreenSize { get; set; }
        public int StandardOperatingTemp { get; set; }

        public double EneryPerYear(double hoursPerDay)
        {
            double energyPerYear = ((EnergyConsumption * hoursPerDay)*365) / 1000;
            Console.WriteLine($"Energy used per year: {energyPerYear} kWh");
            return energyPerYear;
        }

    }
}
