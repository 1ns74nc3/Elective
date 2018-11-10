using Elective.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Elective.Controllers
{
    public class HomeController : Controller
    {
        List<Student> students = new List<Student>();
        List<Subject> subjects = new List<Subject>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Students()
        {
            students.Add(new Student(1,"Igor","Grohotsky"));
            students.Add(new Student(2,"Dmitriy","Vodolazhskiy"));
            students.Add(new Student(3,"Alexander","Chekmarev"));
            return View(students);
        }
        
        public ActionResult Subjects()
        {
            subjects.Add(new Subject(1, "ASP.NET", new Instructor(1, "Alex", "Bazhenov"), "Programming", Subject.Status.started));
            subjects.Add(new Subject(2, "Java", new Instructor(2, "Oleg", "Hromov"), "Programming", Subject.Status.processing));
            return View(subjects);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            students.Add(new Student(1, "Igor", "Grohotsky"));
            students.Add(new Student(2, "Dmitriy", "Vodolazhskiy"));
            students.Add(new Student(3, "Alexander", "Chekmarev"));
            Student student = students.SingleOrDefault(e => e.Id == id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
    }
}