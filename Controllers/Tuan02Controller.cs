using Microsoft.AspNetCore.Mvc;

namespace demo_lop1.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            var HoTen = "Trần Hoài Nghĩa";
            var MSSV = "1721031589";
            var Nam = "2003";
            ViewBag.HoTen = HoTen;
            ViewBag.MSSV = MSSV;
            ViewBag.Nam = Nam;

            ViewBag.Thang = "tháng 12";

            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult AboutOK(List <string> catagories)
        {
            var content = "Category List:";
            foreach (var catagory in catagories)
            {
                content = content + catagory;
            }
            return Content(content);
        }



        public IActionResult MayTinh(double a, double b, string pheptinh)
        {
            double ketqua = 0;

            switch (pheptinh)
            {
                case "cong":
                    ketqua = a + b;
                    break;
                case "tru":
                    ketqua = a - b;
                    break;
                case "nhan":
                    ketqua = a * b;
                    break;
                case "chia":
                    // Kiểm tra nếu b khác 0 để tránh lỗi chia cho 0
                    if (b != 0)
                    {
                        ketqua = a / b;
                    }
                    else
                    {
                        // Xử lý lỗi khi chia cho 0
                        ViewBag.Error = "Lỗi: Số b phải khác 0";
                    }
                    break;
                default:
                    // Xử lý lỗi khi giá trị pheptinh không hợp lệ
                    ViewBag.Error = "Lỗi: Phép tính không hợp lệ";
                    break;
            }

            ViewBag.KetQua = ketqua;
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}
