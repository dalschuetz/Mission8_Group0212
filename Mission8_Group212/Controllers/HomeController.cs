using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission8_Group212.Models;

namespace Mission8_Group212.Controllers
{
    public class HomeController : Controller
    {
        private Mission8Context _context;

        public HomeController(Mission8Context instance)
        {
            _context = instance;
        }
        public IActionResult Index()
        {
            return View();
        }


        //need to get correct information
        [HttpGet]
        public IActionResult Quadrants()
        {
            var list = _context.Tasks.ToList();

            return View(list);
        }


        //New
        [HttpGet]
        public IActionResult TaskForm()
        {
            ViewBag.Quadrants = _context.Quadrants.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View(new TaskModel());
        }

        [HttpPost]
        public IActionResult TaskForm(TaskModel response)
        {
            if (ModelState.IsValid)
            {
                //saves form to database
                _context.Tasks.Add(response);
                _context.SaveChanges();

                //reloads the form page to enter a new movie, no confirmation page
                return RedirectToAction("Quadrants");
            }
            else
            {
                ViewBag.Quadrants = _context.Quadrants.ToList();
                ViewBag.Categories = _context.Categories.ToList();

                return View(response);
            }
        }


        //Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var editableTask = _context.Tasks
                .Single(x => x.TaskId == id);

            ViewBag.Quadrants = _context.Quadrants.ToList();
            ViewBag.Categories = _context.Categories.ToList();

            return View("TaskForm", editableTask);
        }

        [HttpPost]
        public IActionResult Edit(TaskModel updatedTask)
        {
            _context.Update(updatedTask);
            _context.SaveChanges();

            return RedirectToAction("Quadrants");
        }


        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var deleteableTask = _context.Tasks
                .Single(x => x.TaskId == id);

            return View(deleteableTask);
        }

        [HttpPost]
        public IActionResult Delete(TaskModel deletedTask)
        {
            _context.Remove(deletedTask);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
