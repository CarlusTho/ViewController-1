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
            return View("Students", StudentService.Students);
        }
    }
}
