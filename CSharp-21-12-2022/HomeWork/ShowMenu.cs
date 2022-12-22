using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork;
internal class ShowMenu
{
    public static void callMenu()
    {

        ICRUD quanLySinhVien = new();
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        while (true)
        {
            Console.WriteLine("\n--------------------MENU--------------------");
            Console.WriteLine("--    1. Thêm sinh viên.                  --");
            Console.WriteLine("--    2. Cập nhật thông tin sinh viên.    --");
            Console.WriteLine("--    3. Xóa sinh viên.                   --");
            Console.WriteLine("--    4. Tìm kiếm sinh viên theo tên.     --");
            Console.WriteLine("--    5. Sắp xếp sinh viên theo tên.      --");
            Console.WriteLine("--    6. Hiển Thị danh sách.              --");
            Console.WriteLine("--    7. Thoát chương trình               --");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Nhập Lựa Chọn: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine("\n1. Thêm sinh viên.");
                    quanLySinhVien.NhapSinhVien();
                    Console.WriteLine("\nThêm sinh viên thành công!");
                    break;
                case 2:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        int id;
                        Console.WriteLine("\n2. Cập nhật thông tin sinh viên. ");
                        Console.Write("\nNhập Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        quanLySinhVien.UpdateSinhVien(id);
                    }
                    else
                    {
                        Console.WriteLine("\nDanh sách sinh viên trống!");
                    }
                    break;
                case 3:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        int id;
                        Console.WriteLine("\n3. Xóa sinh viên.");
                        Console.Write("\nNhập ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (quanLySinhVien.DeleteById(id))
                        {
                            Console.WriteLine("\nSinh viên có Id = {0} đã xóa.", id);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nDanh sách sinh viên trống!");
                    }
                    break;
                case 4:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n4. Tìm kiếm sinh viên theo tên.");
                        Console.Write("\nNhập tên để tìm kiếm: ");
                        string name = Console.ReadLine();
                        List<SinhVien> searchResult = quanLySinhVien.FindByName(name);
                        quanLySinhVien.ShowSinhVien(searchResult);
                    }
                    else
                    {
                        Console.WriteLine("\nDanh sách sinh viên trống!");
                    }
                    break;

                case 5:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n5. Sắp xếp sinh viên theo tên.");
                        quanLySinhVien.SortByName();
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getList());
                    }
                    else
                    {
                        Console.WriteLine("\nDanh sách sinh viên trống!");
                    }
                    break;
                case 6:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n6. Hiển thị danh sách sinh viên.");
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getList());
                    }
                    else
                    {
                        Console.WriteLine("\nDanh sách sinh viên trống!");
                    }
                    break;
                case 7:
                    Console.WriteLine("\nThoát chương trình!");
                    return;
                default:
                    Console.WriteLine("\nVui lòng lựa chọn theo menu!");
                    break;
            }
        }
    }
}
