using Microsoft.AspNetCore.Mvc;
using MA.Data;
using MA.Models;


namespace MA.Controllers
{
    public class StudentsController : Controller
    {   
        private readonly ILogger<StudentsController> _logger;
        private readonly AppDbContext _db;
        public StudentsController(ILogger<StudentsController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpPost]
        public IActionResult addSudent(Student student)
        {
            if(student != null)
            {
                _db.Students.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Students");
            }
            return View("Students");
        }


       public IActionResult Students()
        {
            return View();
        }
    }

}