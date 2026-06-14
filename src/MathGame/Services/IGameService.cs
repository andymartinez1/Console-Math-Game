using MathGame.Models;

namespace MathGame.Services;

public interface IGameService
{
    public void MathGame(string message, DifficultyLevel difficulty, GameType gameType);
}
