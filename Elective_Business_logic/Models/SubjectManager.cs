using Elective.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elective_Business_logic.Models
{
    public class SubjectManager : Manager<Subject>
    {
        public override void Add_Item(Subject item)
        {
            using (ElectiveContext db = new ElectiveContext())
            {
                db.Subjects.Add(item);
                db.SaveChanges();
            }
        }

        public override List<Subject> Get_Data()
        {
            List<Subject> answer = new List<Subject>();
            using (ElectiveContext db = new ElectiveContext())
            {
                //db.Subjects.Add(new Subject(1, "ASP.NET", "Alex", "Bazhenov", "Programming", Subject.Status.started));
                //db.Subjects.Add(new Subject(2, "Java", "Oleg", "Hromov", "Programming", Subject.Status.processing));
                //db.SaveChanges();
                foreach (Subject item in db.Subjects)
                {
                    answer.Add(item);
                }
            }
            return answer;
        }
    }
}
