using Math_Game.Enums;
using Math_Game.Models;
using Math_Game.Services;
using Math_Game.Utils;
using Spectre.Console;

namespace Math_Game.Views;

internal class Menu
{
    private readonly GameEngine _gameEngine = new();

    internal void MainMenu()
    {
        var isGameOn = true;

        while (isGameOn)
        {
            AnsiConsole.Write(new FigletText("Math Game").Color(Color.DarkBlue));
            var mainMenuChoice = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOptions>()
                    .Title("Select a game mode:")
                    .AddChoices(
                        MenuOptions.ViewGameHistory,
                        MenuOptions.Addition,
                        MenuOptions.Subtraction,
                        MenuOptions.Multiplication,
                        MenuOptions.Division,
                        MenuOptions.Exit
                    )
            );

            var difficulty = DifficultyLevel.Beginner;
            switch (mainMenuChoice)
            {
                case MenuOptions.ViewGameHistory:
                    AnsiConsole.Clear();
                    Helpers.PrintGames();
                    break;
                case MenuOptions.Addition:
                    AnsiConsole.Clear();
                    difficulty = DifficultyMenu();
                    _gameEngine.AdditionGame("Addition Game", difficulty, GameType.Addition);
                    break;
                case MenuOptions.Subtraction:
                    AnsiConsole.Clear();
                    difficulty = DifficultyMenu();
                    _gameEngine.SubtractionGame("Subtraction Game", difficulty);
                    break;
                case MenuOptions.Multiplication:
                    AnsiConsole.Clear();
                    difficulty = DifficultyMenu();
                    _gameEngine.MultiplicationGame("Multiplication Game", difficulty);
                    break;
                case MenuOptions.Division:
                    AnsiConsole.Clear();
                    difficulty = DifficultyMenu();
                    _gameEngine.DivisionGame("Division Game", difficulty);
                    break;
                case MenuOptions.Exit:
                    AnsiConsole.Clear();
                    Console.WriteLine("Goodbye.");
                    isGameOn = false;
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You did not enter a valid option.");
                    break;
            }
        }
    }

    internal DifficultyLevel DifficultyMenu()
    {
        var difficultyChoice = AnsiConsole.Prompt(
            new SelectionPrompt<DifficultyLevel>()
                .Title("Select a difficulty:")
                .AddChoices(
                    DifficultyLevel.Beginner,
                    DifficultyLevel.Intermediate,
                    DifficultyLevel.Advanced
                )
        );

        switch (difficultyChoice)
        {
            case DifficultyLevel.Beginner:
                return DifficultyLevel.Beginner;
            case DifficultyLevel.Intermediate:
                return DifficultyLevel.Intermediate;
            case DifficultyLevel.Advanced:
                return DifficultyLevel.Advanced;
            default:
                return 0;
        }
    }
}
