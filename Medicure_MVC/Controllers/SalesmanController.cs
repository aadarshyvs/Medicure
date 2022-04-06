using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicure_MVC.Controllers
{
    public class SalesmanController : Controller
    {
        protected static bool _loginstatus =false; 
        public IActionResult Index()
        {
            if (_loginstatus)
            {
            return View();
            }
            else
            {
                return RedirectToAction(actionName: "Login");
            }
               
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
            if(form["username"]== "salesman" && form["password"]== "salesman")
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
