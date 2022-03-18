using System;
namespace LaptopShop
{
    public class MobileCpu
    {
        private string[] brand = {"Intel", "AMD"};
        //private string[] modelIntel = { "Core i3", "Core i5", "Core i7", "Ryzen 3", "Ryzen 5", "Ryzen 7" };
        private string[] model = { "Core i3", "Core i5", "Core i7", "Ryzen 3", "Ryzen 5", "Ryzen 7"};
        //private string[] serie = { "11320H", "11400K", "11400F", "11400"}

        public MobileCpu()
        {
        }

        public string GetBrand(int num)
        {
            //Console.WriteLine("Brand count: " + this.brand.Length);
            if (num >= 0 && num < this.brand.Length) { 
            return this.brand[num];
        }
            this.PrintString(this.brand, this.brand.Length);
            return "Error";
        }

        public void PrintString(string[] array, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i+ " = "+array[i]);
            }
        }

        public string GetModel(int num)
        {
            return this.model[num];
        }
    }
}
