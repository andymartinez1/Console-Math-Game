namespace Math_Game.Models;

public class Game
{
    internal DateTime Date { get; set; }

    internal int Score { get; set; }

    internal int Rounds { get; set; }

    internal GameType Type { get; set; }

    internal DifficultyLevel DifficultyLevel { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

internal enum DifficultyLevel
{
    Beginner,
    Intermediate,
    Advanced
}