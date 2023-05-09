using BattleshipClassLibrary.Models;

namespace ConsoleBattleship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("created by Christian Foster\n");
        }
        private static void GetShipPlacement()
        {
            throw new NotImplementedException();
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

        private static PlayerInfoModel CreatePlayer()
        {
            PlayerInfoModel output = new PlayerInfoModel();

            //Ask the user for their name
            output.UsersName = AskForUsersName();
            //Load up the shot grid
            output.ShotGrid;
            //Ask the user for their 5 ship placements
            //Clear

            return output;
        }

    }
}