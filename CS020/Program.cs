using System;

// delegate (Type) bien = phuongthuc
namespace CS020
{
    //public delegate void Showlog(string message);
    class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }        
        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        //delegate int KIEU1();

        static int Tong(int a, int b) => a + b;
        static int THieu(int a, int b) => a - b;
        private static void Main(string[] args)
        {
            //Showlog log = null; //+=

            //log = Info;
            //if (log != null)
            //   log("Xin chao");
            //log?.Invoke("Xin chao Abc"); nen dung

            //log = Warning;
            //log("Hoc ve delegate");

            //og += Info;
            //log += Warning;

            //log?.Invoke("Xin chao cac ban");

            //Action, Func : delegate - gereric

            //Action action:                  // ~ delegate void KIEU();
            //Action<string, int> action1;    // ~ delegate void KIEU(string s, int i);

            //Action<String> action2;         // ~ delegate void KIEU(string s)

            //action2 = Warning;
            //action1 = Warning; LOI
            //action2 += Info;
            //action2?.Invoke("Thong bao tu Action");

            //KIEU1 fi;
            //Func<int> fi;                       // ~ delegate int KIEU();
            //Func<string, double, string> f2;    // ~ delegate int KIEU(string s, double s);

            Func<int, int, int> tinhtoan;         // ~ delegate int kieu(int a, itn b);
            int a = 5;
            int b = 10;

            tinhtoan= Tong;
            Console.WriteLine($"KQ {tinhtoan(a,b)}");




        }
    }
}