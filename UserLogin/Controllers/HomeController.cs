using Microsoft.AspNetCore.Mvc;

namespace UserLogin.Controllers
{
    public class HomeController : Controller
    {
        [Route("/home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
