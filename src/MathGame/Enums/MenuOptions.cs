using System.ComponentModel.DataAnnotations;

namespace MathGame.Enums;

public enum MenuOptions
{
    [Display(Name = "View Game History")] ViewGameHistory,
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Exit
}