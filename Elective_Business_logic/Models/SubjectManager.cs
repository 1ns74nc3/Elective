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

        public override void Delete_Item(int item)
        {
            //using (ElectiveContext db = new ElectiveContext())
            //{
            //    db.Subjects.Remove();
            //    db.SaveChanges();
            //}
        }

        public override List<Subject> Get_Data()
        {
            List<Subject> answer = new List<Subject>();
            using (ElectiveContext db = new ElectiveContext())
            {
                foreach (Subject item in db.Subjects)
                {
                    answer.Add(item);
                }
            }
            return answer;
        }
    }
}
