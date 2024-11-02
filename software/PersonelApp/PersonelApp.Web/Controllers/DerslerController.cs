using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class DerslerController : Controller
    {
        private AppDbContext _context;

        private readonly DerslerRepository _derslerRepository;
        private readonly DerslerAyrintiRepository _derslerAyrintiRepository;
        private readonly BlogRepository _blogRepository;
        public DerslerController(AppDbContext context)
        {
            _derslerRepository = new DerslerRepository();
            _derslerAyrintiRepository = new DerslerAyrintiRepository();
            _blogRepository = new BlogRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            var bloglar = _context.Bloglar.ToList();
            var dersler = _context.Dersler.ToList();

            ViewBag.Bloglar = bloglar;
            ViewBag.Dersler = dersler;

            return View();
        }

        public IActionResult DatabaseManagement() 
        {
            var derslerAyrinti = _context.DersAyrintilar.ToList();
            return View(derslerAyrinti);
        }

        public IActionResult OperatingSystems()
        {
            var derslerAyrinti = _context.DersAyrintilar.ToList();
            return View(derslerAyrinti);
        }

        public IActionResult ComingSoon()
        {
            var derslerAyrinti = _context.DersAyrintilar.ToList();
            return View(derslerAyrinti);
        }
    }
}
