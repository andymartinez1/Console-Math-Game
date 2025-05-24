using System.Text.RegularExpressions;
using Math_Game.Models;

namespace Math_Game;

internal class MainMenu
{
    private readonly GameEngine gameEngine = new();

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
            var difficulty = DifficultyLevel.Beginner;

            switch (gameSelected.Trim().ToLower())
            {
                case "v":
                    Helpers.PrintGames();
                    break;
                case "a":
                    difficulty = DifficultyMenu();
                    gameEngine.AdditionGame("Addition Game", difficulty);
                    break;
                case "s":
                    difficulty = DifficultyMenu();
                    gameEngine.SubtractionGame("Subtraction Game", difficulty);
                    break;
                case "m":
                    difficulty = DifficultyMenu();
                    gameEngine.MultiplicationGame("Multiplication Game", difficulty);
                    break;
                case "d":
                    difficulty = DifficultyMenu();
                    gameEngine.DivisionGame("Division Game", difficulty);
                    break;
                case "e":
                    Console.WriteLine("Goodbye.");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("You did not enter a valid option.");
                    break;
            }
        } while (isGameOn);
    }

    internal static DifficultyLevel DifficultyMenu()
    {
        Console.Clear();
        Console.WriteLine(@"Please choose a difficulty from the choices below:
        B - Beginner
        I - Intermediate
        A - Advanced");
        Console.WriteLine("----------------------------------------------------");

        var difficulty = Console.ReadLine().ToLower().Trim();

        while (string.IsNullOrEmpty(difficulty) || !Regex.IsMatch(difficulty, "^(b|i|a)$"))
        {
            Console.WriteLine("You did not enter a valid option.");
            difficulty = Console.ReadLine().ToLower().Trim();
        }

        switch (difficulty)
        {
            case "b":
                return DifficultyLevel.Beginner;
            case "i":
                return DifficultyLevel.Intermediate;
            case "a":
                return DifficultyLevel.Advanced;
            default:
                return 0;
        }
    }
}