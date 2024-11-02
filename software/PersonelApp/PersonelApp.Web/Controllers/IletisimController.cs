using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class IletisimController : Controller
    {
        private AppDbContext _context;
        private readonly BlogRepository _blogRepository;
        public IletisimController(AppDbContext context)
        {
            _blogRepository = new BlogRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            var bloglar = _context.Bloglar.ToList();
            ViewBag.Bloglar = bloglar;
            return View();
        }
    }
}
