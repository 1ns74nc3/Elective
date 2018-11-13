using Elective.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Elective.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Students()
        {
            List<Student> students = Student.Get_Student_Data();
            return View(students);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = Instructor.Get_Instructor_Data();
            return View(instructors);
        }

        public ActionResult Subjects()
        {
            List<Subject> subjects = Subject.Get_Subject_Data();
            return View(subjects);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }                
            Student student = Student.Get_Student_Data().SingleOrDefault(e => e.Id == id);
            if (student == null)
            {
                return HttpNotFound();
            } 
            return View(student);
        }
    }
}