﻿using Elective.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elective.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Students()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1,"Igor","Grohotsky"));
            students.Add(new Student(2,"Dmitriy","Vodolazhskiy"));
            students.Add(new Student(2,"Alexander","Chekmarev"));
            return View(students);
        }
    }
}