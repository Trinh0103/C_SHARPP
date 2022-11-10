using System;

namespace Mynamespace
{   //class, struct, enum, interface... namespace
    public class Class1
    {
        public static void XinChao()
        {
            Console.WriteLine("Xin chao tu Class1");
        }
    }
    namespace Abc
    {
        public class Class1
        {
            public static void XinChao()
            {
                Console.WriteLine("Xin chao tu Class1 / Abc");
            }
        }
    }
}