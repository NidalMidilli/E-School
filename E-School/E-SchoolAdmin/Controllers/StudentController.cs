using BusinessLayer.Abstract;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace E_SchoolAdmin.Controllers
{
    public class StudentController : Controller
    {
        IStudentService studentService;
        Context con = new Context();
        public StudentController(IStudentService studentService)
        {
            this.studentService=studentService;
        }
        [HttpGet]
        [Authorize(Roles ="admin")]
        public IActionResult Index()
        {
            var result = studentService.GetAllStudents();
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            StudentValidator studentValidator = new StudentValidator();
            ValidationResult results = studentValidator.Validate(student);
            if (results.IsValid)
            {
                studentService.AddStudent(student);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = studentService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            StudentValidator studentValidator = new StudentValidator();
            ValidationResult results = studentValidator.Validate(student);
            if (results.IsValid)
            {
                studentService.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = studentService.GetById(id);
            studentService.DeleteStudent(result);
            return RedirectToAction("Index");
        }
    }
}
