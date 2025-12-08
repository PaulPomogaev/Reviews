using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Review.Domain.Models;
using Review.Domain.Services;
using ReviewsWebApplication.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ReviewsWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> _logger;
        private readonly LoginService _loginService;
        private readonly JwtSettings _jwtSettings;

        public AuthenticationController(ILogger<AuthenticationController> logger, LoginService loginService, IOptions<JwtSettings> jwtOptions)
        {
            _logger = logger;
            _loginService = loginService;
            _jwtSettings = jwtOptions.Value;
        }


        [HttpPost("login")]
        public IActionResult Login([FromBody] Login user)
        {
            if (user is null)
            {
                return BadRequest("Invalid user request!");
            }

            var result = _loginService.CheckLogin(user);
            if (result)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));

                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(issuer: _jwtSettings.ValidIssuer, audience: _jwtSettings.ValidAudience, claims: new List<Claim>(), expires: DateTime.Now.AddMinutes(6), signingCredentials: signinCredentials);

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                return Ok(new JWTTokenResponse { Token = tokenString });
            }
            return Unauthorized();
        }
    }
}
