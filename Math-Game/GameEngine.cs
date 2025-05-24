using Math_Game.Models;

namespace Math_Game;

internal class GameEngine
{
    internal void AdditionGame(string message, DifficultyLevel difficulty)
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

            Console.WriteLine($"{firstNumber} + {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResults(result);

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
        }

        Helpers.AddToHistory(score, testLength, GameType.Addition, difficulty);

        Console.WriteLine($"Game over. You scored {score} out of {testLength}!");
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