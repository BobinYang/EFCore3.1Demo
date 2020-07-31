using System;
using System.Collections.Generic;

namespace Demo.Domain
{
    public class Game
    {
        public Game()
        {
            GamePlayers = new List<GamePlayer>();
        }
        public List<GamePlayer> GamePlayers { get; set; }

        public int Id { get; set; }
        public int Round { get; set; }
        public DateTime? StartTime { get; set; }

    }
}
