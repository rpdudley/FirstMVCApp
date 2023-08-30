using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello this is Ryan!";

        }
        public string Hello()
        {
            return "Hello Ryan!";
        }

           
    }
}
