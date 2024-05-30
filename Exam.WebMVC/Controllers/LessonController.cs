using Exam.Business.Abstract;
using Exam.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.WebMVC.Controllers
{
    public class LessonController : Controller
    {
        ILessonService _lessonService;
        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        public IActionResult Index()
        {
            var lesson = _lessonService.GetAll();
            return View(lesson.Data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Lesson lesson)
        {
            var result = _lessonService.Add(lesson);
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
            var lesson = _lessonService.GetById(id);
            if (lesson.Data == null)
            {
                return NotFound();
            }
            return View(lesson.Data);
        }

        [HttpPost]
        public IActionResult Edit(Lesson lesson)
        {
            var result = _lessonService.Update(lesson);
            if (result.Succes)
            {

                TempData["success"] = "student updated successfully";
                return RedirectToAction("Index");
            }
            return View();

        }


        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var lesson = _lessonService.GetById(id);
            if (lesson == null)
            {
                return NotFound();
            }
            _lessonService.Delete(lesson.Data);
            TempData["success"] = "student deleted successfully";
            return RedirectToAction("Index");




        }
    }
}
