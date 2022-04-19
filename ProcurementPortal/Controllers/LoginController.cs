using Microsoft.AspNetCore.Mvc;
using Core;

namespace Portal.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            /*var user = new Core.Login.User();
            if (!user.login(username, password))
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.error = "Invalid Account";
            return View("Index");*/

            return RedirectToAction("Index", "Home");
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}