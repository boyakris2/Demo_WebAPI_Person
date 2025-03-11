using DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        List<Person> people = new List<Person>();

        public PeopleController() {
            people.Add(new Person
            {
                FirstName = "Krishna",
                MiddleName = "FamilyMan",
                LastName = "Punctual, Believe in Harwork, Broken heart",
                Id = 1

            });
            people.Add(new Person
            {
                FirstName = "Manju",
                MiddleName = "SweatHeart, no more",
                LastName = "Monster, Lier, Storm",
                Id = 2
            });
            people.Add(new Person
            {
                FirstName = "Sunny",
                MiddleName = "Smart",
                LastName = "LazyButt, Could have done much better",
                Id = 3
            });
            people.Add(new Person
            {
                FirstName = "Bunny",
                MiddleName = "Bit confused, but intelligent",
                LastName = "Idiot, No discipline, Improving",
                Id = 4
            });
        }

        // GET: api/<PeopleController>
        [HttpGet]
        public List<Person> Get()
        {
            return people;
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public Person Get(int id, [FromHeader] string firstName)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post([FromBody]string value)
        {
           //strings.Add(value);
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
