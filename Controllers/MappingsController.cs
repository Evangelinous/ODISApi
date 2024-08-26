using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using ODISApi.Models;
using ODISApi.Responses;
using ODISApi.Services;
using Microsoft.AspNetCore.Authorization;

namespace ODISApi.Controllers
{
    [ApiController]
    [Route("api/dms/mappings")]
    [Authorize]
    public class MappingsController : ControllerBase
    {
        private readonly ILogger<MappingsController> _logger;

        public MappingsController(ILogger<MappingsController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get all target values for selected mapping field type.
        /// </summary>
        /// <param name="mappingType">The mapping type.</param>
        /// <returns>List of mapping values.</returns>
        [HttpGet("{mappingType}/values")]
        [ProducesResponseType(typeof(ResponseBaseModel<List<MappingDto>>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetMapping(string mappingType)
        {
            // Mocked response for now
            var mappings = new List<MappingDto>
            {
                new MappingDto { Code = "001", Name = "Sample Mapping" },
                new MappingDto { Code = "002", Name = "Another Mapping" }
            };

            return Ok(new ResponseBaseModel<List<MappingDto>> { Payload = mappings });
        }
    }
}
