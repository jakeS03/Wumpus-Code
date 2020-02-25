using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class Player
    {
        private int arrows = 5;
        private int coins = 150;
        private int turns = 0;

        public Player()
        {
            arrows = 5;
            coins = 150;
            turns = 0;

        }
        public int getNumberOfArrows()
        {
            return arrows;
            // returns number of arrows in inventory
        }
        public int getCoins()
        {
            return coins;
            // returns number of coins
        }
        public void addArrow()
        {
            arrows += 1;
            // adds one arrow to inventory
        }
        public bool useArrow()
        {
            if (arrows >= 1)
            {
                arrows -= 1;
                return true;
            } else
            {
                return false;
            }
            // returns true if successfully used an arrow and false if failed
        }
        public void addCoins(int coins)
        {
            this.coins += coins;
            // adds parameter of coins to coin total
        }
        public void spendCoins(int coins)
        {
            this.coins -= coins;
            // subtracts parameter from coin total
        }
        public void addTurn()
        {
            turns += 1;
            // adds one turn to total turns
        }
        public int computeScore()
        {
            return -1;
            // computes total score
        }
        public int getTurns()
        {
            return turns;
            // returns number of turns
        }
    }
}
