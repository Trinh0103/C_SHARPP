using static System.Console;
using static System.Math;
using System;
using Mynamespace;
using Xyz = Mynamespace.Abc;

namespace CS015
{
        
    
    class Program
    {
        static void Main(string[] args)
        {
            //Class1.XinChao();
            //Xyz.Class1.XinChao();
            //WriteLine("Xin chao");
            //WriteLine(PI);
            //WriteLine(Sin(PI/4));
            Sanpham.Product product =  new Sanpham.Product();
            product.name =  "Ipad";
            product.price = 1000;
            product.description = "Day la Ipad";
            product.manufactory = new Sanpham.Product.Manufactory();
            product.manufactory.name = "Apple";

            WriteLine(product.GetInfo());
        }
    }
}