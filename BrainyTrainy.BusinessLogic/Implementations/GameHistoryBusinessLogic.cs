using AutoMapper;
using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Domain.Interfaces;
using BrainyTrainy.Dtos.Game;
using System;
using System.Collections.Generic;
using System.Text;

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
                var game = unitOfWork.GameRepository.Get(gameHistoryDto.GameId);
                if (game == null)
                {
                    unitOfWork.GameRepository.Add(gameHistoryDto.Game)
                }
                unitOfWork.GameHistoryRepository.Add();
                unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
