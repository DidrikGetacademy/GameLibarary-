namespace SpillBibliotek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playstation2 = new Playstation2();
            var Gamecube = new Gamecube();
            var nintendo64 = new Nintendo64();
            IgameInterface currentConsole = playstation2;
            while (true)
            {
                Console.WriteLine("1. Add Game");
                Console.WriteLine("2. Show all games");
                Console.WriteLine("3. Random game");
                Console.WriteLine("4. Remove game");
                Console.WriteLine("5.Change Console");
                Console.WriteLine("6. exit program");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        currentConsole.AddGame();
                        break;

                    case "2":
                        currentConsole.ShowAllGames();
                        break;
                    
                    case "3":
                        currentConsole.RandomGame();
                        break;

                    case "4":
                        currentConsole.RemoveGame();
                        break;
                    case "5":
                      Console.WriteLine("1.Playstation2");
                      Console.WriteLine("2.GameCube");
                      Console.WriteLine("3.Nintendo64");
                        var Consolechoice = Console.ReadLine();
                        switch (Consolechoice)
                        {
                            case "1":
                                currentConsole = playstation2;
                                break;

                            case "2":
                                currentConsole = Gamecube;
                                break;

                                case "3":
                                currentConsole = nintendo64;
                                break;
                        }
                        break;

                        case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                {
                
                }
            }

        }
    }
}

