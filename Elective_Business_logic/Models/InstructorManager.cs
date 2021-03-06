﻿using Elective.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elective_Business_logic.Models
{
    public class InstructorManager : Manager<Instructor>
    {
        public override void Add_Item(Instructor item)
        {
            using (ElectiveContext db = new ElectiveContext())
            {
                db.Instructors.Add(item);
                db.SaveChanges();
            }
        }

        public override void Delete_Item(int item)
        {
            using (ElectiveContext db = new ElectiveContext())
            {
                //db.Instructors.Remove(item);
                //db.SaveChanges();
            }
        }

        public override List<Instructor> Get_Data()
        {
            List<Instructor> answer = new List<Instructor>();
            using (ElectiveContext db = new ElectiveContext())
            {
                foreach (Instructor item in db.Instructors)
                {
                    answer.Add(item);
                }
            }
            return answer;
        }
    }
}
