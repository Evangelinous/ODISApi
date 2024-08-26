using Microsoft.AspNetCore.Mvc;
using ODISApi.Models;
using ODISApi.Responses;
using ODISApi.Services;
using Microsoft.AspNetCore.Authorization;

namespace ODISApi.Controllers
{
    [ApiController]
    [Route("api/dms/addresses")]
    [Authorize]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private readonly ILogger<AddressesController> _logger;

        public AddressesController(IAddressService addressService, ILogger<AddressesController> logger)
        {
            _addressService = addressService;
            _logger = logger;
        }

        /// <summary>
        /// Get an address by its ID.
        /// </summary>
        /// <param name="addressId">The ID of the address to retrieve.</param>
        /// <returns>The address details.</returns>
        [HttpGet("{addressId}")]
        [ProducesResponseType(typeof(ResponseBaseModel<AddressDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAddress(string addressId)
        {
            var address = await _addressService.GetAddressAsync(addressId);
            return Ok(new ResponseBaseModel<AddressDto> { Payload = address });
        }

        /// <summary>
        /// Create or update an address.
        /// </summary>
        /// <param name="address">The address details.</param>
        /// <returns>The created or updated address.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ResponseBaseModel<AddressDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PostAddress([FromBody] AddressDto address)
        {
            var updatedAddress = await _addressService.CreateOrUpdateAddressAsync(address);
            return Ok(new ResponseBaseModel<AddressDto> { Payload = updatedAddress });
        }
    }
}
