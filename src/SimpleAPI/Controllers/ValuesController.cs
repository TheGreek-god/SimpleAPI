using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return new string[] { "full-name", "nickname" };
        }

        // GET api/values/full-name
        [HttpGet("full-name")]
        public ActionResult<string> GetFullName()
        {
            return "Okeke Tochukwu Finbarr";
        }

        // GET api/values/nickname
        [HttpGet("nickname")]
        public ActionResult<string> GetNickname()
        {
            return "The Greek-god";
        }

        // GET api/values/{id}
        [HttpGet("{id:int}")]
        public ActionResult<string> GetById(int id)
        {
            return $"You requested ID: {id}";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }  
} 