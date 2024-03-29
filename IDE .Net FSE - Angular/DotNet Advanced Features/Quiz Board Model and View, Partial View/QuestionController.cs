using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// Shoud not change template namings
namespace ASPNET6_Template.Controllers
{
    public class QuestionController : Controller
    {
        // Implement code here
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
