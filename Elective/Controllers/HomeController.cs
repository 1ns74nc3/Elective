using Elective.Models;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Elective.Controllers
{
    public class HomeController : Controller
    {
        List<Student> students = new List<Student>();
        List<Instructor> instructors = new List<Instructor>();
        List<Subject> subjects = new List<Subject>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Students()
        {
            using (StudentContext db = new StudentContext())
            {
                //db.Students.Add(new Student(1, "Igor", "Grohotsky"));
                //db.Students.Add(new Student(2, "Dmitriy", "Vodolazhskiy"));
                //db.Students.Add(new Student(3, "Alexander", "Chekmarev"));
                //db.SaveChanges();
                students.Clear();
                foreach(Student item in db.Students)
                {
                    students.Add(item);
                }
            }
            return View(students);
        }

        public ActionResult Instructors()
        {
            using (InstructorContext db = new InstructorContext())
            {
                //db.Instructors.Add(new Instructor(1, "Valeriy", "Golishev"));
                //db.Instructors.Add(new Instructor(2, "Igor", "Vasilyev"));
                //db.SaveChanges();
                instructors.Clear();
                foreach (Instructor item in db.Instructors)
                {
                    instructors.Add(item);
                }
            }
            return View(instructors);
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
            
            using (StudentContext db = new StudentContext())
            {
                Student student = db.Students.SingleOrDefault(e => e.Id == id);
                if (student == null)
                {
                    return HttpNotFound();
                }
                return View(student);
            }
        }
    }
}