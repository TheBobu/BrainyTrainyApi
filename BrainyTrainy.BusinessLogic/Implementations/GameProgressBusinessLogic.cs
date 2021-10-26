using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Domain.Interfaces;
using BrainyTrainy.Dtos.Game;

namespace BrainyTrainy.BusinessLogic.Implementations
{
    public class GameProgressBusinessLogic : IGameProgressBusinessLogic
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;
        public GameProgressBusinessLogic(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public bool AddGameProgress(GameProgressDto gameProgressDto)
        {
            throw new NotImplementedException();
        }

        public GameProgressDto GetGameProgress(int id)
        {
            var gameProgress = unitOfWork.GameRepository.Get(id).Result;
            //gameProgress.GameId = unitOfWork.GameProgressRepository.GetGameProgressById(id)

            if (gameProgress != null)
            {
                return mapper.Map<GameProgressDto>(gameProgress);
            }
            return null;
        }
    }
}
