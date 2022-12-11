using System.Linq;

namespace CS030   
{   public class Product
    {
        public int ID {set; get;}
        public string Name {set; get;}         // ten
        public double Price {set; get;}        // gia
        public string[] Colors {set; get;}     // mau sac
        public int Brand {set; get;}           // ID nhan hieu, hang
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lay chuoi thong tin san pham gom ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name, 12} {Price, 5} {Brand, 2} {string.Join(",", Colors)}";
    }
    public class  Brand 
    {
        public string Name {set; get;}
        public int ID {set; get;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //LinQ : Ngon ngu truy van tich hop 
            //Nguon du lieu: Array, List, Stack, Queue, ...
            // Product p = new Product(1, "Iphone", 1000, new string[]{"Xanh","Do"}, 2);
            // System.Console.WriteLine(p.ToString());
            
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };
            var products = new List<Product>()
{
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            //Lay ra nhung sp co gia 400
            // var query = from p in products where p.Price == 400 select p;
            // foreach (var item in query)
            // {
            //     System.Console.WriteLine(item);
            // }
            // //Select
            // var kqS = products.Select(
            //     (p) =>{
            //         return p.Name;
            //     }
                
            // );
            // foreach (var item in kqS)
            // {
            //     System.Console.WriteLine(item);
            // }
            // //Where
            // // var kqW = products.Where(
            // //     (p) =>{
            // //         return p.Name.Contains("tr");
            // //     }
            // // );
            // var kqW = products.Where(
            //     (p) =>{
            //         return p.Price <= 300 && p.Price >= 200;
            //     }
            // );
            // foreach (var item in kqW)
            // {
            //     System.Console.WriteLine(item);
            // }
            // //SelectMany
            // var kqSM = products.SelectMany(
            //     (p) =>{
            //         return p.Colors;
            //     }
                
            // );
            // foreach (var item in kqSM)
            // {
            //     System.Console.WriteLine(item);
            // }


            //Min, Max, Sum, Average
            // int[] numbers = { 1, 3, 4, 5, 6, 7  ,8 ,9};
            // System.Console.WriteLine(numbers.Where(n => n % 2 == 0).Sum());
            // System.Console.WriteLine(products.Min(p => p.Price));
            //Join
            // var kqJ =  products.Join(brands, p => p.Brand, b => b.ID, (p,b) => {
            //     return new {
            //         Ten = p.Name,
            //         Thuonghieu = b.Name
            //     };
            // }); 
            
            //(nguon, nguon trong pro, nguon trong bran)
            // foreach (var item in kqJ)
            // {
            //     System.Console.WriteLine(item);
            // }
            //GroupJoin
            // var kqGJ =  brands.GroupJoin(products, b => b.ID, p => p.Brand, 
            //     (b,p) => {
            //         return new {
            //             Thuonghieu = b.Name,
            //             Cacsanpham = p
            //         };
            // }); 
            

            //(nguon, nguon trong pro, nguon trong bran)
            // foreach (var item in kqGJ)
            // {
            //     System.Console.WriteLine(item.Thuonghieu);
            //     foreach (var sp in item.Cacsanpham)
            //     {
            //         System.Console.WriteLine(sp);
            //     }
            // }


            // //Take - Lay n phan tu dau tien

            // products.Take(3).ToList().ForEach(p => System.Console.WriteLine(p));
            // //Skip - Bo qua n phan tu dau tien, lay cac phan tu con lai
            // products.Skip(3).ToList().ForEach(p => System.Console.WriteLine(p));
            // //OrderBy: SX tang dan
            // products.OrderBy(p => p.Price).ToList().ForEach(p => System.Console.WriteLine(p));
            // //OrderByDesscending: SX giam dan
            // products.OrderByDescending(p => p.Brand).ToList().ForEach(p => System.Console.WriteLine(p));
            // //Reverse:Dao nguoc thu tu
            // numbers.Reverse().ToList().ForEach(i => System.Console.WriteLine(i));
            // //GroupBy: Nhom
            // var GB = products.GroupBy(p => p.Brand);
            // foreach (var item in GB)
            // {
            //     System.Console.WriteLine(item.Key);
            //     foreach (var sp in item)
            //     {
            //         System.Console.WriteLine(sp);
            //     }
            // }
            // //Distinct - Loai bo cac gia tri trung
            // var kqD = products.SelectMany(p => p.Colors).Distinct();
            // foreach (var item in kqD)
            // {
            //     System.Console.WriteLine(item);
            // }
            // //Single - 1 phan tu thoa man dieu kien logic => tra ve phan tu do, >1 phan tu hoac khong tim thay => bao loi
            // var kqSg  = products.Single(p => p.Price == 600);
            // System.Console.WriteLine(kqSg);
            // //SingleOrDefault - 1 phan tu thoa man dieu kien logic => tra ve phan tu do, >1 phan tu => bao loi, khong tim thay => tra ve null
            // var kqSoD  = products.SingleOrDefault(p => p.Price == 1100);
            // System.Console.WriteLine(kqSoD);
            // //any -  TMDK logic => tra ve true
            // var kqAny = products.Any(p => p.Price == 400);
            // System.Console.WriteLine(kqAny);
            // //all - tat cac cac phan tu phai tmdk logic
            // var kqAll = products.All(p => p.Price > 400);
            // System.Console.WriteLine(kqAll);
            // //count - dem so luong
            // var kqC = products.Count(p => p.Price >= 300);
            // System.Console.WriteLine(kqC);
            //In ra ten sp, ten thuong hieu, co gia (300-400)
            products.Where(p => p.Price >= 300 && p.Price <= 400)
                    .OrderByDescending(p => p.Price)
                    .Join(brands, p => p.Brand, b => b.ID, (p,b) =>{
                        return new {
                            tenSP = p.Name,
                            tenTH = b.Name,
                            Gia = p.Price
                        };
                    })
                    .ToList()
                    .ForEach (info => {
                        System.Console.WriteLine($"{info.tenSP,15} - {info.tenTH} - {info.Gia,5}");
                    });
            //Cu phap truy van LINQ
            /*
                1. Xd nguon du lieu
                2. Truy van : select, where, ...
            */

            //Nhom sp theo gia
            // var qr = from p in products
            //          group p by p.Price into gr
            //          orderby gr.Key descending
            //          let sl = "SL : " + gr.Count()
            //          select new {
            //             Gia = gr.Key,
            //             Cacsp = gr.ToList(),
            //             Soluong = sl
            //          }; // lu bien tam
            //         //  where p.Price == 400
            //         //  select $"{p.Name} : {p.Price}";
            // qr.ToList().ForEach(gr => {
            //     System.Console.WriteLine(gr.Gia);
            //     System.Console.WriteLine(gr.Soluong);
            //     gr.Cacsp.ForEach(p => System.Console.WriteLine(p));
            // });
            var qr = from p in products
                     join b in brands on p.Brand equals b.ID into t
                     from bt in t.DefaultIfEmpty()
                     select new {
                        Ten = p.Name,
                        Gia = p.Price,
                        TH = (bt != null) ? bt.Name : "Khong co thuong hieu"
                     };
            qr.ToList().ForEach(sp => {
                System.Console.WriteLine($" {sp.Ten,10} : {sp.Gia,10} : {sp.TH,5} ");
            });

        }

    }
}