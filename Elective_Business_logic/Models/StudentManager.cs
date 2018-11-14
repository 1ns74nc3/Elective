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
                var id = db.Students.Max(p => p.Id);
                item.Id = ++id;
                db.Students.Add(item);
                db.SaveChanges();
            }
        }

        public override void Delete_Item(int item)
        {
            using (ElectiveContext db = new ElectiveContext())
            {
                db.Students.Remove(db.Students.FirstOrDefault(e => e.Id == item));
                db.SaveChanges();
            }
        }

        public override List<Student> Get_Data()
        {
            List<Student> answer = new List<Student>();
            using (ElectiveContext db = new ElectiveContext())
            {
                foreach (Student item in db.Students)
                {
                    answer.Add(item);
                }
            }
            return answer;
        }

        
    }
}
