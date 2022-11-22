using System;

namespace CS025
{    
    class Program
    {
        static void Register(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                //Exception exception = new Exception("Ten phai khac rong");
                throw new NameEmptyException();
            }
            if (age <18 || age > 100)
            {
                throw new AgeException(age);
            }
            //...
            Console.WriteLine($"Xin chao {name} ({age})");
        }
        static void Main(string[] args)
        {
            // int a = 5;
            // int b = 4;

            // // Exception
            
            
            
            // try
            // {
            //     var c = a / b;          // phat sinh doi tuong lop Exception, ke thua Exception
            //     Console.WriteLine(c);
            //     int[] i = {1,2};
            //     var x = i[5];
            // }
            // // catch(Exception e)
            // // {
            // //     Console.WriteLine(e.Message);
            // //     Console.WriteLine(e.StackTrace);
            // //     Console.WriteLine(e.GetType().Name);
            // //     Console.WriteLine("Phep chia co loi");
            // // }
            // catch(DivideByZeroException e)
            // {
            //     Console.WriteLine(e.Message);
            //     Console.WriteLine("Khong duoc phep chia cho 0");
            // }
            // catch(IndexOutOfRangeException e2)
            // {
            //     Console.WriteLine(e2.Message);
            //     Console.WriteLine("Chi so mang khong phu hop");
            // }
            // catch(Exception e1)
            // {
            //     Console.WriteLine(e1.Message);
            //     Console.WriteLine("Phep chia co loi");
            // }
            
            // String path = "1.txt";
            // try
            // {
            //     String s = File.ReadAllText(path);
            //     Console.WriteLine(s);
            // }
            // catch (FileNotFoundException fnfe)
            // {
            //     Console.WriteLine(fnfe.Message);
            //     Console.WriteLine("File khong ton tai");
            // }
            // catch (AbandonedMutexException ane)
            // {
            //     Console.WriteLine(ane.Message);
            //     Console.WriteLine("Duong dan file phai khac nhau null");
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // Console.WriteLine("Ket thuc");

            try
            {
                Register("",20);
            }
            catch (NameEmptyException nee)
            {
                Console.WriteLine(nee.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                e.Detail();
            }
           
        }
    }
}