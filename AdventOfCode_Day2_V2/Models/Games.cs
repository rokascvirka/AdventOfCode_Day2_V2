using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day2_V2.Models
{
    public class Games
    {
        public List<Game> GamesInfo { get; set; }

        public Games()
        {
            GamesInfo = new List<Game>();
        }
    }
}
