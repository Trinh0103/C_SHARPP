using System;

namespace CS022
{   /*
    publisher -> class - phat su kien
    subscriber -> class - nhan su kien
    */
    public delegate void SuKienNhapSo(int x);
    
    class Dulieu : EventArgs
    {
        public int data {get;set;}

        public Dulieu (int x) => data = x;
    }
    // publisher
    class userInput
    {
    // {   public event SuKienNhapSo sknhapso; // Co event => TU thuoc tinh tro thanh truong DL
    //delegate chuyen dung cho su kien
        public event EventHandler sknhapso; //delegate void Function(object? sender, EventaArgs args)
        public void Input()
        {   System.Console.WriteLine("Nhap so : ");
            string s = Console.ReadLine();
            int i = Int32.Parse(s);
            sknhapso?.Invoke(this, new Dulieu(i));
        }
    }

    //subscriber

    class TinhCan
    {   //DK sK
        public void Sub(userInput input)
        {
            input.sknhapso += Can; //Khong duoc dung phep dan, chi duoc dung +=/-=
        }
        public void Can(object? sender,EventArgs args)
        {   Dulieu dl = (Dulieu)args;
            int i = dl.data;
            System.Console.WriteLine($"Can bac 2 cua {i} la : {Math.Sqrt(i)}");
        }
    }

    class BinhPhuong
    {   //DK sK
        public void Sub(userInput input)
        {
            input.sknhapso += TinhBinhPhuong;
        }
        public void TinhBinhPhuong(object? sender,EventArgs args)
        {   Dulieu dl = (Dulieu)args;
            int i = dl.data;
            System.Console.WriteLine($"Binh phuong cua {i} la : {i*i}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            userInput us = new userInput();
            // us.Input();

            us.sknhapso += (sender, args) =>
            {   Dulieu dl = (Dulieu)args;

                System.Console.WriteLine($"Ban vua nhap so {dl.data}");
            };
            TinhCan tinhCan = new TinhCan();
            //Dang ki nhan su kien input
            tinhCan.Sub(us);

            BinhPhuong bp = new BinhPhuong();
            //Dang ki nhan su kien input cua lop binh phuong, huy dk sk cua lop tinhcan
            bp.Sub(us);


            us.Input();
        }
    }
}
