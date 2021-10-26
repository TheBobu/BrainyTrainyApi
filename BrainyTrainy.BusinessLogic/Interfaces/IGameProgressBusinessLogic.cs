using System;
using System.Collections.Generic;
using System.Text;
using BrainyTrainy.Dtos.Game;

namespace BrainyTrainy.BusinessLogic.Interfaces
{
    public interface IGameProgressBusinessLogic
    {
        GameProgressDto GetGameProgress(int id);
        bool AddGameProgress(GameProgressDto gameProgressDto);
    }
}
