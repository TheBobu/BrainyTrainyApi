using BrainyTrainy.Dtos.Game;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        }
    }
}
