using Elective.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elective_Business_logic.Models
{
    public class StudentManager : Manager<Student>
    {
        public override void Add_Item(Student item)
        {
            using (ElectiveContext db = new ElectiveContext())
            {
                db.Students.Add(item);
                db.SaveChanges();
            }
        }

        public override void Delete_Item(Student item)
        {
            throw new NotImplementedException();
        }

        public override List<Student> Get_Data()
        {
            List<Student> answer = new List<Student>();
            using (ElectiveContext db = new ElectiveContext())
            {
                //db.Subjects.Add(new Subject(1, "ASP.NET", "Alex", "Bazhenov", "Programming", Subject.Status.started));
                //db.Subjects.Add(new Subject(2, "Java", "Oleg", "Hromov", "Programming", Subject.Status.processing));
                //db.SaveChanges();
                foreach (Student item in db.Students)
                {
                    answer.Add(item);
                }
            }
            return answer;
        }

        
    }
}
