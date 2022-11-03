internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Nhap so a:");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap so b:");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Hay chon lenh");
        Console.WriteLine("1. Tinh tong");
        Console.WriteLine("2. Tinh hieu");
        Console.WriteLine("3. Tinh tich");
        Console.WriteLine("4. Tinh thuong");

        char c;
        c = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (c){
            case '1':
                Console.WriteLine($"Tong la: {a + b}");
            break;
            case '2':
                Console.WriteLine($"Hieu la: {a - b}");
            break;
            case '3':
                Console.WriteLine($"Tich la: {a * b}");
            break;
            case '4':
                Console.WriteLine($"Thuong la: {a / b}");
            break;

            default:
                Console.WriteLine("Hay chon lenh khac");
            break;
        }


    }
}