using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek
{
    public class Playstation2 : ControllCenter
    {
        private GameLibary GameLibary { get; set; }

        public string ConsoleTitle { get; set; }


        public Playstation2() : base("playstation2")
        {
            ConsoleTitle = "Playstation2";
            GameLibary = new GameLibary();
        }
     
    }
}






