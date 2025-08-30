using Math_Game.Models;

namespace Math_Game.Utils;

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
        var result = new int[2];
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

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }

    internal static int[] GetDivisionNumbers(DifficultyLevel difficultyLevel)
    {
        var random = new Random();
        var divisionNumbers = GetFirstAndSecondNumber(difficultyLevel);
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        while (firstNumber % secondNumber != 0)
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

        var result = new int[2];
        result[0] = firstNumber;
        result[1] = secondNumber;

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

    internal static int CheckAnswer(int firstNumber, int secondNumber)
    {
        var score = 0;
        var result = Console.ReadLine();

        result = ValidateResults(result);

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key to continue.");
            score++;
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Incorrect answer. Type any key to continue.");
            Console.ReadKey();
        }

        return score;
    }

    internal static void CalculateScore() { }
}
