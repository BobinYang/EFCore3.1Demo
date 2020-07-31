using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain
{

    public class Player //队员
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }


        public Player()
        {
            //初始化，避免出现空指针异常
            GamePlayers = new List<GamePlayer>();
        }
        public List<GamePlayer> GamePlayers { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
