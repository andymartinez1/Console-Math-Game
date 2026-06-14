using MathGame.Enums;
using MathGame.Models;
using MathGame.Services;
using MathGame.Utils;
using Spectre.Console;

namespace MathGame.Views;

public class MainMenu : IMainMenu
{
    private readonly IGameService _gameService;

    private readonly MenuOptions[] _menuOptions =
    [
        MenuOptions.ViewGameHistory,
        MenuOptions.Addition,
        MenuOptions.Subtraction,
        MenuOptions.Multiplication,
        MenuOptions.Division,
        MenuOptions.Exit,
    ];

    public MainMenu(IGameService gameService)
    {
        _gameService = gameService;
    }

    public void GameMenu()
    {
        var isGameOn = true;

        while (isGameOn)
        {
            AnsiConsole.Write(new FigletText("Math Game").Color(Color.DarkBlue));
            var mainMenuChoice = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOptions>()
                    .Title("Select a game mode:")
                    .AddChoices(_menuOptions)
                    .UseConverter(mo => mo.GetDisplayName())
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
                    _gameService.MathGame("Addition Game", difficulty, GameType.Addition);
                    break;
                case MenuOptions.Subtraction:
                    AnsiConsole.Clear();
                    difficulty = DifficultyMenu();
                    _gameService.MathGame("Subtraction Game", difficulty, GameType.Subtraction);
                    break;
                case MenuOptions.Multiplication:
                    AnsiConsole.Clear();
                    difficulty = DifficultyMenu();
                    _gameService.MathGame(
                        "Multiplication Game",
                        difficulty,
                        GameType.Multiplication
                    );
                    break;
                case MenuOptions.Division:
                    AnsiConsole.Clear();
                    difficulty = DifficultyMenu();
                    _gameService.MathGame("Division Game", difficulty, GameType.Division);
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

    public DifficultyLevel DifficultyMenu()
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
