using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefreshment
{
    public class Player
    {
        public string name;
        public int number;

        public Player(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }


        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }

        public override string ToString()
        {
            return name.ToString();
        }
    }
}
