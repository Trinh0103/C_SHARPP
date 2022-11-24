using System;
using System.Collections.Generic;

namespace CS026
{   
    class Product
    {
        public string name {set; get;}
        public double price {set; get;}
        public int id {set; get;}

        public string origin {set; get;}

        public void Info() => System.Console.WriteLine($"{name}, {price}, {id}, {origin}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> danhsach1 = new List<int>();
            List<string> ds2 = new List<string>();
            danhsach1.Add(1);
            danhsach1.Add(3);
            danhsach1.AddRange(new int[] {2,4,6});
            //Dem so luong phan tu
            System.Console.WriteLine(danhsach1.Count);
            //Chen
            danhsach1.Insert(0,4);
            
            //Xoa gia tri - remove(gia tri)
            //xoa chi so - removeat(index)
            danhsach1.Remove(6);
            //Tim kiem - find() - tra ve gia tri dau tien tim thay
            var n = danhsach1.FindAll(
                (e) => {
                    return e % 2 == 0;
                }
            );
            foreach (var item in n)
            {
                System.Console.WriteLine(item);
            }
            foreach (var item in danhsach1)
            {
                System.Console.WriteLine(item);
            }
            ///
            List<Product> proList = new List<Product>(){
                new Product(){
                    name = "IP X", price = 1000, origin = "CN", id = 1
                },
                new Product(){
                    name = "SamSung", price = 800, origin = "CN", id = 2
                },
                new Product(){
                    name = "Realme", price = 500, origin = "US", id = 3
                },
                new Product(){
                    name = "Xiaomi", price = 500, origin = "JP", id = 4
                },
            };
            foreach (var item in proList)
            {
                item.Info();
            }
            var p = proList.FindAll(
                (p) => {
                   return p.price >= 600;
                } 
            );
            // if (p != null)
            // {
            //     p.Info();
            // }
            foreach (var item in p)
            {
                item.Info();
            }
            //Sap xep Sort
            proList.Sort(
                (p1,p2) => {
                    if (p1.price == p2.price) return 0;
                    if (p1.price < p2.price) return 1;
                    return -1;
                }
            );
            System.Console.WriteLine("_________________________");
            foreach (var item in proList)
            {
                item.Info();
            }
            //SortedList<[key],[bien]>
            SortedList<string, Product> products = new SortedList<string, Product>();
            products["san pham 1"] = new Product(){ name = "IP", price = 1000, origin = "CN"};
            products["san pham 2"] = new Product(){ name = "SS", price = 700, origin = "JP"};
            products.Add("san pham 3", new Product(){ name = "Realme", price = 800, origin = "US"});
            

            var i = products["san pham 2"];
            i.Info();
            //duyet sortlisted
            var keys = products.Keys;
            var values = products.Values;
            foreach (var k in keys)
            {
                var pro = products[k];
                pro.Info();
            }
            //duyet sortlisted
            foreach (KeyValuePair<string, Product> item in products)
            {   
                var key = item.Key;
                var val = item.Value;
                System.Console.WriteLine($"{key} - {val.name}");
            }
            //remove
        }
    }
}