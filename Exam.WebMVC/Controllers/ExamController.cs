using Exam.Business.Abstract;
using Exam.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.WebMVC.Controllers
{
    public class ExamController : Controller
    {
        IExamService _examService;
        public ExamController(IExamService examService)
        {
            _examService = examService;
        }
        public IActionResult Index()
        {
            var exam = _examService.GetAll();
            return View(exam.Data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Examm exam)
        {
            var result = _examService.Add(exam);
            if (result.Succes)
            {

                TempData["success"] = "exam created successfully";
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
            var exam = _examService.GetById(id);
            if (exam.Data == null)
            {
                return NotFound();
            }
            return View(exam.Data);
        }

        [HttpPost]
        public IActionResult Edit(Examm exam)
        {
            var result = _examService.Update(exam);
            if (result.Succes)
            {

                TempData["success"] = "exam updated successfully";
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
            var exam = _examService.GetById(id);
            if (exam == null)
            {
                return NotFound();
            }
            _examService.Delete(exam.Data);
            TempData["success"] = "student deleted successfully";
            return RedirectToAction("Index");




        }
    }
}
