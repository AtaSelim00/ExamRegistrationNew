using Exam.Business.Abstract;
using Exam.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.WebMVC.Controllers
{
    public class StudentController : Controller
    {
        IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students.Data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            var result = _studentService.Add(student);
            if (result.Succes)
            {

                TempData["success"] = "student created successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var student = _studentService.GetById(id);
            if (student.Data == null)
            {
                return NotFound();
            }
            return View(student.Data);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var result = _studentService.Update(student);
            if (result.Succes)
            {

                TempData["success"] = "student updated successfully";
                return RedirectToAction("Index");
            }
            return View();
          
        }


        public IActionResult Delete(int id)
        {
            if ( id == 0)
            {
                return NotFound();
            }
            var student = _studentService.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            _studentService.Delete(student.Data);  
            TempData["success"] = "student deleted successfully";
            return RedirectToAction("Index");




        }
    }
}
