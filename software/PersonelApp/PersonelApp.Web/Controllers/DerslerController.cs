using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class DerslerController : Controller
    {
        private AppDbContext _context;

        private readonly DerslerRepository _derslerRepository;
        public DerslerController(AppDbContext context)
        {
            _derslerRepository = new DerslerRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            var dersler = _context.Dersler.ToList();
            return View(dersler);
        }
    }
}
