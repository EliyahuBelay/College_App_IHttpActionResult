using College_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace College_App.Controllers.api
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(Student.studentsList.ToArray());
            }
            catch
            {
                return BadRequest("ther is some problem in the process");
            }
        }

        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Student student = Student.studentsList.Find(studentItem => studentItem.Id == id);
                if (student == null)
                {
                    return BadRequest("that user not exist");
                }
                return Ok(student);
            }
            catch
            {
                return BadRequest("that user not exist");
            }
        }

        // POST: api/Student
        public IHttpActionResult Post([FromBody] Student value)
        {
            try
            {
                Student.studentsList.Add(value);
                return Ok(Student.studentsList);
            }
            catch
            {
                return BadRequest("there is some problem in the process");
            }
        }

        // PUT: api/Student/5
        public IHttpActionResult Put(int id, [FromBody] Student value)
        {
            try
            {
                Student student = Student.studentsList.Find(studentItem => studentItem.Id == id);
                if (student == null)
                {
                    return BadRequest("that user not exist");
                }
                Student.studentsList[Student.studentsList.IndexOf(student)].FullName = value.FullName;
                Student.studentsList[Student.studentsList.IndexOf(student)].ClassRoom = value.ClassRoom;
                Student.studentsList[Student.studentsList.IndexOf(student)].YearOfBirth = value.YearOfBirth;
                Student.studentsList[Student.studentsList.IndexOf(student)].ArrayOfGrades = value.ArrayOfGrades;
                return Ok(Student.studentsList);
            }
            catch
            {
                return BadRequest("that user not exist");
            }
        }

        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                int number = Student.studentsList.Count;
                Student.studentsList.Remove(Student.studentsList.Find(studentItem => studentItem.Id == id));
                if (Student.studentsList.Count != number)
                {
                    return Ok(Student.studentsList);
                }
                else
                {
                    return BadRequest("that item not found");
                }
            }
            catch
            {
                return BadRequest("that item not found");

            }
        }
    }
}
