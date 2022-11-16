using System;

namespace CS019
{   
    interface IHinhhoc
    {
        public double tinhChuVi(); // Chi can khai bao ten
        public double tinhDienTich();
    }
    //Trien khai giao dien
    class HCN : IHinhhoc
    {
        public double a;
        public double b;

        public HCN(double _a, double _b)
        {
            a = _a;
            b = _b;
        }
        public double tinhChuVi()
        {
            return (a+b)*2;
        }

        public double tinhDienTich()
        {
            return a*b;
        }
    }
    class HinhTron : IHinhhoc
    {           
        public double r;

        public HinhTron(double _r)
        {
            r = _r;
        }

        public double tinhChuVi()
        {
            return Math.PI * r * 2;
        }

        public double tinhDienTich()
        {
            return Math.PI*r*r;
        }
    }
    class Program
    {   
        abstract class Product
        {
            protected double price {get; set;}

            public abstract void ProductInfo();

            public void Test()
            {
                ProductInfo();
            }
            
        }

        class Iphone : Product
        {
            public Iphone()
            {
                price = 1000;
            }

            //override - ghi de 1 phuong thuc o lop cha - NAP CHONG PHUONG THUC
            public override void ProductInfo()
            {
                System.Console.WriteLine($"Dien thoai iphone, gia : {price}");
                // base.ProductInfo(); => Khong goi duoc
            }
        }
        static void Main(string[] args)
        {
            // Product p = new Product(); // Khong duoc khoi tao doi tuong
            Iphone ip = new Iphone();
            ip.Test();
            HCN hcn1 = new HCN(5.2,3.5);
            Console.WriteLine($"Chu vi hinh chu nhat: {hcn1.tinhChuVi()}");
            Console.WriteLine($"Dien tich hinh chu nhat: {hcn1.tinhDienTich()}");
            HinhTron ht1 = new HinhTron(2.5);
            Console.WriteLine($"Chu vi hinh tron: {ht1.tinhChuVi()}");
            Console.WriteLine($"Dien tich hinh tron: {ht1.tinhDienTich()}");
        }
    }
}