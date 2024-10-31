using Microsoft.AspNetCore.Mvc;
using PersonelApp.Web.Models;

namespace PersonelApp.Web.Controllers
{
    public class HakkimdaController : Controller
    {
        private AppDbContext _context;

        private readonly YoneticiRepository _yoneticiRepository;
        public HakkimdaController(AppDbContext context)
        {
            _yoneticiRepository = new YoneticiRepository();
            _context = context;
        }
        public IActionResult Index()
        {
            var yonetici = _context.Yonetici.ToList();
            return View(yonetici);
        }
    }
}
