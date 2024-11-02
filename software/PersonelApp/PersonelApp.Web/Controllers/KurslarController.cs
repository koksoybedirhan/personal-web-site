using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class KurslarController : Controller
    {
        private AppDbContext _context;

        private readonly KurslarRepository _kurslarRepository;
        private readonly BlogRepository _blogRepository;
        public KurslarController(AppDbContext context)
        {
            _kurslarRepository = new KurslarRepository();
            _blogRepository = new BlogRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            var bloglar = _context.Bloglar.ToList();
            var kurslar = _context.Kurslar.ToList();

            ViewBag.Bloglar = bloglar;
            ViewBag.Kurslar = kurslar;

            return View();
        }

        public IActionResult ESP32Dersleri()
        {
            return View();
        }
        public IActionResult NextionDersleri()
        {
            return View();
        }

        public IActionResult DWINDersleri()
        {
            return View();
        }
        public IActionResult ArduinoProjeleri()
        {
            return View();
        }
    }
}
