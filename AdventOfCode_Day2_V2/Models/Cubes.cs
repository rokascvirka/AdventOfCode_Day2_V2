using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day2_V2.Models
{
    public class Cubes
    {
        public int CubesCount { get; set; }
        public string CubesColor { get;}
        public Cubes(int cubesCount, string cubesColor)
        {
            CubesCount = cubesCount;
            CubesColor = cubesColor;
        }
    }
}
