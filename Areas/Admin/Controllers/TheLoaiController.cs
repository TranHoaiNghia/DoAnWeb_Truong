using demo_lop1.Data;
using demo_lop1.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_lop1.Controllers
{
	[Area("Admin")]
	public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            var theloai = new TheLoaiViewModel()
            {
                ID = 1,
                Name = "Trinh thám",
            };
            
            //ViewBag.Theloai = theloai;
            return View(theloai);
        }

        private readonly ApplicationDbContext _db;
        public TheLoaiController(ApplicationDbContext db)
        {
            _db = db; // Chứa thông tin của cơ sở dữ liệu // sử dụng Dependency Injection (DI)
        }
        public IActionResult Index2()
		{
            // Hiển thị danh sách các thể loại
            var theloai = _db.TheLoai.ToList();
            ViewBag.TheLoai = theloai;

			return View();
		}

        [HttpGet] 
        public IActionResult Create()
        {
            // Hiển thị thông tin
            return View();
        }

        [HttpPost]
        public IActionResult Create(TheLoai theloai)
        {
            if(ModelState.IsValid)
            {
                // Xử lý việc tạo mới
                _db.TheLoai.Add(theloai);
                _db.SaveChanges();
                return RedirectToAction("Index2");
            }
            
            return View();
        }
        
	}
}
