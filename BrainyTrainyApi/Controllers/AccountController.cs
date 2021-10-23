using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Dtos.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BrainyTrainyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private IUserBusinessLogic userBusinessLogic;

        public AccountController(IUserBusinessLogic userBusinessLogic)
        {
            this.userBusinessLogic = userBusinessLogic;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            IActionResult response = Unauthorized();
            var user = userBusinessLogic.AuthenticateUser(login);

            if (user != null)
            {
                response = Ok(user);
            }

            return response;
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public IActionResult Register([FromBody] UserDto userDto)
        {
            IActionResult response = StatusCode(500);
            bool result = userBusinessLogic.Register(userDto);

            if (result)
            {
                response = Ok();
            }

            return response;
        }
    }
}