using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek
{
    public interface IgameInterface 
    {
     
        public string ConsoleTitle { get; set; }


         void AddGame();

         void ShowAllGames();

         void RandomGame();

         void RemoveGame();
    }
}
