using Elective.Models;
using Elective_Business_logic.Models;
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
            StudentManager students_manager = new StudentManager();
            List<Student> students = students_manager.Get_Data();
            return View(students);
        }

        public ActionResult Instructors()
        {
            InstructorManager instructors_manager = new InstructorManager();
            List<Instructor> instructors = instructors_manager.Get_Data();
            return View(instructors);
        }

        public ActionResult Subjects()
        {
            SubjectManager subjects_manager = new SubjectManager();
            List<Subject> subjects = subjects_manager.Get_Data();
            return View(subjects);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentManager students_manager = new StudentManager();
            Student student = students_manager.Get_Data().SingleOrDefault(e => e.Id == id);
            if (student == null)
            {
                return HttpNotFound();
            } 
            return View(student);
        }
    }
}