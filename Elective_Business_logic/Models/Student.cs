using Elective_Business_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elective.Models
{
    public class Student : Account
    {
        public Student(int id, string firstname, string lastname) : base(id, firstname, lastname)
        {

        }
        public Student(string firstname, string lastname) : base(firstname, lastname)
        {

        }
        public Student() : base()
        {

        }
    }
}