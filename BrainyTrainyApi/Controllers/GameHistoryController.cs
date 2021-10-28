using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Dtos.Game;
using Microsoft.AspNetCore.Mvc;

namespace BrainyTrainy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameHistoryController : ControllerBase
    {
        public GameHistoryController(IGameHistoryBusinessLogic gameHistoryBusinessLogic)
        {
        }

        [HttpPost]
        public IActionResult AddGameHistory(GameHistoryDto gameHistoryDto)
        {
            IActionResult result = StatusCode(500);
            return result;
        }
    }
}