using System;
using System.Threading.Tasks;
namespace CS29
{
    class Program
    {   
        static void DoSomeThing(int second, string message, ConsoleColor color){
            lock(Console.Out){
                Console.ForegroundColor = color;
                System.Console.WriteLine("Start");
                Console.ResetColor();
            }
            for (int i = 1; i <= second; i++)
            {   
                lock(Console.Out){
                Console.ForegroundColor = color;
                System.Console.WriteLine($"{message} {i}");
                Console.ResetColor();
                }
                Thread.Sleep(1000);
            }
            lock(Console.Out){
                Console.ForegroundColor = color;
                System.Console.WriteLine("End");
                Console.ResetColor();
            }
            // Thread.Sleep(5000);
        } 

        static void Main(string[] args)
        {
            // System.Console.WriteLine("---");
            // DoSomeThing(5,"ABC");
            // System.Console.WriteLine("Xin chao");
             //Lap trih dong bo synchronous : Thi hanh theo thu tu
            //  DoSomeThing(6,"Mot",ConsoleColor.Red);
            //  DoSomeThing(10,"Hai",ConsoleColor.Green);
             
             System.Console.WriteLine("Hello");
             //asynchronous: Lap trinh bat dong bo => ung dung chay da luong
             //Task
             Task t2 = new Task(
                () => {
                    DoSomeThing(10,"Hai",ConsoleColor.Green);
                }
             ); //() => {}


             Task t3 = new Task(
                (object ob) => {
                    string ten = (string)ob;
                    DoSomeThing(4, ten, ConsoleColor.Yellow);
                }, "T3"); //(Object ob) => {} 

             //Khoi chay tac vu
             t2.Start();      
             t3.Start();
            System.Console.WriteLine("End");
        }
    }
}