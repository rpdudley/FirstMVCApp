using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstMVCApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaddyAPIController : ControllerBase
    {
        [HttpGet]
        [Route("WhoIsYourDaddy")]
        public string GetWhoIsYourDaddy()
        {
            return "Kenny D";
        }

        [HttpGet]
        [Route("WhoIsYourDaddyCodingClass")]
        public DaddyClass GetWhoIsYourDaddyCodingClass()
        {
            DaddyClass d = new DaddyClass("Ken");
            d.LastName = "Dudley";
            d.TodaysDate = DateTime.Now;
            return d;
        }

        // GET: api/<DaddyAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DaddyAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DaddyAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DaddyAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DaddyAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

public class DaddyClass
{
    // TYPE ctor tab to get a default constructor
    public DaddyClass(string? firstname)
    {
            this.Firstname = firstname; 
    }

    // type prop tab to get these
    public string? Firstname { get; set; }
    public string? LastName { get; set; }
    public DateTime TodaysDate { get; set; } = DateTime.Now; // this is a default

    public override string ToString()
    {
        return this.Firstname + " " + this.LastName; // string representation of the class 
    }
}
