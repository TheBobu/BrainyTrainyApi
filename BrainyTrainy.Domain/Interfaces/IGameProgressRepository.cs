using System;
using System.Collections.Generic;
using System.Text;
using BrainyTrainy.Domain.Entities;

namespace BrainyTrainy.Domain.Interfaces
{
    public interface IGameProgressRepository: IBaseRepository<GameProgress, int>
    {
        IGameProgressRepository GetGameProgressById(int id);
    }
}
