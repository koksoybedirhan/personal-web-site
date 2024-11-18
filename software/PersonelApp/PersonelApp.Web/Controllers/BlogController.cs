using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class BlogController : Controller
    {
        private AppDbContext _context;
        private readonly BlogRepository _blogRepository;
        private readonly YoneticiRepository _yoneticiRepository;
        private readonly DuyurularRepository _duyurularRepository;
        private readonly LinkRepository _linkRepository;
        public BlogController(AppDbContext context)
        {
            _blogRepository = new BlogRepository();
            _yoneticiRepository = new YoneticiRepository(); 
            _duyurularRepository = new DuyurularRepository();
            _linkRepository = new LinkRepository();
            _context = context;
        }
        public IActionResult Index(string id)
        {
            var blogs = _context.Bloglar.ToList();
            var yonetici = _context.Yonetici.ToList();
            var duyurular = _context.Duyurular.ToList();
            var linkler = _context.Linkler.ToList();
            ViewBag.Linkler = linkler;
            ViewBag.Duyurular = duyurular;
            ViewBag.Yonetici = yonetici;
            ViewBag.CurrentId = id;
            ViewBag.Bloglar = blogs;
            return View();
        }
    }
}
