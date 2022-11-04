using System;
using System.Linq;

namespace CS008
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string sinhvien1 = "Nguyen Van A";
            //string sinhvien2 = "Nguyen Van B";
            //string sinhvien3 = "Nguyen Van C";

            //Console.WriteLine(sinhvien1);
            //Console.WriteLine(sinhvien2);
            //Console.WriteLine(sinhvien3);

            //string[] ds;
            //ds = new string[3];

            //ds[0] = "Nguyen Van A";
            //ds[1] = "Nguyen Van B";
            //ds[2] = "Nguyen Van C";

            //Console.WriteLine(ds[0]);
            //Console.WriteLine(ds[1]);
            //Console.WriteLine(ds[2]);
            //for (int i = 0; i <= 2; i++)
            //{
                //Console.WriteLine(ds[i]);
            //}

            //int[] mangsonguyen;
            //string[] mang1 = new string[2] {"Dien thoai", "May tinh"};
            //double[] mang2 = {0.1, 0.5, 20, 40};

            //mangsonguyen = new int[3] {1, 2, 3};

            //int[] numbers = {1, 4, 7, 4, 3, 7, 34, 7};

            //int sophantu = numbers.Length;
            
            //for ( int chiso = sophantu - 1; chiso >= 0; chiso--)
            //{
                //Console.WriteLine(numbers[chiso]);
            //}

            //foreach (var abc in numbers)
            //{
              //  Console.WriteLine(abc);
            //}
            
            //Console.WriteLine($"So phan tu: {numbers.Length}");
            //Console.WriteLine($"chieu: {numbers.Rank}");

            //Console.WriteLine($"Min: {numbers.Min()}");
            //Console.WriteLine($"Max: {numbers.Max()}");
            //Console.WriteLine($"Sum: {numbers.Sum()}");

            //Sap xep tang dan
            //Array.Sort(numbers);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            double[,] numbers = new double[2, 3] {{2, 3, 4.5}, {1, 9, 8} };
            
            //in phan thu theo hang va cot
            //Console.WriteLine(numbers[0, 2]);

            //in ra 1 ma tran
            int hang = 2;
            int cot = 3;

            for (int i = 0; i< hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write(numbers[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}