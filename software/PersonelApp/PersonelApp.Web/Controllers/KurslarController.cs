using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class KurslarController : Controller
    {
        private AppDbContext _context;

        private readonly KurslarRepository _kurslarRepository;
        public KurslarController(AppDbContext context)
        {
            _kurslarRepository = new KurslarRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            var kurslar = _context.Kurslar.ToList();
            return View(kurslar);
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
