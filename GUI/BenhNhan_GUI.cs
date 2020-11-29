using System;
using System.Collections;
using System.Text;
using QuanLyBenhNhanDenKham.BLL;
using QuanLyBenhNhanDenKham.DAL;

namespace QuanLyBenhNhanDenKham.GUI
{
    class BenhNhan_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("|             QUẢN LÍ BỆNH NHÂN                    |");
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine("|1. Nhập thêm bệnh nhân                            |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|2. Hiện thị danh sách bệnh nhân                   |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|3. Sửa thông tin bệnh nhân                        |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|4. Xóa thông tin bệnh nhân                        |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|5. Tìm kiếm bệnh nhân                             |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|0.Thoát                                           |");
            Console.WriteLine("|__________________________________________________|");
        }
        static BenhNhan_DAL BenhNhan_DAL = new BenhNhan_DAL();
        static BenhNhan_BLL BenhNhan_BLL = new BenhNhan_BLL();
        static ArrayList arrayList = new ArrayList();

        public static void Run()
        {
            BenhNhan_DAL.DocFile(arrayList);
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
                        BenhNhan_BLL.Nhap(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        BenhNhan_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        BenhNhan_BLL.Hien(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        BenhNhan_BLL.Sua(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        BenhNhan_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        BenhNhan_BLL.Xoa(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        BenhNhan_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        BenhNhan_BLL.TimKiem(arrayList);
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