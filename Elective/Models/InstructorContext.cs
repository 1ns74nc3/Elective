using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Elective.Models
{
    public class InstructorContext : DbContext
    {
         public InstructorContext()
                : base("DbConnection")
            { }

         public DbSet<Instructor> Instructors { get; set; }
    }
}