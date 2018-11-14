using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elective.Models
{
    //main class with common information
    public abstract class Account
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private List<string> Courses = new List<string>();

        public Account()
        {

        }

        public Account(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public Account(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}