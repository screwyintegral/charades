using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NicoleBCharades.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int NumberOfPlayers { get; set; }
        public int NumberOfRounds { get; set; }
        public int NumberOfCards { get; set; }
    }
}
