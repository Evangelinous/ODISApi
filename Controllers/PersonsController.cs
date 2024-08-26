using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using ODISApi.Models;
using ODISApi.Responses;
using ODISApi.Services;
using Microsoft.AspNetCore.Authorization;

namespace ODISApi.Controllers
{
    [ApiController]
    [Route("api/dms/persons")]
    [Authorize]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly ILogger<PersonsController> _logger;

        public PersonsController(IPersonService personService, ILogger<PersonsController> logger)
        {
            _personService = personService;
            _logger = logger;
        }

        /// <summary>
        /// Get a person by their ID.
        /// </summary>
        /// <param name="personId">The ID of the person to retrieve.</param>
        /// <returns>The person details.</returns>
        [HttpGet("{personId}")]
        [ProducesResponseType(typeof(ResponseBaseModel<PersonDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetPerson(string personId)
        {
            var person = await _personService.GetPersonAsync(personId);
            return Ok(new ResponseBaseModel<PersonDto> { Payload = person });
        }

        /// <summary>
        /// Create or update a person.
        /// </summary>
        /// <param name="person">The person details.</param>
        /// <returns>The created or updated person.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ResponseBaseModel<PersonDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PostPerson([FromBody] PersonDto person)
        {
            var updatedPerson = await _personService.CreateOrUpdatePersonAsync(person);
            return Ok(new ResponseBaseModel<PersonDto> { Payload = updatedPerson });
        }
    }
}
