using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Dtos.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BrainyTrainyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private IUserBusinessLogic userBusinessLogic;

        public LoginController(IUserBusinessLogic userBusinessLogic)
        {
            this.userBusinessLogic = userBusinessLogic;
        }

        [AllowAnonymous]
        [HttpPost]
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
    }
}