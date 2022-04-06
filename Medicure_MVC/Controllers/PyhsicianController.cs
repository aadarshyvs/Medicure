using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicure_MVC.Controllers
{
    public class PyhsicianController : Controller
    {
        protected static bool _loginstatus = false;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (_loginstatus)
            {
                return RedirectToAction(actionName: "Index");

            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            if (form["username"] == "physician" && form["password"] == "physician")
            {
                _loginstatus = true;
                return RedirectToAction(actionName: "Index");
            }
            else
            {
                return RedirectToAction(actionName: "Login");
            }
        }

    }

}
