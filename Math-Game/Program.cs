using Math_Game;

var menu = new MainMenu();

var date = DateTime.Now;

var name = Helpers.GetName();

menu.ShowMenu(name, date);