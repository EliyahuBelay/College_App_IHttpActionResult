using College_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace College_App.Controllers.api
{
    public class CollegeController : ApiController
    {
        // GET: api/College
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(College.collegeList.ToArray());
            }
            catch
            {
                return BadRequest("sorry ther is some problem in the process");
            }
        }

        // GET: api/College/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                College user = College.collegeList.Find(userItem => userItem.Id == id);
                if (user == null)
                {
                    return BadRequest("that user not exist");
                }
                else
                {
                    return Ok(user);
                }
            }
            catch
            {
                return BadRequest("that user not exist");
            }
        }

        // POST: api/College
        [HttpPost]
        public IHttpActionResult Post([FromBody] College value)
        {
            //try
            //{
            College.collegeList.Add(value);
            return Ok(College.collegeList);
            //}
            //catch (FormatException)
            //{
            //    College.collegeList.Remove(value);
            //    return Ok("item was not in right format");
            //}



            //catch (FormatException)
            //{
            //    return Ok("please write in right format");
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    return Ok("too much years");
            //}
        }

        // PUT: api/College/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] College value)
        {
            try
            {
                College user = College.collegeList.Find(userItem => userItem.Id == id);

                if (user == null)
                {
                    return BadRequest("that user not exist");
                }
                College.collegeList[College.collegeList.IndexOf(user)].FName = value.FName;
                College.collegeList[College.collegeList.IndexOf(user)].Lname = value.Lname;
                College.collegeList[College.collegeList.IndexOf(user)].YearOfBirth = value.YearOfBirth;
                College.collegeList[College.collegeList.IndexOf(user)].IsConected = value.IsConected;
                //--(not succeeded)--{
                //College.collegeList[College.collegeList.IndexOf(user)] = value;
                //College.collegeList[College.collegeList.IndexOf(user)].Id = id;
                //}
                return Ok(College.collegeList);
            }
            catch
            {
                return BadRequest("sorry ther is some problem in the process");
            }

        }

        // DELETE: api/College/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                int number = College.collegeList.Count;
                College.collegeList.Remove(College.collegeList.Find(userItem => userItem.Id == id));
                if (College.collegeList.Count != number)
                {
                    return Ok(College.collegeList);
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
