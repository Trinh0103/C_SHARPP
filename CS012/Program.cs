using System;

namespace CS012
{    
    class Program
    {
        //struct
        /*public class Product
        {
            //du lieu
            public string name;
            public double price;
            public string Info
            {
                get {
                    return $"{name}, {price}";
                }
            }
            
            
            
            //phuong thuc

            public string GetInfo()
            {
                return $"Ten san pham: {name}, gia: {price}";
            }
            //constructor
            public Product(string _name, double _price)
            {
                name = _name;
                this.price = _price;
            }
        }
        static void Main(string[] args)
        {
            Product sanpham1 = new Product("", 0);
            sanpham1.name = "Iphone";
            sanpham1.price = 1000;

            Product sanpham2 = new Product("Nokia", 900);

            sanpham2 = sanpham1;
            sanpham2.name = "Iphone X";

            Console.WriteLine(sanpham1.GetInfo());
            Console.WriteLine(sanpham2.GetInfo());
            Console.WriteLine(sanpham2.Info);
        }*/

        //kieu liet ke enum
        /*
            0 - kem
            1 - trungbinh
            2 - kha
            3 - gioi

        */
        enum HOCLUC {
            Kem = 10,            //0
            Trungbinh = 123,      //1
            Kha = 333,            //2
            Gioi = 223            //3
        }
        


        static void Main(string[] args)
        {   

            Console.BackgroundColor = ConsoleColor.Blue;
            //FileAccess
            //FileAttribute
            //FileMode
            //DateFormat
            //DateTimeKind


            hocluc = HOCLUC.Gioi;

            //int so = (int)hocluc;
            //Console.WriteLine(so);

            hocluc = (HOCLUC)(333);

            switch (hocluc)
            {
                case HOCLUC.Kem:
                    Console.WriteLine("Hoc luc kem");
                break;
                case HOCLUC.Trungbinh:
                    Console.WriteLine("Hoc luc trung binh");
                break;
                case HOCLUC.Kha:
                    Console.WriteLine("Hoc luc kha");
                break;
                case HOCLUC.Gioi:
                    Console.WriteLine("Hoc luc gioi");
                break;
            }

        }
    }
}
