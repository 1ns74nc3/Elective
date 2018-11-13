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
        
    }
}
