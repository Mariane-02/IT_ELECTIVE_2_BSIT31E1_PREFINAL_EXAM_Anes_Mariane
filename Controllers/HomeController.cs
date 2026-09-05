using Microsoft.AspNetCore.Mvc;
using ITELEC2.Models;

namespace ITELEC2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = QuestionBank.GetAll();
            return View(questions);
        }

        public IActionResult Details(int id)
        {
            var question = QuestionBank.GetAll().FirstOrDefault(q => q.Number == id);
            if (question == null)
            {
                return NotFound();
            }
            return View(question);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
