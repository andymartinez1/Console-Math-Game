using Math_Game;

var menu = new Menu();
var date = DateTime.Now;

var gamesPlayed = new List<string>();

var name = GetName();

menu.ShowMenu(name, date);

string? GetName()
{
    Console.WriteLine("Please type your name:");
    var name = Console.ReadLine();
    return name;
}