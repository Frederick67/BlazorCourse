using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    { 
        private readonly ILogger<AuthController> logger;
        private readonly IMapper mapper;
        private readonly UserManager<ApiUser> userManager;
 
        public AuthController(ILogger<AuthController> logger, IMapper mapper, UserManager<ApiUser> userManager)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("register")]

        public async Task<IActionResult> Register(UserDto userDto)
        {
            var user = mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.Email;

            var result = await userManager.CreateAsync(user, userDto.Password);

            if(result.Succeeded == false)
            {
                return BadRequest(result.Errors);
            }


            await userManager.AddToRoleAsync(user, "User");

            return Accepted();




        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginUserDto userDto)
        {
            var user = await userManager.FindByEmailAsync(userDto.Email);
            var passwordValid = await userManager.CheckPasswordAsync(user, userDto.Password);

            if (user==null || passwordValid == false)
            {
                return NotFound();
            }

            return Accepted();
        }
    }
}
