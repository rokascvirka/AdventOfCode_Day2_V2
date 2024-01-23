using AdventOfCode_Day2_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day2_V2
{
    public static class FileReader
    {
        public static Games ReadFile(string filePath)
        {
            Games games = new Games();
            using(StreamReader sr  = new StreamReader(filePath))
            {
                var text = sr.ReadToEnd().Split(Environment.NewLine);
                foreach(var line in text)
                {
                    var gameId = int.Parse(line.Split(":")[0].Split(" ")[1]);
                    var cubesRecordLine = line.Split(":")[1].Replace(";", ",").Split(",");
                    var cubes = new List<Cubes>();
                    foreach(var record in cubesRecordLine)
                    {
                        var rec = record.TrimStart().Split(" ");
                        cubes.Add(new Cubes(int.Parse(rec[0]), rec[1]));
                    }
                    games.GamesInfo.Add(new Game(gameId, cubes));
                }
            }
            return games;
        }
    }
}
