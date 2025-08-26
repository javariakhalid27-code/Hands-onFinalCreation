using Microsoft.AspNetCore.Mvc;
using Hands_onFinalCreation.Models;

namespace Hands_onFinalCreation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        //post :/Account/Login
        [HttpPost]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName == "administrator" && model.Password == "admin123")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username and Password");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
    }
}
