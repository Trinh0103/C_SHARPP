using System;

namespace CS16_Generic
{
    class Program
    {   class Product<A>
        {
            A id;
            public void SetID(A _id)
            {
                this.id = _id;
            }

            public void getInfo()
            {
                System.Console.WriteLine($"ID = {this.id}");
            }
        }
        static void Swap<T>(ref T x, ref T y)
        {
            T t;
            t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            string a = "A";
            string b = "B";
            System.Console.WriteLine($"a = {a}, b = {b}");
            Swap<string>(ref a, ref b); 
            System.Console.WriteLine($"a = {a}, b = {b}");

            Product<int> sp1 = new Product<int>();
            sp1.SetID(123);
            sp1.getInfo();
            Product<string> sp2 = new Product<string>();
            sp2.SetID("A102");
            sp2.getInfo();
        }
    }
}