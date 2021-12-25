using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College_App.Models
{
    public class Student
    {
        public string FullName { get; set; }
        public byte ClassRoom { get; set; }
        public short YearOfBirth { get; set; }
        public short[] ArrayOfGrades { get; set; }
        public int Id { get; set; }
        static int counter;

        public Student(string fullName, byte classRoom, short yearOfBirth, short[] arrayOfGrades)
        {
            FullName = fullName;
            ClassRoom = classRoom;
            YearOfBirth = yearOfBirth;
            ArrayOfGrades = arrayOfGrades;
            this.Id = counter++;
        }

        public static List<Student> studentsList = new List<Student>();
    }
}