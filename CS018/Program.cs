using System;
using System.Threading.Tasks.Dataflow;

namespace CS018
{
    class Abc 
    {
        public void Xinchao() => Console.WriteLine("Xin chao C#");
    }
    class Program
    {
        static void Main(string[] args)
        {
            // nulln nullable
            // null

            //Abc a = new Abc();

            //if (a != null)
            //    a.Xinchao();
            //a?.Xinchao();

            int? age;
            age = null;

            age = 100;

            //if (age.HasValue)
            if (age != null)
            {
                //int _age = age.Value;
                int _age = (int)age;
                Console.WriteLine(_age);
            }

        }
    }
}