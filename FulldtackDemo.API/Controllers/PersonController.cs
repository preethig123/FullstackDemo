using FullstackDemo.API.Models;
using FullstackDemo.API.Services;

using FullstackDemo.API.Models;
using FullstackDemo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullstackDemo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("Invalid data.");
            }

            var addedPerson = _personService.AddPerson(person);
            return Ok(addedPerson);
        }
    }
}

