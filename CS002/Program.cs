internal class Program
{
    private static void Main(string[] args)
    {
        double so_pi;
        so_pi = 3.14;

        double hai_pi;
        hai_pi = 2 * so_pi;

        Console.Title = "Vi du su dung Console";
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkMangenta;
        Console.BackgroundColor = ConsoleColor.Black;

        Console.WriteLine("Xin chao, chương trinh xuat du lieu console");

        Console.ResetColor();

        string hovaten;
        Console.Write("Ho va ten cua ban:");
        hovaten = Console.ReadLine();

        Console.WriteLine("Xin chao {0}",hovaten);
        float a, b;
        string sinput;
        Console.WriteLine("Nhap tham so a: ");
        sinput = Console.ReadLine();
        a = float.Parse(sinput);
        
        Console.WriteLine("Nhap tham so b:" );
        sinput = Console.ReadLine();
        b = Console.ToSingle(sinput);
        
        Console.WriteLine("So a = {0} So b = {1}",a,b);
               
        Console.WriteLine(ten);
           

    }
}