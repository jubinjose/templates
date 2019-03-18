using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices
{

    public class Student
    {
        public static Student Jubin = new Student { Id = 5, FirstName = "Jubin", LastName = "Jose" };

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}