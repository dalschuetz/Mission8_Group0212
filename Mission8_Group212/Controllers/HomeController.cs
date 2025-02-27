using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission8_Group212.Models;

namespace Mission8_Group212.Controllers
{
    public class HomeController : Controller
    {
        private TaskModel _task;

        public HomeController(TaskModel instance)
        {
            _task = instance;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quadrants()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Quadrants(int TaskId)
        {
            return View();
        }

        public IActionResult TaskForm()
        {
            return View();
        }


    }
}
