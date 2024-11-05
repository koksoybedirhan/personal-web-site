using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonelApp.Web.Models;
using System.Diagnostics;

namespace PersonelApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        private readonly ILogger<HomeController> _logger;
        private readonly HomeRepository _homeRepository;
        private readonly BlogRepository _blogRepository;
        private readonly YoneticiRepository _yoneticiRepository;
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _blogRepository = new BlogRepository();
            _homeRepository = new HomeRepository();
            _yoneticiRepository = new YoneticiRepository();
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var blogs = _context.Bloglar.ToList();
            var home = _context.Home.ToList();
            var yonetici = _context.Yonetici.ToList();
            ViewBag.Yonetici = yonetici;
            ViewBag.Bloglar = blogs;
            ViewBag.Home = home;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}