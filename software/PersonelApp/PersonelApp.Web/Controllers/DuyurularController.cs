using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class DuyurularController : Controller
    {
        private AppDbContext _context;
        private readonly YoneticiRepository _yoneticiRepository;
        private readonly BlogRepository _blogRepository;
        public DuyurularController(AppDbContext context)
        {
            _yoneticiRepository = new YoneticiRepository();
            _blogRepository = new BlogRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            var bloglar = _context.Bloglar.ToList();
            var yonetici = _context.Yonetici.ToList();
            ViewBag.Bloglar = bloglar;
            ViewBag.Yonetici = yonetici;
            return View();
        }
    }
}
