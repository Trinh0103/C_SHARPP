internal class Program
{
    private static void Main(string[] args)
    {
        bool kq;
        // == > < >= <= !=
        // && || !
        //isOnline = true;
        //isOnline = false;
        /*int a = 5;
        int b = 6;

        kq = a == b;

        Console.WriteLine("a == b ==> {0}", kq);
        Console.WriteLine($"a != b ==> {a != b}");
        Console.WriteLine($"a > b ==> {a > b}");
        Console.WriteLine($"a >= b ==> {a >= b}");
        Console.WriteLine($"a < b ==> {a < b}");
        Console.WriteLine($"a <= b ==> {a <= b}");
        */

        bool a = false;
        bool b = true;

        kq = a || b;

        Console.WriteLine(kq);
    }
}