using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeAPI.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet()]
        public IActionResult GetEmployees()
        {
            var users = new List<Employee>
            {
                new Employee
                {
                      id = 1,
                    uid = "fSgXqXgLDWTf",
                    password = "hIcrXvDsrn",
                    first_name = "John",
                    last_name = "Garcia",
                    username = "john.garcia25",
                    email = "john.garcia25@example.com",
                    avatar = "https://robohash.org/1",
                    gender = "Female",
                    phone_number = "+30-312-6963",
                    wallet = 744.91,
                    date_of_birth = "1958-07-17"
                }

           
            };
            return Ok(users);
        }

        //// GET api/<ValuesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ValuesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
