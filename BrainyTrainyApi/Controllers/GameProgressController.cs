using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Dtos.Game;
using Microsoft.AspNetCore.Mvc;

namespace BrainyTrainy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameProgressController : Controller
    {
        private readonly IGameProgressBusinessLogic gameProgressBusinessLogic;

        public GameProgressController(IGameProgressBusinessLogic gameProgressBusinessLogic)
        {
            this.gameProgressBusinessLogic = gameProgressBusinessLogic;
        }

        [HttpGet("{id}")]
        public IActionResult GetGameProgress([FromRoute] int id)
        {
            IActionResult result = NotFound();

            return result;
        }

        [HttpPost("Add Progress")]
        public IActionResult AddGameProgress([FromBody] GameProgressDto gameProgressDto)
        {
            IActionResult response = StatusCode(500);
            bool result = gameProgressBusinessLogic.AddGameProgress(gameProgressDto);

            if (result)
            {
                response = Ok();
            }

            return response;
        }
    }
}