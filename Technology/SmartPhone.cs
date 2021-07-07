using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public List<string> Apps = new List<string> { "Flappy Bird", "Facebook", "Twitter", "SnapChat", "LinkedIn", "Instagram" };
        public List<string> Contacts = new List<string> { "Mike", "Carter", "Jose", "Kristine", "Colton", "Vincent", "Redgy", "Shea" };
        private static Random rdm = new Random();

        public int MakeACall(string input)
        {
            //Console.WriteLine("Who would you like to call?");
            //int userInput = Contacts.IndexOf(Console.ReadLine());
            int userInput = Contacts.IndexOf(input);
            Console.WriteLine($"Calling {Contacts[userInput]}...");
            return userInput;
        }
        public string WhatAppToUse()
        {
            int num = rdm.Next(Apps.Count);
            return Apps[num];
        }

        public SmartPhone(string modelname, double storage, double energy, double screensize) : base(modelname, storage, energy, screensize)
        {
            this.ModelName = modelname;
            this.StorageCapacity = storage;
            this.EnergyConsumption = energy;
            this.ScreenSize = screensize;
        }
    }


}
