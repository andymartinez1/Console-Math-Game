using Math_Game.Models;

namespace Math_Game;

internal class GameEngine
{
    internal void AdditionGame(string message)
    {
        var random = new Random();
        var testLength = 5;
        var score = 0;

        for (int i = 0; i < testLength; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var additionNumbers = Helpers.GetFirstAndSecondNumber(Difficulty.Beginner);
            var firstNumber = additionNumbers[0];
            var secondNumber = additionNumbers[1];
            
            Console.WriteLine($"{firstNumber} + {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine($"Your answer was correct! Type any key to continue.");
                score++;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrect answer. Type any key to continue.");
                Console.ReadKey();
            }
        }

        Helpers.AddToHistory(score, testLength, GameType.Addition);

        Console.WriteLine($"Game over. You scored {score} out of {testLength}!");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    internal void SubtractionGame(string message)
    {
        var random = new Random();
        var testLength = 5;
        var score = 0;

        for (int i = 0; i < testLength; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var subtractionNumbers = Helpers.GetFirstAndSecondNumber(Difficulty.Beginner);
            var firstNumber = subtractionNumbers[0];
            var secondNumber = subtractionNumbers[1];
            
            Console.WriteLine($"{firstNumber} + {secondNumber}");
            var result = Console.ReadLine();
            
            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine($"Your answer was correct! Type any key to continue.");
                score++;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrect answer. Type any key to continue.");
                Console.ReadKey();
            }
        }

        Helpers.AddToHistory(score, testLength, GameType.Subtraction);

        Console.WriteLine($"Game over. You scored {score} out of {testLength}!");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    internal void MultiplicationGame(string message)
    {
        var random = new Random();
        var testLength = 5;
        var score = 0;

        for (int i = 0; i < testLength; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var multiplicationNumbers = Helpers.GetFirstAndSecondNumber(Difficulty.Beginner);
            var firstNumber = multiplicationNumbers[0];
            var secondNumber = multiplicationNumbers[1];
            
            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();
            
            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine($"Your answer was correct! Type any key to continue.");
                score++;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrect answer. Type any key to continue.");
                Console.ReadKey();
            }
        }

        Helpers.AddToHistory(score, testLength, GameType.Multiplication);

        Console.WriteLine($"Game over. You scored {score} out of {testLength}!");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    internal void DivisionGame(string message)
    {
        var testLength = 5;
        var score = 0;

        for (int i = 0; i < testLength; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            var result = Console.ReadLine();
            
            result = Helpers.ValidateResults(result);

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine($"Your answer was correct! Type any key to continue.");
                score++;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrect answer. Type any key to continue.");
                Console.ReadKey();
            }
        }

        Helpers.AddToHistory(score, testLength, GameType.Division);

        Console.WriteLine($"Game over. You scored {score} out of {testLength}!");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }
}