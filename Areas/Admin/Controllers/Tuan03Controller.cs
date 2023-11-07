using demo_lop1.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_lop1.Controllers
{
	[Area("Admin")]
	public class Tuan03Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DangKy(TaiKhoan1ViewModel taikhoan)
        {
            return View();
        }

        public IActionResult BaiTap1()
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = "Laptop ASUS",
                GiaBan = 20000000,
                AnhMoTa = "Laptop..."
            };
            return View(sanpham);
        }

        public IActionResult BaiTap2(TaiKhoan2ViewModel dangky)
        {
            if(dangky.TenTaiKhoan != null)
			{
				return Content(dangky.TenTaiKhoan);
			}
			return View();
        }
    }
}
