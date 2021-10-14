using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ViewController.Models;

namespace ViewController.Services
{
    public class StudentService
    {
        public List<StudentModel> Students;

        public StudentService()
        {
            string text = File.ReadAllText("students.json");

            Students = JsonConvert.DeserializeObject<List<StudentModel>>(text);
        }

        public void AddStudent(StudentModel newStudent)
        {
            Students.Add(newStudent);
            string data = JsonConvert.SerializeObject(Students);

            File.WriteAllText("students.json", data);
        }

        public void RemoveStudent(Guid id)
        {
            Students.Remove(Students.First(i => i.Id == id));
            string data = JsonConvert.SerializeObject(Students);
            
            File.WriteAllText("students.json", data);
        }
    }
