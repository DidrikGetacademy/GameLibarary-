using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpillBibliotek
{
    public class ControllCenter : IgameInterface
    {
        public string ConsoleTitle { get; set; }
        private GameLibary GameLibary { get; set; }

    

    
        public ControllCenter(string consoletitle)
        {
            GameLibary = new GameLibary( );
            ConsoleTitle = consoletitle;


        }
        public void AddGame()
        {
            Console.WriteLine("Write name of the game you want added too your Libary");
            var game = Console.ReadLine();
            if (game != null)
            {
                GameLibary.GameList.Add(new Game(game, ConsoleTitle));
                Console.WriteLine($"you added -{game}  Console-{ConsoleTitle} too your libarary");
            }
        }

        public void ShowAllGames()
        {
            foreach (var game in GameLibary.GameList)
            {
                Console.WriteLine($"-Game: {game.GameTitle}  Controller: {game.ConsoleTitle}");
            }
        }

        public void RandomGame()
        {
            Random rand = new Random();
            var random = rand.Next(0, GameLibary.GameList.Count);
            var randomGame = GameLibary.GameList[random];
            Console.WriteLine($"-Game : {randomGame.GameTitle} Console: {randomGame.GameTitle}");
        }

        public void RemoveGame()
        {
            Console.WriteLine("Write game name you want to remove");
            var removeInput = Console.ReadLine();
            var game = GameLibary.GameList.Find(x => x.GameTitle == removeInput);
            if (removeInput != null)
            {
                GameLibary.GameList.Remove(game);
            }
            else
            {
                Console.WriteLine("You dont have this game in libary");
            }
        }
    }
}
