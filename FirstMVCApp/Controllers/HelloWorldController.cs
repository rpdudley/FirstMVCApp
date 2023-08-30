using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
