using demo_lop1.Data;
using demo_lop1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demo_lop1.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<SanPham> sanpham = _db.Sanpham.ToList();
            return View(sanpham);
        }

        public IActionResult Privacy()
        {
            var theloai = new TheLoaiViewModel()
            {
                ID = 1,
                Name = "123"
            };

            ViewBag.TheLoai = theloai;
            return View();
        }

        public IActionResult Edit(int id, string name)
        {
            return Content(string.Format("id: {0}; ten: {1}", id, name));
        }

        public IActionResult Show(List<string> Categories)
        {
            var content = "Category list: ";

            foreach (var category in Categories)
            {
                content += category + " ";
            }
            return Ok(content);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}