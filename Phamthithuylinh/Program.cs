using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Phamthithuylinh
{
    //    class Todo
    //    {
    //        public string Ten { get; set; }
    //        public int DoUuTien { get; set; }
    //        public string MoTa { get; set; }
    //        public int TrangThai { get; set; } 

    //        public Todo(string ten, int doUuTien, string moTa, int trangThai)
    //        {
    //            Ten = ten;
    //            DoUuTien = doUuTien;
    //            MoTa = moTa;
    //            TrangThai = trangThai;
    //        }

    //        public void HienThiThongTin()
    //        {
    //            Console.WriteLine($"Ten: {Ten}, Uu tien: {DoUuTien}, Mo ta: {MoTa}, Trang thai: {TrangThaiText()}");
    //        }

    //        public string TrangThaiText()
    //        {
    //            if (TrangThai == 0)
    //            {
    //                return "Huy";
    //            }
    //            else if (TrangThai == 1)
    //            {
    //                return "Hoan thanh";
    //            }
    //            else if (TrangThai == 2)
    //            {
    //                return "Cho";
    //            }
    //            else
    //            {
    //                return "Khong xac dinh";
    //            }
    //        }
    //    }

    //    class Program
    //    {
    //        static List<Todo> danhSachTodo = new List<Todo>();

    //        static void Main(string[] args)
    //        {
    //            bool tiepTuc = true;

    //            while (tiepTuc)
    //            {
    //                Console.WriteLine("\nChon chuc nang:");
    //                Console.WriteLine("1. Them viec can lam");
    //                Console.WriteLine("2. Xoa viec can lam");
    //                Console.WriteLine("3. Cap nhat trang thai");
    //                Console.WriteLine("4. Tim kiem viec can lam");
    //                Console.WriteLine("5. Hien thi danh sach theo do uu tien");
    //                Console.WriteLine("6. Hien thi toan bo danh sach");
    //                Console.WriteLine("Nhan phim q de thoat.");

    //                string luaChon = Console.ReadLine();

    //                switch (luaChon)
    //                {
    //                    case "1":
    //                        ThemTodo();
    //                        break;
    //                    case "2":
    //                        XoaTodo();
    //                        break;
    //                    case "3":
    //                        CapNhatTrangThai();
    //                        break;
    //                    case "4":
    //                        TimKiemTodo();
    //                        break;
    //                    case "5":
    //                        HienThiTheoUuTien();
    //                        break;
    //                    case "6":
    //                        HienThiToanBo();
    //                        break;
    //                    case "q":
    //                        tiepTuc = false;
    //                        break;
    //                    default:
    //                        Console.WriteLine("Lua chon khong hop le.");
    //                        break;
    //                }
    //            }
    //        }

    //        static void ThemTodo()
    //        {
    //            Console.Write("Nhap ten viec can lam: ");
    //            string ten = Console.ReadLine();
    //            if (string.IsNullOrEmpty(ten))
    //            {
    //                Console.WriteLine("Ten viec khong duoc de trong.");
    //                return;
    //            }
    //            int doUuTien;
    //            do
    //            {
    //                Console.Write("Nhap do uu tien (1-5) voi 1 la it uu tien nhat: ");
    //            } while (!int.TryParse(Console.ReadLine(), out doUuTien) || doUuTien < 1 || doUuTien > 5);
    //            Console.Write("Nhap mo ta: ");
    //            string moTa = Console.ReadLine();

    //            int trangThai;
    //            do
    //            {
    //                Console.Write("Nhap trang thai (0 - Huy, 1 - Hoan thanh, 2 - Cho): ");
    //            } while (!int.TryParse(Console.ReadLine(), out trangThai) || trangThai < 0 || trangThai > 2);

    //            danhSachTodo.Add(new Todo(ten, doUuTien, moTa, trangThai));
    //            Console.WriteLine("Da them viec can lam.");
    //        }

    //        static void XoaTodo()
    //        {
    //            Console.Write("Nhap vi tri can xoa: ");
    //            int viTri = int.Parse(Console.ReadLine());

    //            if (viTri >= 0 && viTri < danhSachTodo.Count)
    //            {
    //                danhSachTodo.RemoveAt(viTri);
    //                Console.WriteLine("Da xoa.");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Vi tri khong hop le.");
    //            }
    //        }

    //        static void CapNhatTrangThai()
    //        {
    //            Console.Write("Nhap vi tri can cap nhat: ");
    //            int viTri = int.Parse(Console.ReadLine());

    //            if (viTri >= 0 && viTri < danhSachTodo.Count)
    //            {
    //                Console.Write("Nhap trang thai moi (0 - Huy, 1 - Hoan thanh, 2 - Cho): ");
    //                int trangThai = int.Parse(Console.ReadLine());

    //                danhSachTodo[viTri].TrangThai = trangThai;
    //                Console.WriteLine("Da cap nhat trang thai.");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Vi tri khong hop le.");
    //            }
    //        }

    //        static void TimKiemTodo()
    //        {
    //            Console.Write("Nhap ten viec can tim: ");
    //            string ten = Console.ReadLine();

    //            var ketQua = danhSachTodo.Where(t => t.Ten.Contains(ten)).ToList();
    //            if (ketQua.Count > 0)
    //            {
    //                Console.WriteLine("Ket qua tim kiem:");
    //                ketQua.ForEach(t => t.HienThiThongTin());
    //            }
    //            else
    //            {
    //                Console.WriteLine("Khong tim thay viec can lam.");
    //            }
    //        }

    //        static void HienThiTheoUuTien()
    //        {
    //            var sapXepUuTien = danhSachTodo.OrderByDescending(t => t.DoUuTien).ToList();
    //            sapXepUuTien.ForEach(t => t.HienThiThongTin());
    //        }

    //        static void HienThiToanBo()
    //        {
    //            Console.WriteLine("Danh sach viec can lam:");
    //            danhSachTodo.ForEach(t => t.HienThiThongTin());
    //        }
    //    }
}