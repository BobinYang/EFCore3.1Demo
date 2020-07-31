using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain
{
    public class Club //足球队
    {
        public Club()
        {
            Players = new List<Player>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime DateOfEstablishment { get; set; }
        public string History { get; set; }
        public League League { get; set; }//导航属性
        public List<Player> Players { get; set; }//导航属性
    }
}
