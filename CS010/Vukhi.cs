using System;

namespace CS010
{
    /*
        <Access Modifiers> class class_Name{
            // khai bao cac thanh vien du lieu(thuoc tionh, bien truong)
            //khai bao cac thanh vien ham(phuong thuc)
        }
    */

    internal class Vukhi
    {
        //DU LIEU
        public string name = "Ten vu khi";
        int dosatthuong = 0;

        //THUOc TINH

        public string Noisanxuat {set; get;}

        public int Satthuong
        {
            // =
            set
            {
                //cac lenh
                dosatthuong = value;
            }
            //Truy cap
            get
            {
                return dosatthuong;
            }
        }


        //phuong thuc khoi tao
        public Vukhi()
        {
            //Console.WriteLine("Khoi tao");
            dosatthuong = 1;
        }
        public Vukhi(string name, int _dosatthuong)
        {            
            dosatthuong = _dosatthuong;
            this.name = name;
        }
        //public Vukhi(string abc)
        //{
            //Console.WriteLine(abc);
        //}

        //PHUONG THUC
        public void Thietlapdosatthuong(int dosatthuong)
        {
            this.dosatthuong = dosatthuong;

            //this - ref
            //Vukhi abc;
            //abc = this;
        }

        public void Tancong()
        {
            Console.Write(name + ":\t");
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();

        }

    }
}