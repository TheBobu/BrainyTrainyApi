using System;
using System.Collections.Generic;
using System.Text;
using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Dtos.Game;

namespace BrainyTrainy.BusinessLogic.Interfaces
{
    public interface IGameProgressBusinessLogic
    {
        GameProgress GetGameProgress(int id);
        bool AddGameProgress(GameProgressDto gameProgressDto);
    }
}
