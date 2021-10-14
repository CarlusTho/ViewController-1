using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewController.Models;
using ViewController.Services;

namespace ViewController.Controllers
{
    [Route("[Controller]/")]
    public class StudentController : Controller
    {
        public StudentService StudentService;

        public StudentController(StudentService service)
        {
            StudentService = service;
        }

        public ActionResult Index()
        {
            return View("Index", StudentService.Students);
        }

        [HttpGet("create/{nom}/{prenom}/{techno}")]
        public IActionResult Create(string nom, string prenom, string techno)
        {
            StudentModel newStudentModel = new StudentModel()
            {

                Name = nom,
                Surname = prenom,
                Techno = techno,
                Id = Guid.NewGuid()

            };

            StudentService.AddStudent(newStudentModel);
            return RedirectToAction("Index");

        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            StudentService.RemoveStudent(id);
            return RedirectToAction("Index");
        }

        
    }
}
