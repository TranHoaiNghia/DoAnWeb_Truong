using demo_lop1.Data;
using demo_lop1.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_lop1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TheLoai1Controller : Controller
    {
        private readonly ApplicationDbContext _db;
        public TheLoai1Controller(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var theloai = _db.TheLoai1.ToList();

            ViewBag.TheLoai = theloai;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(TheLoai1 theloai)
        {
            if (ModelState.IsValid)
            {
                _db.TheLoai1.Add(theloai);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai1.Find(id);
            return View(theloai);
        }

        [HttpPost]
        public IActionResult Edit(TheLoai1 theloai)
        {
            if (ModelState.IsValid)
            {
                _db.TheLoai1.Update(theloai);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai1.Find(id);
            return View(theloai);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var theloai = _db.TheLoai1.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            _db.TheLoai1.Remove(theloai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var theloai = _db.TheLoai1.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            return View(theloai);
        }
    }
}
