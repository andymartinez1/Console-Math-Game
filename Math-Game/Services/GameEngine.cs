using Math_Game.Models;
using Math_Game.Utils;
using Spectre.Console;

namespace Math_Game.Services;

internal class GameEngine
{
    internal void AdditionGame(string message, DifficultyLevel difficulty, GameType gameType)
    {
        var testLength = 5;

        for (var i = 0; i < testLength; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            int[] numbers = [2];

            if (difficulty == DifficultyLevel.Beginner)
                numbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Beginner);
            else if (difficulty == DifficultyLevel.Intermediate)
                numbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Intermediate);
            else if (difficulty == DifficultyLevel.Advanced)
                numbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Advanced);

            var firstNumber = numbers[0];
            var secondNumber = numbers[1];

            switch (gameType)
            {
                case GameType.Addition:
                    Console.WriteLine($"{firstNumber} + {secondNumber}");
                    break;
                case GameType.Subtraction:
                    Console.WriteLine($"{firstNumber} - {secondNumber}");
                    break;
                case GameType.Multiplication:
                    Console.WriteLine($"{firstNumber} * {secondNumber}");
                    break;
                case GameType.Division:
                    break;
                default:
                    return;
            }

            var score = Helpers.CheckAnswer(firstNumber, secondNumber);
        }

        Helpers.AddToHistory(score, testLength, GameType.Addition, difficulty);

        AnsiConsole.WriteLine($"Game over. You scored {score} out of {testLength}!");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    internal void SubtractionGame(string message, DifficultyLevel difficulty)
    {
        var random = new Random();
        var testLength = 5;
        var score = 0;

        for (var i = 0; i < testLength; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var additionNumbers = new[] { 0, 0 };

            if (difficulty == DifficultyLevel.Beginner)
                additionNumbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Beginner);
            else if (difficulty == DifficultyLevel.Intermediate)
                additionNumbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Intermediate);
            else if (difficulty == DifficultyLevel.Advanced)
                additionNumbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Advanced);

            var firstNumber = additionNumbers[0];
            var secondNumber = additionNumbers[1];

            Console.WriteLine($"{firstNumber} - {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber - secondNumber)
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
        }

        Helpers.AddToHistory(score, testLength, GameType.Subtraction, difficulty);

        Console.WriteLine($"Game over. You scored {score} out of {testLength}!");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    internal void MultiplicationGame(string message, DifficultyLevel difficulty)
    {
        var testLength = 5;
        var score = 0;

        for (var i = 0; i < testLength; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var numbers = new[] { 0, 0 };

            if (difficulty == DifficultyLevel.Beginner)
                numbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Beginner);
            else if (difficulty == DifficultyLevel.Intermediate)
                numbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Intermediate);
            else if (difficulty == DifficultyLevel.Advanced)
                numbers = Helpers.GetFirstAndSecondNumber(DifficultyLevel.Advanced);

            var firstNumber = numbers[0];
            var secondNumber = numbers[1];

            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber * secondNumber)
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
        }

        Helpers.AddToHistory(score, testLength, GameType.Multiplication, difficulty);

        Console.WriteLine($"Game over. You scored {score} out of {testLength}!");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    internal void DivisionGame(string message, DifficultyLevel difficulty)
    {
        var testLength = 5;
        var score = 0;

        for (var i = 0; i < testLength; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers(difficulty);
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber / secondNumber)
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
        }

        Helpers.AddToHistory(score, testLength, GameType.Division, difficulty);

        Console.WriteLine($"Game over. You scored {score} out of {testLength}!");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }
}
