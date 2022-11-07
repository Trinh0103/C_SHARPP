using System;

namespace CS011
{
    class Program
    {
        static void Main(string[] args)
        {
            //string loichao; //null
            //string name = "Trinh";
            //loichao = "Xin chao";

            //string thongbao= loichao + " " + ten;
            //thongbao += "!";
            //Console.WriteLine(thongbao);

            //tring thongbao;
            //thongbao = "Hoc ve chuoi ky tu String";// \"    \\  \t  \n  \r
            //thongbao = @"Xin chao ""2022""
            
            //hoc lap trinh c#
            //";
            //int year = 2002;
            //string gioitinh = "Nam";
            //thongbao =
            //$"Xin chao {year, -10}, nam sau la nam {year + 1}";
            //thongbao = 
            //$@"
            //Ho ten: {name, 10}
            //nam sinh: {year, 10}
            //Gioi tinh: {gioitinh, 10}
            //";
            //Console.WriteLine(thongbao);

            //string thongbao = "Trinh, xin chao ca ban!";

            //int dodai = thongbao.Length;
            //char c = thongbao[4];

            // cat bo nhung ky tu
            //thongbao = thongbao.Trim()
            //Console.WriteLine(thongbao);
            //Console.WriteLine(dodai);
            //Console.WriteLine(c);

            //in tung ky tu
            //for ( int i = 0; i < dodai; i++)
            //{
            //   char c = thongbao[i];
            //   Console.WriteLine($"Chi sao {i} la ky tu: {c, 3}");
            //}
            //foreach (var kytu in thongbao)
            //{
            //    Console.WriteLine(kytu);
            //}
            
            // in thuong ky tu
            //Console.WriteLine(thongbao.ToLower());

            //thay the ky tu
            //thongbao = thongbao.Replace("xin chao", "chao mung");
            
            //chen ky tu
            //thongbao = thongbao.Insert(5, " 2022");
            
            // lay bao nhieu ky tu
            //thongbao = thongbao.Substring(7,3);

            //xoa ky tu
            //thongbao = thongbao.Remove(5,6);

            //chia cac ky tu con
            //string[] cacchuoicon = thongbao.Split(' ');
            //foreach (var s in cacchuoicon)
            //{
            //    Console.WriteLine(s);
            //}

            //noi cac chuoi con
            //string[] cacchuoicon = {
            //    "Hoc",
            //    "Lap",
            //    "Trinh",
            //   "C#"
            //};
            //thongbao = string.Join(' ', cacchuoicon);

            string  thognbao1;
            thognbao1 = "Xin";
            thognbao1 +=" chao cac ban";
            thognbao1 = thognbao1.Replace("Xin chao", "Chao mung");

            //StringBuilder thongbao  = new StringBuilder();
            //thongbao.Append("Xin");
            //thongbao.Append(" chao cac ban");
            //thongbao.Replace("Xin chao", "Chao mung");

            //string kq = thongbao.ToString();

            Console.WriteLine(thognbao1);


        }
    }
}