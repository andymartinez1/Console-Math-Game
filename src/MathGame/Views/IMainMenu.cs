using MathGame.Models;

namespace MathGame.Views;

public interface IMainMenu
{
    public void GameMenu();

    public DifficultyLevel DifficultyMenu();
}
