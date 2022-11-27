using System;

namespace CS027
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cacHS = new Queue<string>();
            
            //Dua vao hang doi
            cacHS.Enqueue("Ho so 1");
            cacHS.Enqueue("Ho so 2");
            cacHS.Enqueue("Ho so 3");
            System.Console.WriteLine($"So hs con lai : {cacHS.Count}");
            
            //Loai bo phan tu dau tien, tra ve gia tri phan tu
            var hs = cacHS.Dequeue();
            System.Console.WriteLine(hs);
            System.Console.WriteLine($"So hs con lai : {cacHS.Count}");
            System.Console.WriteLine("----------------");
            
            //duyet hang doi
            foreach (var item in cacHS)
            {
                System.Console.WriteLine(item);
            }
            Stack<string> danhsachSP = new Stack<string>();
            danhsachSP.Push("Sp1");
            danhsachSP.Push("Sp2");
            danhsachSP.Push("Sp3");
            System.Console.WriteLine(danhsachSP.Count);
            
            //Xoa phan tu o dinh stack, tra ve gia tri phan tu
            var sp = danhsachSP.Pop();
            System.Console.WriteLine(sp);
            System.Console.WriteLine(danhsachSP.Count);
            System.Console.WriteLine("------------------");
            foreach (var item in danhsachSP)
            {
                System.Console.WriteLine(item);
            }
            LinkedList<string> dsBaiHoc = new LinkedList<string>();

            var bh1 = dsBaiHoc.AddFirst("bai 1");
            var bh2 = dsBaiHoc.AddLast("bai 3");
            var bh3 = dsBaiHoc.AddAfter(bh1,"bai 2");
            foreach (var item in dsBaiHoc)
            {
                System.Console.WriteLine(item);
            }
            var node = bh1;
            System.Console.WriteLine(node.Value);
            node = node.Next;
            System.Console.WriteLine(node.Value);
            node = node.Previous;
            System.Console.WriteLine(node.Value);

            Dictionary<string, int> sodem = new Dictionary<string, int>(){
                ["one"] = 1,
                ["two"] = 2,
            };
            sodem["three"] = 3;
            var keys = sodem.Keys;
            foreach (var item in keys)
            {
                System.Console.WriteLine(item);
            }
            foreach (KeyValuePair<string,int> item in sodem)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }


            HashSet<int> songuyen = new HashSet<int>(){
                1, 2, 3, 5, 7
            };
            HashSet<int> songuyen2 = new HashSet<int>(){
                2, 4 ,6, 7, 10
            };

            songuyen.Add(9);
            songuyen2.Remove(7);
            
            //phep hop
            songuyen.UnionWith(songuyen2);
            foreach (var item in songuyen)
            {
                System.Console.WriteLine(item);
            }   
            
            //phep giao
            songuyen.IntersectWith(songuyen2);
            foreach (var item in songuyen)
            {
                System.Console.WriteLine(item);
            }  
        }
    }
}