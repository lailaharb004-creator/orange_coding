using Microsoft.AspNetCore.Mvc;
using MVC_Student_CRUD.Migrations;
using MVC_Student_CRUD.Models;

namespace MVC_Student_CRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Update(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }
        [HttpPost]
  

      
            [HttpPost]
            public IActionResult Update(Student student)
            {
                var existingStudent = _context.Students.Find(student.StudentId);

                if (existingStudent == null)
                    return RedirectToAction("Index");
                
                existingStudent.StudentName = student.StudentName;
                existingStudent.StudentAge = student.StudentAge;

                _context.SaveChanges();

                return RedirectToAction("Index");
            }
        
        public IActionResult Delete()
        {
            

            return View();
        }

        
        [HttpPost]
        public IActionResult Delete(int StudentId)
        {
            var student = _context.Students.Find(StudentId);

            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
