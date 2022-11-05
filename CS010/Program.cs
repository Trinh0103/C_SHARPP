using System;

namespace CS010
{
    class Student : IDisposable
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Khoi tao " + name);
        }
        ~Student()
        {   
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Huy " + name);
            Console.ResetColor();
        }

        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Huy (boi dispose) " + name);
            Console.ResetColor();
        }
    }
    
    class Program
    {
        static void Test()
        {
            using Student sv = new Student("Ten");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
        }
        static void Main(string[] args)
        {
            Test();
            /*using (Student s = new Student("Ten sinh vien"))
            {

            }
            Student student;
            for ( int i = 0; i < 100000; i++)
            {

            student = new Student("Sinh vien " + i);

            student = null;
            }*/
            
        }
    }
    /*class Program
    {
        static void Main(string[] args)
        {
            Vukhi sungluc; // null
            sungluc = new Vukhi();
            sungluc.name = "Sung luc";
            sungluc.Thietlapdosatthuong(5);

            sungluc.Noisanxuat = "My";
            
            Console.WriteLine(sungluc.Noisanxuat);

            Vukhi sungmay =  new Vukhi("Sung may", 15);

            sungluc.Tancong();
            sungmay.Tancong();
            

            //Vukhi sungtruong = new Vukhi("Xin chao");    


        }
    }*/
}