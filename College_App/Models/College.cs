using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College_App.Models
{
    public class College
    {
        public string FName { get; set; }
        public string Lname { get; set; }
        public int YearOfBirth { get; set; }
        public bool IsConected { get; set; }
        public int Id { get; set; }
        static int counter;
        public College(string fName, string lname, int yearOfBirth, bool isConected)
        {
            FName = fName;
            Lname = lname;
            YearOfBirth = yearOfBirth;
            IsConected = isConected;
            this.Id = counter++;
        }


        public static List<College> collegeList = new List<College>();
    }
}