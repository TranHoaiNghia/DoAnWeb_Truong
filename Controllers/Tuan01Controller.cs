using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace demo_lop1.Controllers
{
    public class Tuan01Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Trần Hoài Nghĩa";
            ViewBag.MSSV = "1721031589";
            ViewBag.Nam = "2003";
            ViewData["Hello"] = "Hello";
            
            return View();
        }

        public IActionResult GioiThieu()
        {
            return View();
        }

        public IActionResult MayTinh1(double a, double b, string pheptinh)
        {
            double? ketqua = null;
            string error = null;

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
                    if (b!=0)
                    {
                        ketqua =  a / b;    
                    }
                    else
                    {
                        error = "Số b phải khác không!";
                    }
                    break;

                default:
                        error = "Lỗi phép tính không hợp lệ!";
                        break;
            }

            if (string.IsNullOrEmpty(error))
            {
                ViewBag.KetQua = ketqua;
            }
            else
            {
                ViewBag.Error = error;
            }

            ViewBag.Result = ketqua;
            ViewBag.Error = error;

            return View();
        }
    }
}
