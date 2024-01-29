using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek
{
    public class Gamecube : IgameInterface
    {
        private GameLibary GameLibary { get; set; }
        public string ConsoleTitle { get; set; }

        private Random random = new Random();

        public Gamecube()
        {
            GameLibary = new GameLibary();
            ConsoleTitle = "Gamecube";
        }
        public void AddGame()
        {
            Console.WriteLine("Write name of the game you want added too your Libary");
            var game = Console.ReadLine();
            if (game != null)
            {
                GameLibary.GameList.Add(new Game(game, ConsoleTitle));
                Console.WriteLine($"you added -{game} -Console: {ConsoleTitle} to your libarary");
            }
        }

        public void RandomGame()
        {
            var randomGameNumber = random.Next(GameLibary.GameList.Count);
            var randomgame = GameLibary.GameList[randomGameNumber];
            Console.WriteLine($"Random -Game: {randomgame.GameTitle}  -Console {randomgame.ConsoleTitle}");
        }

        public void RemoveGame()
        {
            Console.WriteLine("Write game name you want to remove");
            var removeInput = Console.ReadLine();
            var game = GameLibary.GameList.Find(x => x.GameTitle == removeInput);
        }

        public void ShowAllGames()
        {
        foreach(var game in GameLibary.GameList)
            {
                Console.WriteLine($"-{game.GameTitle}  -Console:{ConsoleTitle}");
            }
        }
    }
}
