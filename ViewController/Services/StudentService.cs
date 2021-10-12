using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ViewController.Models;

namespace ViewController.Services
{
    public class StudentService
    {
        public IEnumerable<StudentModel> Students;

        public StudentService()
        {
            string text = File.ReadAllText("students.json");
        }
    }
}
