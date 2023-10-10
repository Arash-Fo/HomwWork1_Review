using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomwWork1_Review
{
    public class Player
    {
        //field 
        private string name;
        private int number;

        public Player(string playerName, int playerNumber)
        {
            name = playerName;
            number = playerNumber;
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

    }
}
