using BrainyTrainy.Dtos.Game;
using BrainyTrainy.Dtos.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyTrainy.BusinessLogic.Interfaces
{
    public interface IGameHistoryBusinessLogic
    {
        bool AddGameHistory(GameHistoryDto gameHistoryDto);
        GameHistoryDto GetGameHistory(int id);
        List<GameHistoryDto> GetGameHistories(int userId);
        List<GameHistoryLightDto> GetGameHistoriesLight(int userId);
        List<LeaderboardDto> GetBestScores();
    }
}
