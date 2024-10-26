using Microsoft.AspNetCore.Mvc;

namespace PersonelApp.Web.Controllers
{
    public class HakkimdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
