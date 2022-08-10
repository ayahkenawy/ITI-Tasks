using Auth.Data;
using Auth.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<Employee> _userManager;

        public UserController(IConfiguration configuration, UserManager<Employee> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }
        //static login
        [HttpPost]
        public ActionResult Login(LoginDTO credentials)
        {
            if (credentials.UserName != "admin" || credentials.Password != "pass")
            {
                return Unauthorized();
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.GivenName, "Aya Ahmed"),
                new Claim("Nationality" ,"Egyptian")
            };
            var secretKey = _configuration.GetValue<string>("SecretKey");
            var keyInBytes = Encoding.ASCII.GetBytes(secretKey);
            var key = new SymmetricSecurityKey(keyInBytes);
            var methodAndKey = new SigningCredentials(key,
                SecurityAlgorithms.HmacSha256);
            var myJwt = new JwtSecurityToken(
                  claims: claims,
                  signingCredentials: methodAndKey,
                  expires: DateTime.Now.AddMinutes(15)
                  );
            var token = new JwtSecurityTokenHandler();
            return Ok(token.WriteToken(myJwt))
;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(RegisterDTO registerDTO)
        {
            var employee = new Employee
            {
                UserName = registerDTO.UserName,
                Department = registerDTO.Department,
            };
            var result = await _userManager.CreateAsync(employee, registerDTO.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            await _userManager.AddClaimsAsync(employee, new List<Claim>
            {
                  new Claim(ClaimTypes.NameIdentifier,employee.Id),
                  new Claim(ClaimTypes.GivenName, "Aya Ahmed"),
                  new Claim("Nationality" ,registerDTO.Nationality),
                  new Claim(ClaimTypes.Role ,registerDTO.Role),
            });
            return StatusCode(StatusCodes.Status201Created,"User Created");
        }
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> CleanLogin(LoginDTO loginDTO)
        {
            var requiredUser = await _userManager.FindByNameAsync(loginDTO.UserName);
            if (requiredUser is null)
            {
                return BadRequest();
            }
            if (_userManager.IsLockedOutAsync(requiredUser).Result)
            {
                return BadRequest();
            }
            var isAuth = await _userManager.CheckPasswordAsync(requiredUser, loginDTO.Password);
            if (!isAuth)
            {
                return Unauthorized();
            }
            var claims = await _userManager.GetClaimsAsync(requiredUser);
            var secretKey = _configuration.GetValue<string>("SecretKey");
            var keyInBytes = Encoding.ASCII.GetBytes(secretKey);
            var key = new SymmetricSecurityKey(keyInBytes);
            var methodAndKey = new SigningCredentials(key,
                SecurityAlgorithms.HmacSha256);
            var myJwt = new JwtSecurityToken(
                  claims: claims,
                  signingCredentials: methodAndKey,
                  expires: DateTime.Now.AddMinutes(15)
                  );
            var token = new JwtSecurityTokenHandler();
            return Ok(new TokenDTO
            {
                Token = token.WriteToken(myJwt),
                Exp = DateTime.Now.AddMinutes(15)
            });
        }
    }
}
