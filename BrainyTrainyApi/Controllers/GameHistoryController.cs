using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Dtos.Game;
using Microsoft.AspNetCore.Mvc;

namespace BrainyTrainy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameHistoryController : ControllerBase
    {
        private readonly IGameHistoryBusinessLogic gameHistoryBusinessLogic;

        public GameHistoryController(IGameHistoryBusinessLogic gameHistoryBusinessLogic)
        {
            this.gameHistoryBusinessLogic = gameHistoryBusinessLogic;
        }

        [HttpPost]
        public IActionResult AddGameHistory(GameHistoryDto gameHistoryDto)
        {
            IActionResult result = StatusCode(500);
            var succeded = gameHistoryBusinessLogic.AddGameHistory(gameHistoryDto);
            if (succeded)
            {
                result = Ok();
            }
            return result;
        }

        [HttpGet("{id}")]
        public IActionResult GetGameHistory(int id)
        {
            IActionResult result = StatusCode(404);
            var game = gameHistoryBusinessLogic.GetGameHistory(id);
            if (game != null)
            {
                result = Ok(game);
            }
            return result;
        }
        [HttpGet("All/{userId}")]
        public IActionResult GetGameHistories(int userId)
        {
            IActionResult result = StatusCode(404);
            var game = gameHistoryBusinessLogic.GetGameHistories(userId);
            if (game != null)
            {
                result = Ok(game);
            }
            return result;
        }
    }
}