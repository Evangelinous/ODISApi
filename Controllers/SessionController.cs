using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using ODISApi.Models;
using ODISApi.Services;

namespace ODISApi.Controllers
{
    [ApiController]
    [Route("api/dms")]
    [AllowAnonymous]
    public class SessionController : ControllerBase
    {
        private readonly ILogger<SessionController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly ISessionService _sessionService;

        public SessionController(ILogger<SessionController> logger,
                                 IConfiguration configuration,
                                 IUserService userService,
                                 ISessionService sessionService)
        {
            _logger = logger;
            _configuration = configuration;
            _userService = userService;
            _sessionService = sessionService;
        }

        /// <summary>
        /// Authenticates the user and returns a JWT token if the credentials are valid.
        /// </summary>
        /// <param name="loginModel">The login model containing the username and password.</param>
        /// <returns>An IActionResult containing the JWT token if authentication is successful.</returns>
        /// <response code="200">Returns the JWT token.</response>
        /// <response code="401">If the credentials are invalid.</response>
        [HttpPost("token")]
        [ProducesResponseType(typeof(LoginResponseBaseModel<string>), 200)]
        [ProducesResponseType(401)]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            var user = _userService.ValidateUser(loginModel.Username, loginModel.Password);

            if (user == null)
            {
                _logger.LogWarning("Invalid login attempt for user {Username}", loginModel.Username);
                return Unauthorized(new { message = "Invalid credentials" });
            }

            var token = _sessionService.GenerateJwtToken(user.UserName, user.Roles);

            var response = new LoginResponseBaseModel<string>(token);

            _logger.LogInformation("User {Username} successfully logged in", user.UserName);

            return Ok(response);
        }
    }
}
