using BrainyTrainy.Dtos.Game;
using Microsoft.AspNetCore.Mvc;
using BrainyTrainy.BusinessLogic.Interfaces;

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
        public IActionResult GetGameProgress([FromRoute]int id)
        {
            IActionResult result = NotFound();
            GameProgressDto gameProgress = gameProgressBusinessLogic.GetGameProgress(id);
            if (gameProgress != null)
            {
                result = Ok(gameProgress);
            }
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
