using demo_lop1.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_lop1.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TaiKhoanController : Controller
    {
        public IActionResult DangKy(TaiKhoanViewModel model)
        {
            return View();
        }
    }
}
