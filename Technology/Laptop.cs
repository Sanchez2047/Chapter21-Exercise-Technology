using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer
    {
        public int NumOfUnreadEmail { get; set; }
        public int CountOfCourdTrippedOver { get; set; }

        public bool IsOverheated(double hours)
        {
            StandardOperatingTemp += hours * 10;
            if (StandardOperatingTemp > 158)
            {
                Console.WriteLine("OVERHEATED!! EMERGENCY SHUTDOWN INITIATED");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TripOverCord()
        {
            CountOfCourdTrippedOver += 1;
        }

        public Laptop(string modelname, double storage, double energy, double screensize) : base(modelname, storage, energy, screensize)
        {
                this.ModelName = modelname;
                this.StorageCapacity = storage;
                this.EnergyConsumption = energy;
                this.ScreenSize = screensize;
        }

    }

}
