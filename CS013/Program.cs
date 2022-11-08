using System;

namespace CS013
{
    class Program
    {
        static void Main(string[] args)
        {
            //hang so
            //Console.WriteLine($"Hang so PI: {Math.PI}, E: {Math.E}");
            
            // Max, Min
            //double a = 33;
            //double b = 344;
            //double c = 2382;

            //Console.WriteLine($"Max {Math.Max(Math.Max(a,b),c)}");

            //Console.WriteLine($"Max {Math.Max(5, 6)}");
            //Console.WriteLine($"Min {Math.Min(5, 6)}");

            //Abs, Sign
            //Console.WriteLine($"Gia tri tuyet doi: {Math.Abs(-134)}");

            // luong giac
            // Sin, Cos, Tan, Asin, Acos, Atan
            //Console.WriteLine($"Sin: {Math.Sin(Math.PI/4)}");
            //double deg = 60;
            // PI ~ 180
            //      x
            //double rad = Math.PI * deg / 180;
            //for (int i = 0; i <= 90; i++)
            //{
            //    rad = Math.PI * i / 180;
            //    Console.WriteLine($"Sin cua {i} (deg): {Math.Sin(rad)}");
            //}
            

            // Sqrt(a), Pow(a, b), Log(a), Log10(10)
            //Console.WriteLine($"Can: {Math.Sqrt(3)}");
            //Console.WriteLine($"Luy thua: {Math.Pow(2, 5)}");
            //Console.WriteLine($"Log: {Math.Log(8)}");

            //Lam tron
            //Math.Round(a); 5.6 => 6, 5.4 => 5 
            //Math.Ceiling(a); 5.1,5.5,5.7 => 6 lam tron so lon hon
            //Math.Floor(b); 5.1,5.5,5.7 => 5 lam tron so nho hon
            //Math.Truncate(a); 5.1,5.5,5.7 => 5 cat phan thap phan
            
            Console.WriteLine($"Round: {Math.Round(5.5)}");
            Console.WriteLine($"Ceiling: {Math.Ceiling(5.1)}");
            Console.WriteLine($"Floor: {Math.Floor(5.9)}");
            Console.WriteLine($"Truncate: {Math.Truncate(5.4)}");
            









        }
    }
}