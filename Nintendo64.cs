using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek
{
    public class Nintendo64 : ControllCenter
    {
        private GameLibary GameLibary { get; set; }
        public string ConsoleTitle { get; set; }

        private Random random = new Random();
        public Nintendo64() : base("Nintendo64")
        {
            GameLibary = new GameLibary();
            ConsoleTitle = "Nintendo64";
        }


    }
}
