using System;
using System.IO;
using System.Text;

namespace CS028
{

    // static void ListFileDirectory(string path)
    // {
    //     String[] directories = System.IO.Directory.GetDirectories(path);
    //     String[] files = System.IO.Directory.GetFiles(path);
    //     foreach (var file in files)
    //     {
    //         Console.WriteLine(file);
    //     }
    //     foreach (var directory in directories)
    //     {
    //         Console.WriteLine(directory);
    //         ListFileDirectory(directory); // Đệ quy
    //     }
    // }
    class Product
    {
        public  int ID {set; get;}
        public double  Price  {set; get;}

        public string  Name {set; get;}

        public void  Save(Stream stream){
            // int  4 byte
            var byte_id = BitConverter.GetBytes(ID);
            stream.Write(byte_id, 0 , 4);
            // double  8 byte
            var byte_Price = BitConverter.GetBytes(Price);
            stream.Write(byte_Price, 0 , 8);


            var byte_Name = Encoding.UTF8.GetBytes(Name);
            var byte_leng = BitConverter.GetBytes(byte_Name.Length);
            stream.Write(byte_leng,0,4);
            stream.Write(byte_Name, 0, byte_Name.Length);
        }

        public void Restore(Stream  stream)
        {
            var byte_id = new byte[4];
            stream.Read(byte_id, 0, 4);
            ID = BitConverter.ToInt32(byte_id,0); 

            var byte_Price = new byte[8];
            stream.Read(byte_Price, 0 , 8);
            Price = BitConverter.ToDouble(byte_Price,0);

            var byte_leng = new byte[4];
            stream.Read(byte_leng, 0, 4);
            int Leng = BitConverter.ToInt32(byte_leng,0);
            var byte_Name = new byte[Leng];
            stream.Read(byte_Name, 0, Leng);
            Name = Encoding.UTF8.GetString(byte_Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // DriveInfo[] allDrives = DriveInfo.GetDrives();

            // foreach (DriveInfo d in allDrives)
            // {
            //     Console.WriteLine("Drive {0}", d.Name);
            //     Console.WriteLine("  Drive type: {0}", d.DriveType);
            //     if (d.IsReady == true)
            //     {
            //         Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
            //         Console.WriteLine("  File system: {0}", d.DriveFormat);
            //         Console.WriteLine(
            //             "  Available space to current user:{0, 15} bytes",
            //             d.AvailableFreeSpace);

            //         Console.WriteLine(
            //             "  Total available space:          {0, 15} bytes",
            //             d.TotalFreeSpace);

            //         Console.WriteLine(
            //             "  Total size of drive:            {0, 15} bytes ",
            //             d.TotalSize);
            //     }
            // }
            // DriveInfo dr = new DriveInfo("C:/");
            // System.Console.WriteLine($"{dr.Name}");
            // Directory
            // string path = "ABC";

            // //Exists(path) - kiem tra file co ton tai hay k
            // if (Directory.Exists(path))
            // {
            //     System.Console.WriteLine("Ton tai");
            // }
            // else
            // {
            //     System.Console.WriteLine("Khong ton tai");
            // }
            // CreateDirectory(path)
            // Directory.CreateDirectory(path);
            // //Delete(path)
            // Directory.Delete(path);
            
            // GetFiles - lay tat ca file trong thu muc
            // var files = Directory.GetFiles(path);
            // foreach (var item in files)
            // {
            //     System.Console.WriteLine(item);
            // }
            //GetDirectories - Lay tat ca cac thu muc trong thu muc
            //Move(thu muc nguon, thu muc dich)
            
            //path
            //File
            string fileName = "data.txt";
            // string content = "Xin chao cac ban";
            
            // Ghi vao file
            // File.WriteAllText(fileName,content);
            
            // Ghi vao file, luu noi dung cu
            // File.AppendAllText(fileName,content);
            
            // Doc file
            // string inFile = File.ReadAllText(fileName);
            // System.Console.WriteLine(inFile);
            
            // Doi ten file
            // File.Move(fileName,"InputRename.txt");
            
            // Copy
            // File.Copy(fileName,"Copyy.txt");
            
            // //Xoa file
            // File.Delete("Copyy.txt");
            
            //Lop Stream
            // using var fs = new FileStream(path: fileName, FileMode.Create);
            
            //Luu du lieu
            // byte[] buffer = {1,2,3};
            // int offset = 0;
            // int count = 3;
            // fs.Write(buffer, offset, count);
            
            // Doc du lieu
            // fs.Read(buffer, offset, count);
            //int, double -> byte
            // int songuyen = 1;
            // var byteSonguyen = BitConverter.GetBytes(songuyen);
            // var intToByte = BitConverter.ToInt32(byteSonguyen, 0);
            // string s = "Xin chao";
            // var byteString  =  Encoding.UTF8.GetBytes(s);
            // Encoding.UTF8.GetString(byteString, 0, 10);
            Product p1 = new Product(){
                // ID = 10,
                // Price = 1000,
                // Name = "Ip"
            };

            // p1.Save(fs);
            using var fs1 = new FileStream(path: fileName, FileMode.Open);
            p1.Restore(fs1);
            System.Console.WriteLine($"{p1.ID} : {p1.Name} : {p1.Price}");
        }
    }
}