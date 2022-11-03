internal class Program
{
    private static void Main(string[] args)
    {
        /*
            if (dieu_kien_logic)
                dong_lenh;
            
            if (dieu_kien_logic)
            {
                ... khoi lenh else
            }
            else if (dieu_kien_1)
            {
                ...khoi lenh else
            }
            else if (dieu_kien_2)
            {
                ...khoi lenh else
            }
        */

        /*int a;
        Console.WriteLine("Nhap so nguyen a:");
        a = int.Parse(Console.ReadLine());

        //a % 2 == 0;
        if (a % 2 == 0)
        {
            Console.WriteLine("ket qua:");
            Console.WriteLine($"So {a} la so chan");
        }
        else
        {
            Console.WriteLine("ket qua:");
            Console.WriteLine($"So {a} la so le");
        }

        Console.WriteLine("The end");
        */

        float dtb;
        Console.WriteLine("Hay nhap dien trung binh:");
        dtb = float.Parse(Console.ReadLine());

        if (dtb < 5.0)
        {
            Console.WriteLine("Hoc luc yeu");
        }
        else if (dtb < 6.5)
        {
            Console.WriteLine("Hoc luc trung binh");
        }
        else if (dtb < 8.0)
        {
            Console.WriteLine("Hoc luc kha");
        }
        else if (dtb <= 10.0)
        {
            Console.WriteLine("Hoc luc gioi");
        }
        else 
        {
            Console.WriteLine("Nhap sai so diem");
        }
    }
}