using Elective.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elective_Business_logic
{
    class ElectiveContext : DbContext
    {
        public ElectiveContext() 
            : base("DbConnection")
        {

        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }

        public static List<object> Get_Data()
        {
            List<object> answer = new List<object>();
            using (ElectiveContext db = new ElectiveContext())
            {
                //db.Subjects.Add(new Subject(1, "ASP.NET", "Alex", "Bazhenov", "Programming", Subject.Status.started));
                //db.Subjects.Add(new Subject(2, "Java", "Oleg", "Hromov", "Programming", Subject.Status.processing));
                //db.SaveChanges();
                foreach (var item in db)
                {
                    answer.Add(item);
                }
            }
            return answer;
        }

        public static void Add_Item(T item)
        {
            using (ElectiveContext db = new ElectiveContext())
            {
                db.Subjects.Add(item);
                db.SaveChanges();
            }
        }
    }
}
