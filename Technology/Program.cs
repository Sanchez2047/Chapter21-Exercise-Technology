using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop macBookPro = new Laptop("MacBookPro", 500, 75, 16);
            SmartPhone ihponeX = new SmartPhone("Iphone X", 132, 2.25, 5.85);
            SmartPhone iphone11 = new SmartPhone("Iphone 11", 132, 2.25, 5.85);

 
            macBookPro.PrintDetails();
            ihponeX.PrintDetails();
            iphone11.PrintDetails();



            Console.ReadLine();
        }
    }
}
