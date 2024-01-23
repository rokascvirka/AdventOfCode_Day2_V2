using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day2_V2.Models
{
    public class Game
    {
        const int MAX_BLUECUBES = 14;
        const int MAX_GREENCUBES = 13;
        const int MAX_REDCUBES = 12;
        public int GameId { get; set; }
        public List<Cubes> CubesInfo { get; set; }
        public bool IsPossible { get; set; }
        public List<Cubes> MaxValues { get; set; }

        public long PowerOfSet {  get; set; }
        public Game(int gameId, List<Cubes> cubes)
        {
            GameId = gameId;
            CubesInfo = cubes;
            IsPossible = IsGamePossible(CubesInfo);
            MaxValues = GetMaxValues(CubesInfo);
            PowerOfSet = GetPowerOfSet(MaxValues);
        }

        private static long GetPowerOfSet(List<Cubes> maxValueCubes)
        {
            return maxValueCubes.Select(x => x.CubesCount).Aggregate((total, next) => total *next);
        }

        private static List<Cubes> GetMaxValues(List<Cubes> cubes)
        {
            List<Cubes> maxValuesCubes = new List<Cubes>();
            var maxBlueCubes = cubes.Where(x => x.CubesColor == "blue").Max(x => x.CubesCount);
            maxValuesCubes.Add(new Cubes(maxBlueCubes, "blue"));

            var maxRedCubes = cubes.Where(x => x.CubesColor == "red").Max(x => x.CubesCount);
            maxValuesCubes.Add(new Cubes(maxRedCubes, "red"));

            var maxGreenCubes = cubes.Where(x => x.CubesColor == "green").Max(x => x.CubesCount);
            maxValuesCubes.Add(new Cubes(maxGreenCubes, "green"));

            return maxValuesCubes;
        }

        private static bool IsGamePossible(List<Cubes> cubes)
        {
            foreach (Cubes cubesInfo in cubes)
            {
                if(cubesInfo.CubesColor == "blue" && cubesInfo.CubesCount > MAX_BLUECUBES)
                {
                    return false;
                }
                if (cubesInfo.CubesColor == "red" && cubesInfo.CubesCount > MAX_REDCUBES)
                {
                    return false;
                }
                if (cubesInfo.CubesColor == "green" && cubesInfo.CubesCount > MAX_GREENCUBES)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
