using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek
{
    public class GameLibary 
    {
        public List<Game> GameList { get;  private set; }

        public GameLibary() 
        {
          GameList = new List<Game>();
        }
    }
}
