internal class Program
{
    private static void Main(string[] args)
    {
        //for
        for (int i = 8;i <=10;i++)
        {
            Console.WriteLine("So i = " + i);
        }

        //while
        int j = 8;
        while (j <= 10)
        {
            Console.WriteLine("So j = " + j);
            j++;
        }
        
        //do..while
        int a = 10;
        do
        {
            Console.WriteLine("So a = " + a);
            a += 2;
        }
        while (a <= 20);

        //continue
        for (int b = 10; b <= 20; b++)
        {
            if (b % 3 != 0)
                continue;
            Console.WriteLine("So b = " + b);
        }

    }
}