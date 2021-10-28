using BrainyTrainy.Dtos.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyTrainy.Dtos.Game
{
    public class LeaderboardDto
    {
        public string Game { get; set; }
        public List<UserScoreDto> UserScores { get; set; }
    }
}
