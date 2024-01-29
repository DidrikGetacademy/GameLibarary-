using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek
{
    public class Gamecube : ControllCenter
    {
        private GameLibary GameLibary { get; set; }
        public string ConsoleTitle { get; set; }

  

        public Gamecube() : base("Gamecube")
        {
            GameLibary = new GameLibary();
            ConsoleTitle = "Gamecube";
        }
    }
}
