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
    }
}