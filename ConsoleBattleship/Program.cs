using BattleshipClassLibrary;
using BattleshipClassLibrary.Models;

namespace ConsoleBattleship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            PlayerInfoModel player1 = CreatePlayer("Player 1");
            PlayerInfoModel player2 = CreatePlayer("Player 2");

            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("created by Christian Foster\n");
        }
        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.WriteLine($"Where would you like to place ship number {model.ShipLocations.Count + 1}");
                string location = Console.ReadLine();

                bool isValidLocation = GameLogic.PlaceShip(model, location);

                if(!isValidLocation)
                {
                    Console.WriteLine("That was not a valid location, Please try again.");
                }
            } while (model.ShipLocations.Count < 5);
        }

        private static void DisplayScore()
        {
            throw new NotImplementedException();
        }

        private static void PrintGrid()
        {
            throw new NotImplementedException();
        }

        private static string AskForUsersName()
        {
            Console.WriteLine("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}");

            //Ask the user for their name
            output.UsersName = AskForUsersName();
            
            //Load up the shot grid
            GameLogic.InitializeGrid(output);

            //Ask the user for their 5 ship placements
            PlaceShips(output);
            //Clear
            Console.Clear();

            return output;
        }

    }
}