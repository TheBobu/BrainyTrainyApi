using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace BrainyTrainy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserBusinessLogic userBusinessLogic;

        public UserController(IUserBusinessLogic userBusinessLogic)
        {
            this.userBusinessLogic = userBusinessLogic;
        }

        [HttpGet("{id}")]
        public IActionResult GetUserInfo([FromRoute]int id)
        {
            IActionResult result = NotFound();
            UserDto user = userBusinessLogic.GetUserInfo(id);
            if (user != null)
            {
                result = Ok(user);
            }
            return result;
        }
    }
}