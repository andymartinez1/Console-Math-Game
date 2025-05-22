namespace Math_Game;

internal class Menu
{
    GameEngine gameEngine = new GameEngine();
    internal void ShowMenu(string name, DateTime date)
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Hello {name}! It's {date.DayOfWeek}.");
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
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You did not enter a valid option");
                    break;
            }
        } while (isGameOn);
    }
}