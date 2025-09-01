using MathGame.Services;
using MathGame.Views;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection.AddTransient<IMainMenu, MainMenu>();
serviceCollection.AddTransient<IGameService, GameService>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var mainMenu = serviceProvider.GetRequiredService<IMainMenu>();

mainMenu.GameMenu();
