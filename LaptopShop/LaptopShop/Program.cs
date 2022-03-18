using System;

namespace LaptopShop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MobileCpu pc = new MobileCpu();

            Console.WriteLine("CPU Brand: "+ pc.GetBrand(5));
            Console.WriteLine("CPU Model: " + pc.GetModel(0));
        }
    }
}
