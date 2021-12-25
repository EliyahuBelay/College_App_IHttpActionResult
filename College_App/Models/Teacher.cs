using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College_App.Models
{
    public class Teacher
    {
        public string FullName { get; set; }
        public int Payment { get; set; }
        public int StartYearOfWork { get; set; }
        public string[] ArrSubjectsOfStudies { get; set; }
        public int Id { get; set; }
        static int counter;
        public Teacher(string fullName, int payment, int startYearOfWork, string[] arrSubjectsOfStudies)
        {
            FullName = fullName;
            Payment = payment;
            StartYearOfWork = startYearOfWork;
            ArrSubjectsOfStudies = arrSubjectsOfStudies;
            this.Id = counter++;
        }

        public static List<Teacher> teachersList = new List<Teacher>();
    }
}