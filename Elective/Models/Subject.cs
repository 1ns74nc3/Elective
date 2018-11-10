using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elective.Models
{
    //information about the subject
    public class Subject
    {
        public byte Id { get; set; }
        public string Subject_name { get; set; }
        public Instructor Instructor { get; set; }
        public string Topic { get; set; }
        private List<Student> Students = new List<Student>();
        public bool IsStarted { get; set; }

        public void Add(Student student)
        {
            Students.Add(student);
        }

    }
}