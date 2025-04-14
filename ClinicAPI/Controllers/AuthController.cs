using ClinicAPI.Models.Domain;
using ClinicAPI.Models.DTO;
using ClinicAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<UserApplication> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<UserApplication> userManager,ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            var user = new UserApplication
            {
                Email = registerRequestDto.Email,
                UserName = registerRequestDto.Name,
                PhoneNumber = registerRequestDto.Phone
            };
            var identity = await userManager.CreateAsync(user, registerRequestDto.Password);
            if (identity.Succeeded)
            {
                //identity = await userManager.AddToRoleAsync(user, "Patient");

                identity = await userManager.AddToRoleAsync(user, "Admin");
                if (identity.Succeeded)
                {
                    return Ok("Successful Register");
                }
            }
            return BadRequest("something wrong");

        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var user = await userManager.FindByEmailAsync(loginRequestDto.Email);
            if (user != null)
            {
                var checkPassword = await userManager.CheckPasswordAsync(user, loginRequestDto.Password);
                if (checkPassword)
                {
                    var roles = await userManager.GetRolesAsync(user);

                    var userRole = roles.FirstOrDefault() ?? "NoRoleAssigned"; 
                    if (userRole.Contains("User")) userRole = "Patient";
                    var token = tokenRepository.CreateToken(user, roles.ToList());

                    var response = new LoginResponseDto
                    {
                        Id = user.Id,
                        Name = user.UserName,
                        Token = token,
                        Email = user.Email,
                        Role = userRole, 
                        isLoggedIN = true
                    };

                    return Ok(response);
                }
            }

            return BadRequest("Email or Password not correct");
        }

    }

}
