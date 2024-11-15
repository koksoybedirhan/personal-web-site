using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class KurslarController : Controller
    {
        private AppDbContext _context;

        private readonly KurslarRepository _kurslarRepository;
        private readonly BlogRepository _blogRepository;
        private readonly YoneticiRepository _yoneticiRepository;
        private readonly DuyurularRepository _duyurularRepository;
        public KurslarController(AppDbContext context)
        {
            _kurslarRepository = new KurslarRepository();
            _blogRepository = new BlogRepository();
            _yoneticiRepository = new YoneticiRepository();
            _duyurularRepository = new DuyurularRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            var bloglar = _context.Bloglar.ToList();
            var kurslar = _context.Kurslar.ToList();
            var yonetici = _context.Yonetici.ToList();
            var duyurular = _context.Duyurular.ToList();
            ViewBag.Duyurular = duyurular;
            ViewBag.Yonetici = yonetici;
            ViewBag.Bloglar = bloglar;
            ViewBag.Kurslar = kurslar;

            return View();
        }
    }
}
