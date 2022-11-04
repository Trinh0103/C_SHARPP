using System;

namespace CS009
{
    class Count
    {
        public int c = 1;
    }
    class Program
    {   
        /*
        <Access Modifiers> <return type> <name_method>(<parameters>)
        {
            // Các câu lên trong phương thức
        }
        */

        /*public static int tich(int a, int b)
        {
            int result;
            result = a * b;
            return result;
        }

        public static void Main(string[] args)
        {
            int ketqua;
            xinchao();
            ketqua = tich(3,4);

            Console.WriteLine(ketqua);
        }

        static void xinchao()
        {
            Console.WriteLine("======================");
            Console.WriteLine("Xin chao cac ban");
        }
        
        public static void Main(string[] args)
        {
            int x = 234;
            int y = 456;
            var result = Tinhtoan.tong(x, y);
            Console.WriteLine(result);

            float a = 12.12f;
            float b = 10.0f;

            var result1 = Tinhtoan.tong(a, b);
            Console.WriteLine(result1);
            
        }
        

        public static void Main(string[] args)
        {
            //xinchao(ho: "Nguyen Phuoc", ten: "Trinh"); //co the viet ten truoc
            xinchao("Trinh");
            xinchao("Trinh","Nguyen Phuoc");
        }

        static void xinchao(string ten, string ho = "Tran Phuoc")
        {
            string fullname;
            fullname = ho + " " + ten;

            Console.WriteLine($"Xin chao {fullname}");
        }
        

        public static void Main(string[] args)
        {
            int a;
            binhphuong(4, out a);
                       
            Console.WriteLine(a);
            
        }

        static void binhphuong(int x, out int kq)
        {
            kq = x * x;
            
        }
        */
        public static void Main(string[] args)
        {
            Count count = new Count();
            Console.WriteLine(count.c);

            dem(count);
            Console.WriteLine(count.c);
        }

        static void dem(Count count)
        {
            count.c ++;
        }
    }
}