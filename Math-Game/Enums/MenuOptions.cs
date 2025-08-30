using System.ComponentModel.DataAnnotations;

namespace Math_Game.Enums;

public enum MenuOptions
{
    [Display(Name = "View Game History")]
    ViewGameHistory,
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Exit,
}
