Project Overview
The NFL Depth Chart project is a C# console application that manages the depth chart for an NFL team. A depth chart lists the players by position and their order on the team. This project allows adding players to positions, removing players from positions, retrieving the full depth chart, and finding backups for specific players.

Features
Add Player to Depth Chart: Add a player to a specific position at a specified depth.
Remove Player from Depth Chart: Remove a player from a specific position.
Get Full Depth Chart: Retrieve and print the full depth chart.
Get Backups: Retrieve and print the backups for a specific player in a given position.

Prerequisites
.NET Core SDK (version 3.1 or later)

Running the Application
1.Clone the repository:

git clone https://github.com/yourusername/NFLDepthChart.git
cd NFLDepthChart

2.Build the project:

dotnet build

3.Run the project:

dotnet run

Project Structure

Program.cs: The entry point of the application. It initializes the depth chart with players and runs example operations.
DepthChart.cs: Contains the DepthChart class which manages the depth chart operations.
Player.cs: Contains the Player class which represents a player.

Contact
If you have any questions or suggestions, feel free to open an issue or contact me at [thabijose7@example.com].
