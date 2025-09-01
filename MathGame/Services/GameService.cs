using MathGame.Models;
using MathGame.Utils;
using Spectre.Console;

namespace MathGame.Services;

public class GameService : IGameService
{
    public void MathGame(string message, DifficultyLevel difficulty, GameType gameType)
    {
        var score = 0;
        const int testLength = 5;

        for (var i = 0; i < testLength; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            int[] numbers = [2];

            switch (difficulty)
            {
                case DifficultyLevel.Beginner:
                    if (gameType == GameType.Division)
                        numbers = Helpers.GetDivisionNumbers(DifficultyLevel.Beginner);
                    else
                        numbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Beginner);
                    break;
                case DifficultyLevel.Intermediate:
                    if (gameType == GameType.Division)
                        numbers = Helpers.GetDivisionNumbers(DifficultyLevel.Intermediate);
                    else
                        numbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Intermediate);
                    break;
                case DifficultyLevel.Advanced:
                    if (gameType == GameType.Division)
                        numbers = Helpers.GetDivisionNumbers(DifficultyLevel.Advanced);
                    else
                        numbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Advanced);
                    break;
            }

            var firstNumber = numbers[0];
            var secondNumber = numbers[1];

            var operatorType = gameType switch
            {
                GameType.Addition => '+',
                GameType.Subtraction => '-',
                GameType.Multiplication => '*',
                GameType.Division => '/',
                _ => throw new ArgumentException("Invalid game type"),
            };

            if (Helpers.IsAnswerCorrect(firstNumber, secondNumber, operatorType))
                score++;
        }

        Helpers.AddToHistory(score, testLength, gameType, difficulty);

        AnsiConsole.WriteLine($"Game over. You scored {score} out of {testLength}!");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }
}
