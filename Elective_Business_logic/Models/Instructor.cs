using Elective_Business_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elective.Models
{
    public class Instructor : Account
    {
        public Instructor(int id, string firstname, string lastname) : base(id, firstname, lastname)
        {

        }
        public Instructor() : base()
        {

        }
    }
}