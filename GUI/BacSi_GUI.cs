using System;
using System.Collections;
using System.Text;
using QuanLyBenhNhanDenKham.BLL;
using QuanLyBenhNhanDenKham.DAL;

namespace QuanLyBenhNhanDenKham.GUI
{
    class BacSi_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("|             QUẢN LÍ BÁC SĨ                       |");
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine("|1. Nhập thêm bác sĩ                               |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|2. Hiện thị danh sách bác sĩ                      |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|3. Sửa thông tin bác sĩ                           |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|4. Xóa thông tin bác sĩ                           |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|5. Tìm kiếm bác sĩ                                |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|0.Thoát                                           |");
            Console.WriteLine("|__________________________________________________|");
        }
        static BacSi_DAL BacSi_DAL = new BacSi_DAL();
        static BacSi_BLL BacSi_BLL = new BacSi_BLL();
        static ArrayList arrayList = new ArrayList();

        public static void Run()
        {
            BacSi_DAL.DocFile(arrayList);
            int chon;
            while (true)
            {
                Menu();
                //chọn chức  năng
                chon = int.Parse(Console.ReadLine());
                //nếu nhập = 0 thì dừng chương trình
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        BacSi_BLL.Nhap(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        BacSi_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        BacSi_BLL.Hien(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        BacSi_BLL.Sua(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        BacSi_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        BacSi_BLL.Xoa(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        BacSi_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        BacSi_BLL.TimKiem(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}
