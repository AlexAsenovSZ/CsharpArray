using System;

namespace ArrayCube
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int arr_num = 5;
            int[] nums = new int[arr_num];
            Set(nums, arr_num);
            Console.WriteLine("Set");
           Print(nums, arr_num);
            int[,] numcube = new int[3,3];

        }

        public static void Set(int[] arr, int num)
        {
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void Print(int[] arr, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i]);
                Console.Write("\t");
            }
        }
    }
}
