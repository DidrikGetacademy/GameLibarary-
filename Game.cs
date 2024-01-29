using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek
{
    public class Game 
    {
        public string GameTitle { get; set; }

        public string ConsoleTitle { get; set; }

        public Game(string gameTitle,string  consoleTitle)
        {
            GameTitle = gameTitle;
            ConsoleTitle = consoleTitle;
        }

      
    }
}
