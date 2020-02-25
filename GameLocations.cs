using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class GameLocations
    {
        int[] roomsWithBats = new int[2];
        int[] roomsWithBottomlessPits = new int[2];
        int roomWithWumpus = 0;
        int roomWithPlayer = 0;

        public GameLocations()
        {
            // sets new rooms blah blah
        }

        public bool movePlayer(int newRoom)
        {
            // moves player to new room, returns bool if succesful
            roomWithPlayer = newRoom;
            return true;
        }

        public bool moveWumpus(int newRoom)
        {
            // moves Wumpus to new room
            return true;
        }

        public bool testForHazards()
        {
            // returns true if hazard
            return true;
        }
    }
}
