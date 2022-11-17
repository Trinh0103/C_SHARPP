using System;
using System.Linq;

namespace CS021
{
    /*
    Lambda - Anonymous function
    1)
    (tham_so) => bieu_thuc


    2)
    (tham_so) => {
        cac bieu_penh;
        return bieu_thuc_tra_ve;
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Action<string> thongbao;
            // thongbao = (string s) => Console.WriteLine(s); // ~ delegate void KIEU(string s) =Action<string>
            // thongbao?.Invoke("Xin chao");

            // Action thongbao;
            // thongbao = () => Console.WriteLine("Xin chao cac ban");
            // thongbao?.Invoke();

            // Action<string, string> welcome;
            // welcome = (string mgs, string name) => Console.WriteLine(mgs + " " + name);
            // welcome?.Invoke("Xin chao", "Trinh");

            // Action<string, string> welcome;
            // welcome = (mgs, name) =>
            // {
            //     Console.ForegroundColor = ConsoleColor.Yellow;
            //     Console.WriteLine(mgs + " " + name);
            //     Console.ResetColor();
            // }
            // welcome?.Invoke("Xin chao", "Trinh");

            // Func<int, int, int> tinhtoan;
            // tinhtoan = (a, b) =>
            // {
            //     int kq = a + b;
            //     return kq;
            // };
            // Console.WriteLine(tinhtoan.Invoke(5, 6));

            // (int a, int b) =>
            // {
            //     int kq = a + b;
            //     return kq;
            // }

            int[] mang = {3,4,5,7,44,7,6,4,8,3};
            // var kq = mang.Select(
            //     (int x) => {
            //         return Math.Sqrt(x);
            //     }

            // );

            // foreach (var result in kq)
            // {
            //     Console.WriteLine(result);
            // }

            // mang.ToList().ForEach(
            //     (int x) => {
            //         if (x % 2 != 0)
            //             Console.WriteLine(x);
            //     }
            // );

            var kq = mang.Where(
                (x) => {
                    return x % 4 == 0;
                }
            );

            foreach ( var n in kq)
            {
                Console.WriteLine(n);
            }
        }
    }
}