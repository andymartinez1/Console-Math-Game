using Math_Game.Models;

namespace Math_Game;

internal class MainMenu
{
    GameEngine gameEngine = new GameEngine();

    internal void ShowMenu(string name, DateTime date)
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Hello {name}! It's {date.DayOfWeek}.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.WriteLine("\n");

        var isGameOn = true;

        do
        {
            Console.Clear();
            Console.WriteLine(@"What game would you like to play? Choose from the options below:
            V - View Previous Games
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division
            E - Exit");
            Console.WriteLine("----------------------------------------------------");

            var gameSelected = Console.ReadLine();

            switch (gameSelected.Trim().ToLower())
            {
                case "v":
                    Helpers.PrintGames();
                    break;
                case "a":
                    gameEngine.AdditionGame("Addition Game");
                    break;
                case "s":
                    gameEngine.SubtractionGame("Subtraction Game");
                    break;
                case "m":
                    gameEngine.MultiplicationGame("Multiplication Game");
                    break;
                case "d":
                    gameEngine.DivisionGame("Division Game");
                    break;
                case "e":
                    Console.WriteLine("Goodbye");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("You did not enter a valid option");
                    break;
            }
        } while (isGameOn);
    }

    internal Difficulty DifficultyMenu()
    {
        Console.WriteLine(@"Please choose a difficulty from the choices below:
            B - Beginner
            I - Intermediate
            A - Advanced");
        Console.WriteLine("----------------------------------------------------");

        var difficulty = Console.ReadLine();

        switch (difficulty.Trim().ToLower())
        {
            case "b":
                return Difficulty.Beginner;
            case "i":
                return Difficulty.Intermediate;
            case "a":
                return Difficulty.Advanced;
            default:
                return 0;
        }
    }
}