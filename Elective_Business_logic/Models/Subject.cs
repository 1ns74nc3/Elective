using Elective_Business_logic;
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
        public int Id { get; set; }
        public string Subject_name { get; set; }
        public string Instructor_Firstname { get; set; }
        public string Instructor_Lastname{ get; set; }
        public string Topic { get; set; }
        private List<Student> Students = new List<Student>();

        public void Add(Student student)
        {
            Students.Add(student);
        }

        public Subject(int id, string course_name, string instructor_firstname, string instructor_lastname, string topic, Status status)
        {
            Id = id;
            Subject_name = course_name;
            Instructor_Firstname = instructor_firstname;
            Instructor_Lastname = instructor_lastname;
            Topic = topic;
            Course_status = status;
        }

        public Subject()
        {

        }
    }
}