using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NFLDepthChart.Tests
{
    public class DepthChartTests
    {
        private DepthChart depthChart;

        public DepthChartTests()
        {
            depthChart = new DepthChart();
        }

        [Fact]
        public void AddPlayerToDepthChart_EmptyPosition_ShouldAddPlayer()
        {
            // Arrange
            var position = "QB";
            var player = new Player(12, "Tom Brady");

            // Act
            depthChart.AddPlayerToDepthChart(position, player, 0);

            // Assert
            var players = depthChart.GetDepthChartForPosition(position);
            Assert.Single(players);
            Assert.Equal(player, players.First());
        }

        [Fact]
        public void AddPlayerToDepthChart_NoPositionDepth_ShouldAddToEnd()
        {
            // Arrange
            var position = "RB";
            var player1 = new Player(27, "Jones II, Ronald");
            var player2 = new Player(21, "Vaughn, Ke'Shawn");

            // Act
            depthChart.AddPlayerToDepthChart(position, player1); // Adds at depth 0
            depthChart.AddPlayerToDepthChart(position, player2); // Adds at depth 1

            // Assert
            var players = depthChart.GetDepthChartForPosition(position);
            Assert.Equal(2, players.Count);
            Assert.Equal(player1, players[0]);
            Assert.Equal(player2, players[1]);
        }

        [Fact]
        public void AddPlayerToDepthChart_AtSpecificPositionDepth_ShouldInsertPlayer()
        {
            // Arrange
            var position = "RB";
            var player1 = new Player(27, "Jones II, Ronald");
            var player2 = new Player(21, "Vaughn, Ke'Shawn");
            var player3 = new Player(7, "Fournette, Leonard");

            // Act
            depthChart.AddPlayerToDepthChart(position, player1, 0); // Adds at depth 0
            depthChart.AddPlayerToDepthChart(position, player2, 1); // Adds at depth 1
            depthChart.AddPlayerToDepthChart(position, player3, 1); // Adds at depth 1, shifting player2 down

            // Assert
            var players = depthChart.GetDepthChartForPosition(position);
            Assert.Equal(3, players.Count);
            Assert.Equal(player1, players[0]);
            Assert.Equal(player3, players[1]);
            Assert.Equal(player2, players[2]);
        }

        

        [Fact]
        public void RemovePlayerFromDepthChart_PlayerExists_ShouldRemovePlayer()
        {
            // Arrange
            var position = "RB";
            var player1 = new Player(27, "Jones II, Ronald");
            var player2 = new Player(21, "Vaughn, Ke'Shawn");
            depthChart.AddPlayerToDepthChart(position, player1, 0);
            depthChart.AddPlayerToDepthChart(position, player2, 1);

            // Act
            var removedPlayer = depthChart.RemovePlayerFromDepthChart(position, player1);

            // Assert
            Assert.Equal(player1, removedPlayer);
            var remainingPlayers = depthChart.GetDepthChartForPosition(position);
            Assert.Equal(1, remainingPlayers.Count);
            Assert.Equal(player2, remainingPlayers.First());
        }

        [Fact]
        public void RemovePlayerFromDepthChart_PlayerDoesNotExist_ShouldReturnNull()
        {
            // Arrange
            var position = "RB";
            var player1 = new Player(27, "Jones II, Ronald");
            var player2 = new Player(21, "Vaughn, Ke'Shawn");
            depthChart.AddPlayerToDepthChart(position, player1, 0);

            // Act
            var removedPlayer = depthChart.RemovePlayerFromDepthChart(position, player2);

            // Assert
            Assert.Null(removedPlayer);
            var remainingPlayers = depthChart.GetDepthChartForPosition(position);
            Assert.Equal(1, remainingPlayers.Count);
            Assert.Equal(player1, remainingPlayers.First());
        }

        [Fact]
        public void GetBackups_PlayerWithBackupsExists_ShouldReturnBackups()
        {
            // Arrange
            var position = "QB";
            var player1 = new Player(12, "Tom Brady");
            var player2 = new Player(11, "Blaine Gabbert");
            var player3 = new Player(2, "Trask, Kyle");
            depthChart.AddPlayerToDepthChart(position, player1, 0);
            depthChart.AddPlayerToDepthChart(position, player2, 1);
            depthChart.AddPlayerToDepthChart(position, player3, 2);

            // Act
            var backups = depthChart.GetBackups(position, player1);

            // Assert
            Assert.Equal(2, backups.Count);
            Assert.Equal(player2, backups[0]);
            Assert.Equal(player3, backups[1]);
        }

        [Fact]
        public void GetBackups_PlayerWithNoBackups_ShouldReturnEmptyList()
        {
            // Arrange
            var position = "QB";
            var player1 = new Player(12, "Tom Brady");
            depthChart.AddPlayerToDepthChart(position, player1, 0);

            // Act
            var backups = depthChart.GetBackups(position, player1);

            // Assert
            Assert.Empty(backups);
        }

        [Fact]
        public void GetBackups_PlayerDoesNotExist_ShouldReturnEmptyList()
        {
            // Arrange
            var position = "QB";
            var player1 = new Player(12, "Tom Brady");
            var player2 = new Player(11, "Blaine Gabbert");
            depthChart.AddPlayerToDepthChart(position, player1, 0);

            // Act
            var backups = depthChart.GetBackups(position, player2);

            // Assert
            Assert.Empty(backups);
        }

        [Fact]
        public void GetFullDepthChart_ShouldPrintDepthChart()
        {
            // Arrange
            var depthChart = new DepthChart();
            var player1 = new Player(80, "Howard, OJ");
            var player2 = new Player(84, "Brate, Cameron");
            var player3 = new Player(87, "Gronkowski, Rob");
            depthChart.AddPlayerToDepthChart("TE", player1, 0);
            depthChart.AddPlayerToDepthChart("TE", player2, 1);
            depthChart.AddPlayerToDepthChart("TE", player3, 2);

            // Act
            depthChart.GetFullDepthChart();


        }
    }
}
