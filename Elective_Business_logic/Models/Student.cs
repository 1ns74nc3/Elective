using Elective_Business_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elective.Models
{
    public class Student : Account
    {
        public Student(byte id, string firstname, string lastname) : base(id, firstname, lastname)
        {

        }
        public Student() : base()
        {

        }

        //public static List<Student> Get_Student_Data()
        //{
        //    List<Student> answer = new List<Student>();
        //    using (ElectiveContext db = new ElectiveContext())
        //    {
        //        //db.Students.Add(new Student(1, "Igor", "Grohotsky"));
        //        //db.Students.Add(new Student(2, "Dmitriy", "Vodolazhskiy"));
        //        //db.Students.Add(new Student(3, "Alexander", "Chekmarev"));
        //        //db.SaveChanges();
        //        foreach (var item in db.Students)
        //        {
        //            answer.Add(item);
        //        }
        //    }
        //    return answer;
        //}

        //public static void Add_Student(Student student)
        //{
        //    using (ElectiveContext db = new ElectiveContext())
        //    {
        //        db.Students.Add(student);
        //        db.SaveChanges();
        //    }
        //}
    }
}