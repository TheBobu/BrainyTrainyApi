using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Domain.Entities;
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
            return true;
           //return unitOfWork.GameProgressRepository.Add(gameProgressDto)
        }

        public GameProgress GetGameProgress(int id)
        {
            return unitOfWork.GameProgressRepository.Get(id).Result;
        }
    }
}
