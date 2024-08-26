using Microsoft.AspNetCore.Mvc;
using UserLogin.Models;

namespace UserLogin.Controllers
{
    public class RegisterController : Controller
    {
        [Route("/Register")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult Index(RegisterPostModel registerPostModel)
        {   
            return View();

        }
    }
}
