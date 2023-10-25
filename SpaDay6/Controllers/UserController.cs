using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;
using SpaDay6.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel vm = new AddUserViewModel();
            return View(vm);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel vm)
        {
            if (ModelState.IsValid && vm.Password == vm.VerifyPassword)
            {
                User user = new User
                {
                    Username = vm.UserName,
                    Email = vm.Email,
                    Password = vm.Password,
                };
                return View("Index", user);
            }
            else
            {
                //User.Username = vm.UserName;
                //User.Email = vm.Email;                    
                return View("Add");
            }
        }
        //if (newUser.Password == verify)
        //{
        //    ViewBag.user = newUser;
        //    return View("Index");
        //}
        //else
        //{
        //    ViewBag.error = "Passwords do not match! Try again!";
        //    ViewBag.userName = newUser.Username;
        //    ViewBag.eMail = newUser.Email;
        //    return View("Add");
        //}
    }
}


