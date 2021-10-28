using BrainyTrainy.Dtos.Game;
using System.Collections.Generic;

namespace BrainyTrainy.BusinessLogic.Interfaces
{
    public interface IGameHistoryBusinessLogic
    {
        bool AddGameHistory(GameHistoryDto gameHistoryDto);

        List<GameHistoryLightDto> GetGameHistoriesLight(int userId);

        List<LeaderboardDto> GetBestScores();
    }
}