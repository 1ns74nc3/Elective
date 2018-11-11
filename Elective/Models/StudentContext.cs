using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Elective.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("DbConnection")
        { }

        public DbSet<Student> Students { get; set; }
    }
}