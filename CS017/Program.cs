using System;
using System.Collections.Generic;
using System.Linq;
namespace CS017
{
    
    class Program
    {
        // Anonymous - kieu du lieu vo danh
        // Object - thioc tinh - chi doc
        // new {thuoc tinh =  giatri, thuoctinh2 = giatri2}
        // dynamic - kieu du lien dong
        
        /*class Sinhvien 
        {
            public string HoTen {set; get;}
            public int Namsinh {set; get;}
            public string Noisinh {set; get;}
        }
        static void Main(string[] args)
        {
            //var sanpham = new {
            //    Ten = "Iphone 8",
            //    Gia = 1000,
            //    NamSx = 2018
            //};

            //Console.WriteLine(sanpham.Ten);
            //Console.WriteLine(sanpham.Gia);

            List<Sinhvien> cacsinhvien = new List<Sinhvien>(){
                new Sinhvien() {HoTen = "Trinh", Namsinh = 2002, Noisinh = "Quang Nam"},
                new Sinhvien() {HoTen = "Khang", Namsinh = 2002, Noisinh = "Gia Lai"},
                new Sinhvien() {HoTen = "San", Namsinh = 2002, Noisinh = "Quang Tri"},     
            };

            var ketqua = from sv in cacsinhvien
                        //where = sv.Noisinh == "Quang Nam"
                        //where = sv.HoTen.Contains("a")
                        where sv.Namsinh <= 2003
                        select new {
                            Ten = sv.HoTen,
                            NS = sv.Noisinh
                        };
            foreach (var sinhvien in ketqua)
            {
                Console.WriteLine(sinhvien.Ten + " - " + sinhvien.NS);
                
            }            
        }*/

        class Student
        {
            public string Name {set; get;}
            public void Hello() => Console.WriteLine(Name);
        }


        static void PrintInfo(dynamic obj)
        {
            obj.Name = "Tao la Trinh";
            obj.Hello();
        }

        static void Main(string[] args)
        {
            //Student abc = new Student();
            //PrintInfo(abc);
            dynamic tenbien;
             tenbien = new {};

             tenbien.Acdef = "hihi";
             tenbien.Hello();
        }
    }
}