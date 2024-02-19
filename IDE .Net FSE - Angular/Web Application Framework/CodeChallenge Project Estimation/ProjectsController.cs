using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectEstimation.Models; // Make sure to include necessary namespaces

namespace ProjectEstimation.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly InMemoryUserStoryRepo _db;

        public ProjectsController()
        {
            // Initialize the InMemoryUserStoryRepo
            _db = new InMemoryUserStoryRepo();
        }

        [HttpGet]
        public ActionResult Index()
        {
            // Retrieve all user stories from the repository
            var userStories = _db.GetAllUserStories();
            return View(userStories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserStory userStory)
        {
            if (ModelState.IsValid)
            {
                // Add the user story to the repository
                _db.Add(userStory);
                return RedirectToAction("Index");
            }
            return PartialView("_CreatePartial", userStory);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            // Retrieve the user story by id
            var userstory = _db.Get(id);
            if (userstory == null)
            {
                return HttpNotFound();
            }
            return View(userstory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserStory userstory)
        {
            if (ModelState.IsValid)
            {
                // Update the user story in the repository
                _db.Update(userstory);
                return RedirectToAction("Index");
            }
            return View(userstory);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            // Retrieve the user story by id
            var userstory = _db.Get(id);
            if (userstory == null)
            {
                return HttpNotFound();
            }
            return View(userstory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection formcollection)
        {
            // Delete the user story from the repository
            _db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
