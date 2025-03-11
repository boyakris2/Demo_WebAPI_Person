using Microsoft.AspNetCore.Mvc;
using DemoWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        List<person> people = new List<person>();
        public PeopleController()
        {
         people.Add(new person { FirstName = "Krishna", MiddleName ="FamilyMan",
         LastName="Punctual"})
         people.Add(new person 
                { FirstName = "Manju",
                    MiddleName = "SweatHeart",
                    LastName = "Monster"
                })
         people.Add(new person
                { FirstName = "Sunny",
            MiddleName = "Smart",
            LastName = "LazyButt"
         people.Add(new person
         {
             FirstName = "Bunny",
             MiddleName = "Confused",
             LastName = "Idiot"
         })
        }
        
        // GET: api/<PeopleController>
        [HttpGet]
        //public IEnumerable<string> Get()
        public List<person> Get()
        {
            return people;
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
