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
            return View("Students", new []
            {
                new StudentModel
                {
                    Name = "VAREILLE",
                    Surname = "Nicolas",
                    Techno = "C#"
                },
                new StudentModel
                {
                    Name = "MASSE",
                    Surname = "Raphaël",
                    Techno = "PHP"
                },
                new StudentModel
                {
                    Name = "CARLUS",
                    Surname = "Thomas",
                    Techno = "C#"
                },
                new StudentModel
                {
                    Name = "COUTO DE OLIVEIRA",
                    Surname = "Dylan",
                    Techno = "Python"
                },
                new StudentModel
                {
                    Name = "NGUYEN",
                    Surname = "Timothée",
                    Techno = "C#"
                },
                new StudentModel
                {
                    Name = "HENRIQUES",
                    Surname = "Sylvio",
                    Techno = "VBA.Net"
                },
                new StudentModel
                {
                    Name = "DE CAMPOS",
                    Surname = "Armelio",
                    Techno = "Python"
                }

            });
        }
    }
}
