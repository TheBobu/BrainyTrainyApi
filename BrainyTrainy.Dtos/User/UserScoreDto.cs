using System;

namespace BrainyTrainy.Dtos.User
{
    public class UserScoreDto
    {
        public string FullName { get; set; }
        public int Score { get; set; }
        public TimeSpan TimeCompleted { get; set; }
    }
}