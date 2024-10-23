using Microsoft.AspNetCore.Mvc;

namespace PersonelApp.Web.Controllers
{
    public class KurslarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
