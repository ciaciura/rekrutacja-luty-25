using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rekrutacja_luty_25.commons.Models;
using rekrutacja_luty_25.Data;
using rekrutacja_luty_25.commons.Models.DTO;

namespace rekrutacja_luty_25.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorityController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public AuthorityController(DatabaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Pobiera obiekt z bazy danych
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Authority))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Authority> Get([FromQuery] int id)
        {
            var authority = _context.Authorities.Find(id);
            if (authority == null)
            {
                return NotFound();
            }
            return Ok(authority);
        }

        // Napisz endpoint updatująccy obiekt w bazie danych
        [HttpPost]
        public ActionResult Update([FromBody] AuthorityDTO authority)
        {
            throw new  NotImplementedException();
        } 

    }
}
