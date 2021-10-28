using AutoMapper;
using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Domain.Interfaces;
using BrainyTrainy.Dtos.Game;
using System;

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
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}