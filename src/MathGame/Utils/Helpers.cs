using MathGame.Models;

namespace MathGame.Utils;

public static class Helpers
{
    private static readonly List<Game> GamesPlayed = new();

    internal static void PrintGames()
    {
        Console.Clear();
        Console.WriteLine("Game History:");
        Console.WriteLine("----------------------------------------------------");

        if (GamesPlayed.Count == 0)
            Console.WriteLine("No Games Played Yet.");

        foreach (var game in GamesPlayed)
            Console.WriteLine(
                $"{game.Date} - {game.DifficultyLevel} Level - {game.Type} Game: Score = {game.Score} out of {game.Rounds} points"
            );

        Console.WriteLine("----------------------------------------------------\n");
        Console.WriteLine("Type any key to continue.");
        Console.ReadKey();
    }

    internal static int[] GetFirstAndSecondNumber(DifficultyLevel difficultyLevel)
    {
        var random = new Random();
        var firstAndSecondNumber = new int[2];
        int firstNumber;
        int secondNumber;

        if (difficultyLevel == DifficultyLevel.Beginner)
        {
            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);
        }
        else if (difficultyLevel == DifficultyLevel.Intermediate)
        {
            firstNumber = random.Next(1, 49);
            secondNumber = random.Next(1, 49);
        }
        else
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        firstAndSecondNumber[0] = firstNumber;
        firstAndSecondNumber[1] = secondNumber;

        return firstAndSecondNumber;
    }

    internal static int[] GetDivisionNumbers(DifficultyLevel difficultyLevel)
    {
        var random = new Random();
        var divisionNumbers = GetFirstAndSecondNumber(difficultyLevel);
        var num1 = divisionNumbers[0];
        var num2 = divisionNumbers[1];

        if (difficultyLevel == DifficultyLevel.Beginner)
        {
            num2 = random.Next(1, 9);
            num1 = num2 * random.Next(1, 5);
        }
        else if (difficultyLevel == DifficultyLevel.Intermediate)
        {
            num2 = random.Next(1, 49);
            num1 = num2 * random.Next(1, 10);
        }
        else
        {
            num2 = random.Next(1, 99);
            num1 = num2 * random.Next(1, 15);
        }

        var result = new int[2];
        result[0] = num1;
        result[1] = num2;
        return result;
    }

    internal static void AddToHistory(
        int gameScore,
        int roundsPlayed,
        GameType gameType,
        DifficultyLevel difficultyLevel
    )
    {
        GamesPlayed.Add(
            new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Rounds = roundsPlayed,
                Type = gameType,
                DifficultyLevel = difficultyLevel,
            }
        );
    }

    internal static string? ValidateResults(string result)
    {
        while (string.IsNullOrEmpty(result) || !int.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. try again.");
            result = Console.ReadLine();
        }

        return result;
    }

    internal static bool IsAnswerCorrect(int firstNumber, int secondNumber, char operatorType)
    {
        Console.WriteLine($"{firstNumber} {operatorType} {secondNumber}");
        var userInput = Console.ReadLine();

        userInput = ValidateResults(userInput);
        var userAnswer = int.Parse(userInput);

        var correctAnswer = operatorType switch
        {
            '+' => firstNumber + secondNumber,
            '-' => firstNumber - secondNumber,
            '*' => firstNumber * secondNumber,
            '/' => firstNumber / secondNumber,
            _ => throw new ArgumentException("Invalid operator"),
        };

        if (userAnswer == correctAnswer)
        {
            Console.WriteLine("Your answer was correct! Type any key to continue.");
            Console.ReadKey();
            return true;
        }

        Console.WriteLine("Incorrect answer. Type any key to continue.");
        Console.ReadKey();
        return false;
    }
}
