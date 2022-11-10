using System;

namespace CS014
{
    /*
        Tinh ke thua
        A, B
        A - co so, cha
        B - ke thua, com

        class B : A
        {

        }

        Animal
            - Legs
            - Weight
            - Showlegs()
        Cat Animal
    */

    /*class Animal
    {
        public Animal()
        {
            Console.WriteLine("Khoi tao Animal");
        }
        public Animal(string abc)
        {
            Console.WriteLine($"Khoi tao Animal (2) - {abc}");
        }
        public int Legs {set; get;}
        public float Weight {set; get;}

        public void Showlegs()
        {
            Console.WriteLine($"Legs: {Legs}");
        }
    }

    class Cat : Animal
    {
        public string Food;

        public Cat(string s) : base(s)
        {
            this.Legs = 4;
            this.Food = "Mouse";
            Console.WriteLine("Khoi tao Cat");
        }

        public void Eat()
        {
            Console.WriteLine(Food);
        }

        public new void Showlegs()
        {
            Console.WriteLine($"Loai meo co: {Legs} chan");
        }

        public void ShowInfo()
        {
            base.Showlegs();
            Showlegs();
        }
    }
    */

    class A {}

    class B : A {}

    class C : B {}
    class Program
    {
        static void Main(string[] args)
        {
            //Cat c = new Cat("Abc Zyz");
            //c.Showlegs();
            //c.Eat();
            //c.ShowInfo();
            A a;
            B b = new B();
            C c = new C();

            a = b;
            a = c;

            b = c;
            //c = b;  loi

           
        }
    }
}