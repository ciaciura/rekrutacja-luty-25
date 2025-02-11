using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace rekrutacja_luty_25.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorityController : ControllerBase
    {
        // GET: api/Authority
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET: api/Authority/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Authority
        [HttpPost]
        public IActionResult Post([FromBody] object value)
        {
            return Ok();
        }

        // PUT: api/Authority/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] object value)
        {
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
