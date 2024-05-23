using E_CommerceProject.DAL.Data.Models.Enums;
using E_CommerceProject.DAL;
using E_CommerceProject.DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Dtos.User;

namespace E_CommerceProject.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<User> _userManager;

        public UsersController(IConfiguration configuration, UserManager<User> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }


        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<TokenDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null)
            {
                return Unauthorized();
            }
            bool isAuthenticated = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (!isAuthenticated)
            {
                return Unauthorized();

            }



            var Userclaims = await _userManager.GetClaimsAsync(user);

            var KeyFromConfig = _configuration.GetValue<string>(Constants.AppSettings.SecretKey)!;
            var KeyInBytes = Encoding.ASCII.GetBytes(KeyFromConfig);
            var Key = new SymmetricSecurityKey(KeyInBytes);

            // Create signing credentials
            var signingCredentials = new SigningCredentials(Key,
                SecurityAlgorithms.HmacSha256Signature);

            // Set token expiration
            var expiryDateTime = DateTime.Now.AddDays(2);

            // Generate JWT token
            var jwt = new JwtSecurityToken(
               claims: Userclaims, signingCredentials: signingCredentials,
               expires: expiryDateTime
               );
            
            // Serialize JWT token to string
            var jwtAsString = new JwtSecurityTokenHandler().WriteToken(jwt);
            
            // Return token DTO
            return new TokenDto(jwtAsString, expiryDateTime);
        }
        
        
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(RegisterDto registerDto)
        {
            var user = new User
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                Address = registerDto.Address,
                PhoneNumber = registerDto.PhoneNumber,
                Age = registerDto.Age,
                //UserRole =registerDto.UserRole  //new 
            };
            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            //if (!string.IsNullOrEmpty(registerDto.UserRole))
            //{
            //    var roleResult = await _userManager.AddToRoleAsync(user, registerDto.UserRole);  //error 
            //    if (!roleResult.Succeeded)
            //    {
            //        return BadRequest(roleResult.Errors);
            //    }
            //}
            var claims = new List<Claim>
            {
                new (ClaimTypes.NameIdentifier , user.Id.ToString()),
                new (ClaimTypes.Name , user.UserName),
                new (ClaimTypes.Email, user.Email),
               // new (ClaimTypes.Role, user.UserRole), //new 
                new ("PhoneNumber", user.PhoneNumber),
                new ("Address", user.Address),
            };
            await _userManager.AddClaimsAsync(user, claims);
            return Ok("Registered Successflly, Please Login Now");
        }
    }
}
