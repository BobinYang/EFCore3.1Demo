using System.Text;

namespace Demo.Domain
{
    public class GamePlayer
    {
        public int PlayerId { get; set; }
        public int GameId { get; set; }

        public Game Game { get; set; }
        public Player Player { get; set; }
    }
}
