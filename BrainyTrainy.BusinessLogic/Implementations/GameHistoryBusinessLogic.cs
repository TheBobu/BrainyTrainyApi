using AutoMapper;
using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Interfaces;
using BrainyTrainy.Dtos.Game;
using System;
using System.Collections.Generic;

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

        public List<GameHistoryDto> GetGameHistories(int userId)
        {
            throw new NotImplementedException();
        }

        public GameHistoryDto GetGameHistory(int id)
        {
            throw new NotImplementedException();
        }
    }
}