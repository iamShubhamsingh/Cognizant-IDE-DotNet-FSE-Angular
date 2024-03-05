using ASPNET6_Template.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET6_Template.Controllers
{
    public class LoginController : Controller
    {
        //Implement your code here
        
        LoginContext context;
        public LoginController(LoginContext _context)
        {
            context = _context;
        }
        
        public IActionResult UserLogin()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult UserLogin(LoginPage login)
        {
            if(ModelState.IsValid)
            {
                var r = context.Registrations.Where(l => l.UserName == login.UserName).FirstOrDefault();
                
                if(r != null)
                return View("Welcome",login);
                
                return View();
            }
            return View();
        }
        
        public IActionResult AddUser()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUser(Registration registration)
        {
            if(ModelState.IsValid)
            {
                if(registration.UserName == registration.Password)
                {
                    ViewBag.Message = "UserName and Password should not be the same";
                }
                else
                {
                    context.Registrations.Add(registration);
                    context.SaveChanges();
                    return View(registration);
                }
                return View();
            }
            return View();
        }
        
        public IActionResult Welcome()
        {
            return View();
        }
    }
}