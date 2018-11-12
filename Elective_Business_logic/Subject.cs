using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elective.Models
{
    //information about the subject
    public class Subject
    {
        public enum Status
        {
            started = 1,
            processing = 2,
            finished = 3
        }
        public Status Course_status { get; set; }
        public byte Id { get; set; }
        public string Subject_name { get; set; }
        public Instructor Instructor { get; set; }
        public string Topic { get; set; }
        private List<Student> Students = new List<Student>();

        public void Add(Student student)
        {
            Students.Add(student);
        }

        public Subject(byte id, string course_name, Instructor instructor, string topic, Status status)
        {
            Id = id;
            Subject_name = course_name;
            Instructor = instructor;
            Topic = topic;
            Course_status = status;
        }

    }
}