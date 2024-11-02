using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class BlogController : Controller
    {
        private AppDbContext _context;
        private readonly BlogRepository _blogRepository;
        public BlogController(AppDbContext context)
        {
            _blogRepository = new BlogRepository();
            _context = context;
        }
        public IActionResult Index(string id)
        {
            var blogs = _context.Bloglar.ToList();
            ViewBag.CurrentId = id;
            ViewBag.Bloglar = blogs;
            return View();
        }
    }
}
