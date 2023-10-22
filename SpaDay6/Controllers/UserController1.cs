using Microsoft.AspNetCore.Mvc;

namespace SpaDay6.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }
    }
}
