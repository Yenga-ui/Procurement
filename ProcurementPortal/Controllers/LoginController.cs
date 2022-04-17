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
            Core.Login.User user = new Core.Login.User();

            if (user.login(username, password))
            {
                HttpContext.Session.SetString("username", username);
                return View("Success");

            }
           
                
            
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Index");
            }


        }
        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
    }
