using Microsoft.AspNetCore.Mvc;

namespace ASPNET6_Template.Controllers
{
    public class QuizController : Controller
    {
        //Implement your code here

        public ActionResult UserName(string firstName, string lastName)
        {
            ViewBag.Name = firstName + " " + lastName;
            return View();
        }

        public ActionResult Question(string question)
        {
            ViewData["Question"] = question;
            return View();
        }

        public IActionResult Answer(string answer)
        {
            TempData["Answer"] = answer;
            return RedirectToAction("FinalOut");
        }

        public IActionResult FinalOut()
        {
            String variable = TempData["Answer"] as String;
            return View(); 
        }
    }
}