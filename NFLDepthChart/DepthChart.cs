using System;
using System.Collections.Generic;
using System.Linq;

namespace NFLDepthChart
{
    public class DepthChart
    {
        private Dictionary<string, List<Player>> depthChart;

        public DepthChart()
        {
            depthChart = new Dictionary<string, List<Player>>();
        }

        public void AddPlayerToDepthChart(string position, Player player, int position_depth = -1)
        {
            if (!depthChart.ContainsKey(position))
            {
                depthChart[position] = new List<Player>();
            }

            if (position_depth == -1 || position_depth >= depthChart[position].Count)
            {
                // Add player to the end of the list or if position_depth is not specified
                depthChart[position].Add(player);
                player.PositionDepth = depthChart[position].Count - 1; // Set the correct PositionDepth
            }
            else
            {
                // Insert player at the specified depth and adjust other players' depths
                depthChart[position].Insert(position_depth, player);
                player.PositionDepth = position_depth; // Set the correct PositionDepth
            }

            // Adjust position_depth of other players below
            for (int i = position_depth + 1; i < depthChart[position].Count; i++)
            {
                depthChart[position][i].PositionDepth++;
            }
        }


        public List<Player> GetDepthChartForPosition(string position)
        {
            if (depthChart.ContainsKey(position))
            {
                return depthChart[position];
            }
            return new List<Player>();
        }

        public void GetFullDepthChart()
        {
            foreach (var position in depthChart.Keys)
            {
                Console.WriteLine($"{position} - {string.Join(", ", depthChart[position])}");
            }
        }



        public Player RemovePlayerFromDepthChart(string position, Player player)
        {
            if (depthChart.ContainsKey(position))
            {
                var players = depthChart[position];

                // Find the player in the list
                var index = players.FindIndex(p => p.Number == player.Number && p.Name == player.Name);

                // If player found, remove and return it
                if (index != -1)
                {
                    var removedPlayer = players[index];
                    players.RemoveAt(index);
                    return removedPlayer;
                }
            }

            // Return null if player is not found at the specified position
            return null;
        }


        public List<Player> GetBackups(string position, Player player)
        {
            if (depthChart.ContainsKey(position))
            {
                var players = depthChart[position];


                // Find the index of the player in the list
                var index = players.FindIndex(p => p.Number == player.Number && p.Name == player.Name);
                // Check if player was found and there are backups available
                if (index != -1 && index < players.Count - 1)
                {
                    return players.Skip(index + 1).ToList();
                }
            }
            // Return an empty list if position or backups are not found
            return new List<Player>();
        }
      


    }
}
