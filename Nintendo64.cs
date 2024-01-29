using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek
{
    public class Nintendo64 : IgameInterface
    {
        private GameLibary GameLibary { get; set; }
        public string ConsoleTitle { get; set; }

        private Random random = new Random();
        public Nintendo64() 
        {
            GameLibary = new GameLibary();
            ConsoleTitle = "Nintendo64";
        }


        public void AddGame()
        {
            Console.WriteLine("Write name of the game you want added too your Libary");
            var game = Console.ReadLine();
            if (game != null)
            {
                GameLibary.GameList.Add(new Game(game, ConsoleTitle));
                Console.WriteLine($"you added -Game:{game}  -Console: {ConsoleTitle} to your libarary");
            }
        }

        public void RandomGame()
        {
            var randomGameNumber = random.Next(GameLibary.GameList.Count);
            var randomgame = GameLibary.GameList[randomGameNumber];
            Console.WriteLine($"random -Game: {randomgame.GameTitle}  -Console: {randomgame.ConsoleTitle}");
        }

        public void RemoveGame()
        {
            Console.WriteLine("Write game name you want to remove");
            var removeInput = Console.ReadLine();
            var game = GameLibary.GameList.Find(x => x.GameTitle == removeInput);
        }

        public void ShowAllGames()
        {
            foreach (var game in GameLibary.GameList)
            {
                Console.WriteLine($"-Game: {game.GameTitle}  -Console: {game.ConsoleTitle}");
            }
        }
    }
}
