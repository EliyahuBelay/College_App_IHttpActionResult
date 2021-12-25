using College_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace College_App.Controllers.api
{
    public class TeacherController : ApiController
    {
        // GET: api/Teacher
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(Teacher.teachersList.ToArray());
            }
            catch
            {
                return BadRequest("ther is some problem in the process");
            }
        }

        // GET: api/Teacher/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Teacher teacher = Teacher.teachersList.Find(teacherItem => teacherItem.Id == id);
                if (teacher == null)
                {
                    return BadRequest("that user not exist");
                }
                return Ok(teacher);
            }
            catch
            {
                return BadRequest("that user not exist");
            }
        }

        // POST: api/Teacher
        public IHttpActionResult Post([FromBody] Teacher value)
        {
            try
            {
                Teacher.teachersList.Add(value);
                return Ok(Teacher.teachersList);
            }
            catch
            {
                return BadRequest("there is some problem in the process");
            }
        }

        // PUT: api/Teacher/5
        public IHttpActionResult Put(int id, [FromBody] Teacher value)
        {
            try
            {
                Teacher teacher = Teacher.teachersList.Find(teacherItem => teacherItem.Id == id);
                if (teacher == null)
                {
                    return BadRequest("that user not exist");
                }
                Teacher.teachersList[Teacher.teachersList.IndexOf(teacher)].FullName = value.FullName;
                Teacher.teachersList[Teacher.teachersList.IndexOf(teacher)].Payment = value.Payment;
                Teacher.teachersList[Teacher.teachersList.IndexOf(teacher)].StartYearOfWork = value.StartYearOfWork;
                Teacher.teachersList[Teacher.teachersList.IndexOf(teacher)].ArrSubjectsOfStudies = value.ArrSubjectsOfStudies;
                return Ok(Teacher.teachersList);
            }
            catch
            {
                return BadRequest("that user not exist");
            }
        }

        // DELETE: api/Teacher/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                int number = Teacher.teachersList.Count;
                Teacher.teachersList.Remove(Teacher.teachersList.Find(teacherItem => teacherItem.Id == id));
                if (Teacher.teachersList.Count != number)
                {
                    return Ok(Teacher.teachersList);
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
