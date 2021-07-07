using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public const string Brand = "Apple";
        public string ModelName { get; set; }
        public double StorageCapacity { get; set; }
        public double EnergyConsumption { get; set; }
        public double ScreenSize { get; set; }
        public double StandardOperatingTemp { get; set; }
       

        public double EneryPerYear(double hoursPerDay)
        {
            double energyPerYear = ((EnergyConsumption * hoursPerDay)*365) / 1000;
            Console.WriteLine($"Energy used per year: {energyPerYear} kWh");
            return energyPerYear;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Brand:{Brand}\nModel: {ModelName}\nStorage Capacity: {StorageCapacity}\nScreen Size: {ScreenSize}\n Id:{UniqueId}");
        }
        public Computer(string modelname, double storage, double energy, double screensize)
        {
            this.ModelName = modelname;
            this.StorageCapacity = storage;
            this.EnergyConsumption = energy;
            this.ScreenSize = screensize;
            this.StandardOperatingTemp = 65;
        }

    }
}
