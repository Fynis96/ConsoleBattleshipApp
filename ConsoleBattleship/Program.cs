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

        private static string AskForName()
        {
            throw new NotImplementedException();
        }

    }
}