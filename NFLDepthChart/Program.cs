using System;
using System.Collections.Generic;

namespace NFLDepthChart
{
    class Program
    {
        static void Main(string[] args)
        {
            var depthChart = new DepthChart();
            PopulateDepthChart(depthChart);
            RunExamples(depthChart);
        }

        static void PopulateDepthChart(DepthChart depthChart)
        {
            // Add offense players
            depthChart.AddPlayerToDepthChart("LWR", new Player(13, "Evans, Mike"), 0);
            depthChart.AddPlayerToDepthChart("LWR", new Player(1, "Darden, Jaelon"), 1);
            depthChart.AddPlayerToDepthChart("LWR", new Player(10, "Miller, Scott"), 2);

            depthChart.AddPlayerToDepthChart("RWR", new Player(18, "Johnson, Tyler"), 0);
            depthChart.AddPlayerToDepthChart("RWR", new Player(16, "Perriman, Breshad"), 1);
            depthChart.AddPlayerToDepthChart("RWR", new Player(15, "Grayson, Cyril"), 2);

            depthChart.AddPlayerToDepthChart("LT", new Player(76, "Smith, Donovan"), 0);
            depthChart.AddPlayerToDepthChart("LT", new Player(72, "Wells, Josh"), 1);

            depthChart.AddPlayerToDepthChart("LG", new Player(74, "Marpet, Ali"), 0);
            depthChart.AddPlayerToDepthChart("LG", new Player(60, "Leverett, Nick"), 1);

            depthChart.AddPlayerToDepthChart("C", new Player(66, "Jensen, Ryan"), 0);
            depthChart.AddPlayerToDepthChart("C", new Player(70, "Hainsey, Robert"), 1);

            depthChart.AddPlayerToDepthChart("RG", new Player(65, "Cappa, Alex"), 0);
            depthChart.AddPlayerToDepthChart("RG", new Player(64, "Stinnie, Aaron"), 1);

            depthChart.AddPlayerToDepthChart("RT", new Player(78, "Wirfs, Tristan"), 0);
            depthChart.AddPlayerToDepthChart("RT", new Player(72, "Wells, Josh"), 1);

           
            // Adding first TE
            depthChart.AddPlayerToDepthChart("TE", new Player(80, "Howard, OJ"), 0);
            depthChart.AddPlayerToDepthChart("TE", new Player(84, "Brate, Cameron"), 1);

            // Adding second TE
            depthChart.AddPlayerToDepthChart("TE", new Player(87, "Gronkowski, Rob"), 2);

            depthChart.AddPlayerToDepthChart("QB", new Player(12, "Brady, Tom"), 0);
            depthChart.AddPlayerToDepthChart("QB", new Player(11, "Gabbert, Blaine"), 1);
            depthChart.AddPlayerToDepthChart("QB", new Player(2, "Trask, Kyle"), 2);

            depthChart.AddPlayerToDepthChart("RB", new Player(7, "Fournette, Leonard"), 0);
            depthChart.AddPlayerToDepthChart("RB", new Player(27, "Jones II, Ronald"), 1);
            depthChart.AddPlayerToDepthChart("RB", new Player(21, "Vaughn, Ke'Shawn"), 2);
            depthChart.AddPlayerToDepthChart("RB", new Player(25, "Bernard, Giovani"), 3);

            // Add defense players
            depthChart.AddPlayerToDepthChart("DE", new Player(93, "Suh, Ndamukong"), 0);
            depthChart.AddPlayerToDepthChart("DE", new Player(96, "McLendon, Steve"), 1);

            depthChart.AddPlayerToDepthChart("NT", new Player(50, "Vea, Vita"), 0);
            depthChart.AddPlayerToDepthChart("NT", new Player(56, "Nunez-Roches, Rakeem"), 1);

            depthChart.AddPlayerToDepthChart("DE", new Player(92, "Gholston, William"), 0);
            depthChart.AddPlayerToDepthChart("DE", new Player(96, "McLendon, Steve"), 1);

            depthChart.AddPlayerToDepthChart("OLB", new Player(90, "Pierre-Paul, Jason"), 0);
            depthChart.AddPlayerToDepthChart("OLB", new Player(98, "Nelson, Anthony"), 1);

            depthChart.AddPlayerToDepthChart("ILB", new Player(45, "White, Devin"), 0);
            depthChart.AddPlayerToDepthChart("ILB", new Player(51, "Minter, Kevin"), 1);

            depthChart.AddPlayerToDepthChart("ILB", new Player(54, "David, Lavonte"), 0);
            depthChart.AddPlayerToDepthChart("ILB", new Player(52, "Britt, KJ"), 1);
            depthChart.AddPlayerToDepthChart("ILB", new Player(48, "Stuard, Grant"), 2);

            depthChart.AddPlayerToDepthChart("OLB", new Player(58, "Barrett, Shaquil"), 0);
            depthChart.AddPlayerToDepthChart("OLB", new Player(9, "Tryon, Joe"), 1);
            depthChart.AddPlayerToDepthChart("OLB", new Player(49, "Gill, Cam"), 2);

            depthChart.AddPlayerToDepthChart("CB", new Player(24, "Davis, Carlton"), 0);
            depthChart.AddPlayerToDepthChart("CB", new Player(43, "Cockrell, Ross"), 1);

            depthChart.AddPlayerToDepthChart("SS", new Player(31, "Winfield Jr., Antoine"), 0);
            depthChart.AddPlayerToDepthChart("SS", new Player(32, "Edwards, Mike"), 1);

            depthChart.AddPlayerToDepthChart("FS", new Player(33, "Whitehead, Jordan"), 0);
            depthChart.AddPlayerToDepthChart("FS", new Player(26, "Adams, Andrew"), 1);

            depthChart.AddPlayerToDepthChart("RCB", new Player(23, "Murphy-Bunting, Sean"), 0);
            depthChart.AddPlayerToDepthChart("RCB", new Player(35, "Dean, Jamel"), 1);
            depthChart.AddPlayerToDepthChart("RCB", new Player(30, "Delaney, Dee"), 2);
            depthChart.AddPlayerToDepthChart("RCB", new Player(29, "Desir, Pierre"), 3);

            // Add special teams players
            depthChart.AddPlayerToDepthChart("PT", new Player(8, "Pinion, Bradley"), 0);
            depthChart.AddPlayerToDepthChart("PK", new Player(3, "Succop, Ryan"), 0);
            depthChart.AddPlayerToDepthChart("LS", new Player(97, "Triner, Zach"), 0);
            depthChart.AddPlayerToDepthChart("H", new Player(8, "Pinion, Bradley"), 0);
            depthChart.AddPlayerToDepthChart("KO", new Player(8, "Pinion, Bradley"), 0);
            depthChart.AddPlayerToDepthChart("PR", new Player(1, "Darden, Jaelon"), 0);
            depthChart.AddPlayerToDepthChart("KR", new Player(1, "Darden, Jaelon"), 0);
            depthChart.AddPlayerToDepthChart("KR", new Player(18, "Johnson, Tyler"), 1);
        }

      
          static void RunExamples(DepthChart depthChart)
        {
            // Example operations
            Console.WriteLine("Full Depth Chart:");
            depthChart.GetFullDepthChart();

            Console.WriteLine("\nBackups for Tom Brady (QB):");
            PrintPlayers(depthChart.GetBackups("QB", new Player(12, "Brady, Tom")));

            Console.WriteLine("\nBackups for Jaelon Darden (LWR):");
            PrintPlayers(depthChart.GetBackups("LWR", new Player(1, "Darden, Jaelon")));

            Console.WriteLine("\nBackups for Mike Evans (LWR):");
            PrintPlayers(depthChart.GetBackups("LWR", new Player(13, "Evans, Mike")));

            Console.WriteLine("\nBackups for Blaine Gabbert (QB):");
            PrintPlayers(depthChart.GetBackups("QB", new Player(11, "Gabbert, Blaine")));

            Console.WriteLine("\nBackups for Kyle Trask (QB):");
            PrintPlayers(depthChart.GetBackups("QB", new Player(2, "Trask, Kyle")));

            Console.WriteLine("\nRemoving Mike Evans from LWR:");
            var removedPlayer = depthChart.RemovePlayerFromDepthChart("LWR", new Player(13, "Evans, Mike"));
            Console.WriteLine(removedPlayer != null ? $"Removed: {removedPlayer}" : "Player not found");

            Console.WriteLine("\nFull Depth Chart After Removal:");
            depthChart.GetFullDepthChart();
        }

        static void PrintPlayers(List<Player> players)
        {
            if (players.Count > 0)
            {
                foreach (var player in players)
                {
                    Console.WriteLine($"#{player.Number} - {player.Name}");
                }
            }
            else
            {
                Console.WriteLine("No backups found or player is last in the list.");
            }
        }
    }
}


