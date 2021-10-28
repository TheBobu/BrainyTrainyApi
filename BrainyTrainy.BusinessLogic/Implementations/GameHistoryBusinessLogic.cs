using AutoMapper;
using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Enums;
using BrainyTrainy.Domain.Interfaces;
using BrainyTrainy.Dtos.Game;
using BrainyTrainy.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BrainyTrainy.BusinessLogic.Implementations
{
    public class GameHistoryBusinessLogic : IGameHistoryBusinessLogic
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GameHistoryBusinessLogic(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public bool AddGameHistory(GameHistoryDto gameHistoryDto)
        {
            try
            {
                var gameHistory = mapper.Map<GameHistory>(gameHistoryDto);
                gameHistory.TimeCompleted = new TimeSpan(0, gameHistoryDto.Minutes, gameHistoryDto.Seconds);
                unitOfWork.GameHistoryRepository.Add(gameHistory);
                unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<LeaderboardDto> GetBestScores()
        {
            var gameHistories = unitOfWork.GameHistoryRepository.GetAll().Result;
            foreach (var record in gameHistories)
            {
                record.User = unitOfWork.UserRepository.Get(record.UserId).Result;
                record.User.Info = unitOfWork.PersonInfoRepository.Get(record.User.InfoId).Result;
            }

            var scoresByUser = gameHistories
                .GroupBy(x => x.GameId)
                .Select(x => new
                {
                    Game = Enum.GetName(typeof(GameType), x.Key),
                    Records = x.Select(x => x)
                })
                .ToList();

            var scores = new List<LeaderboardDto>();
            foreach (var item in scoresByUser)
            {
                var userScores = item.Records.GroupBy(x => x.User.Info.FullName).Select(x => new UserScoreDto
                {
                    FullName = x.Key,
                    Score = x.Select(x => x.Score).Max(),
                    TimeCompleted = x.Select(y => new
                    {
                        Score = y.Score,
                        Time = y.TimeCompleted
                    }).OrderByDescending(z => z.Score).FirstOrDefault().Time
                });
                scores.Add(new LeaderboardDto
                {
                    Game = item.Game,
                    UserScores = userScores.ToList()
                });
            }

            return scores;
        }

        public List<GameHistoryDto> GetGameHistories(int userId)
        {
            throw new NotImplementedException();
        }

        public List<GameHistoryLightDto> GetGameHistoriesLight(int userId)
        {
            var gameHistories = mapper.Map<List<GameHistoryLightDto>>(
                unitOfWork.GameHistoryRepository.GetGameHistories(userId)
                .OrderBy(x => x.AddedDate)
                .ToList()
                );

            return gameHistories;
        }

        public GameHistoryDto GetGameHistory(int id)
        {
            throw new NotImplementedException();
        }
    }
}