using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class HakkimdaController : Controller
    {
        private AppDbContext _context;

        private readonly YoneticiRepository _yoneticiRepository;
        private readonly BlogRepository _blogRepository;
        private readonly DuyurularRepository _duyurularRepository;
        public HakkimdaController(AppDbContext context)
        {
            _yoneticiRepository = new YoneticiRepository();
            _blogRepository = new BlogRepository();
            _duyurularRepository = new DuyurularRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            var bloglar = _context.Bloglar.ToList();
            var yonetici = _context.Yonetici.ToList();
            var duyurular = _context.Duyurular.ToList();
            ViewBag.Duyurular = duyurular;
            ViewBag.Bloglar = bloglar;
            ViewBag.Yonetici = yonetici;

            return View();
        }
    }
}
