# Math Game

Math Game is an interactive .NET console application designed to help users practice basic arithmetic skills in a simple and engaging way. The application provides multiple game modes including addition, subtraction, multiplication, and division. Users can choose a difficulty level, select how many questions they want to answer, and receive a final score at the end of each game session.

The project uses a clean console-based interface powered by Spectre.Console, giving the application a more polished and user-friendly terminal experience. It also uses dependency injection to organize services and views, making the codebase easier to maintain, extend, and test. Game results are stored in a history list so users can review previous sessions, including the game type, difficulty level, number of rounds, score, and date played.

## Features

- Addition, subtraction, multiplication, and division game modes
- Beginner, intermediate, and advanced difficulty levels
- Custom question quantity for each game session
- Score tracking for each round
- Game history view
- Interactive console menus using Spectre.Console
- Dependency injection-based application structure
- Clean separation between services, views, models, utilities, and enums
- Docker support for containerized execution

## Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Git
- Docker, optional, if you want to run the app in a container

You can verify your .NET installation with:
    ```bash 
    dotnet --version
    ```

## Running the app

1. **Clone the repository:**
    ```bash
    https://github.com/andymartinez1/Console-Math-Game.git 
    ```


2. **Navigate to the project root directory:**
    ```bash
    cd MathGame
    ```

3. **Restore dependencies:**
    ```bash
   dotnet restore
   ```

4. Build and run the app:
   ```bash
   dotnet build
   dotnet run
   ```

## Running with Docker

[!IMPORTANT]
Docker must be running before following the next commands

1. **Build the Docker image:**
   ```bash
   docker build -t math-game:latest .
   ```

2. **Run the container:**
   ```bash
   docker run -it math-game:latest
   ```


The `-it` flags are recommended because this is an interactive console application.

## How to Play

When the application starts, you will be shown a main menu where you can choose a game mode.

Available options include:

- View Game History
- Addition
- Subtraction
- Multiplication
- Division
- Exit

After selecting a game mode, choose a difficulty level:

- Beginner
- Intermediate
- Advanced

Then enter how many questions you want to answer. The game will present one question at a time and track your score. At the end of the session, your final score will be displayed and saved to the game history.


## Tech Stack

- **.NET 10** - Application runtime and development platform
- **C# 13.0** - Primary programming language
- **Spectre.Console** - Library for building rich console user interfaces
- **Docker** - Containerized application support