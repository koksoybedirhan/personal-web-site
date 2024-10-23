using Microsoft.AspNetCore.Mvc;

namespace PersonelApp.Web.Controllers
{
    public class DerslerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
