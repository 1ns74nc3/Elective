using Elective_Business_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elective.Models
{
    public class Instructor : Account
    {
        public Instructor(byte id, string firstname, string lastname) : base(id, firstname, lastname)
        {

        }
        public Instructor() : base()
        {

        }

        //public static List<Instructor> Get_Instructor_Data()
        //{
        //    List<Instructor> answer = new List<Instructor>();
        //    using (ElectiveContext db = new ElectiveContext())
        //    {
        //        //db.Instructors.Add(new Instructor(1, "Alex", "Bazhenov"));
        //        //db.Instructors.Add(new Instructor(2, "Oleg", "Hromov"));
        //        //db.SaveChanges();
        //        foreach (var item in db.Instructors)
        //        {
        //            answer.Add(item);
        //        }
        //    }
        //    return answer;
        //}

        //public static void Add_Instructor(Instructor instructor)
        //{
        //    using (ElectiveContext db = new ElectiveContext())
        //    {
        //        db.Instructors.Add(instructor);
        //        db.SaveChanges();
        //    }
        //}
    }
}