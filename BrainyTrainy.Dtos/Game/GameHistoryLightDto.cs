using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyTrainy.Dtos.Game
{
    public class GameHistoryLightDto
    {
        public DateTime AddedDate { get; set; }
        public int Score { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public string GameName { get; set; }
    }
}
