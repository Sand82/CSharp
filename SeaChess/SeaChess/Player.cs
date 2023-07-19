using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaChess
{
    public class Player
    {
        private string symbol;

        private string name;

        public Player(string symbol, string name)
        {
            this.symbol = symbol;
            this.name = name; 
        }

        public string Symbol { get { return symbol; } }

        public string Name { get { return name; } }
    }
}
