using Microsoft.AspNetCore.Mvc;

namespace UserLogin.Controllers
{
    public class LoginController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
