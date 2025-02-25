using Microsoft.AspNetCore.Mvc;

using MA.Data;
using MA.Models;

namespace MA.Controllers
{
    public class PresenceController : Controller
    {
        private readonly ILogger<PresenceController> _logger;
        private readonly AppDbContext _db;

        public PresenceController(ILogger<PresenceController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpPost]
        public IActionResult addStudent(Student student)
        {
            if(student != null){
                _db.Students.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Presence");
            }
            return View("Presence", _db.Students.ToList());
        }

        [HttpPost]
        public IActionResult rmStudant(string Cpf){
            var student = _db.Students.FirstOrDefault(s => s.Cpf == Cpf);
            if(student != null){
                _db.Students.Remove(student);
                _db.SaveChanges();
            }
            return RedirectToAction("Presence"); 
        }

        public IActionResult Presence()
        {
            var students = _db.Students.ToList();
            return View(students);
        }
    }
}
