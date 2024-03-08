using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Coin
    {
        public delegate void CoinHandler();
        public event CoinHandler CoinCollected;
        private static readonly Random random = new Random();
        public int XPos { get; set; }
        public int YPos { get; set; }

        public Coin()
        {
            RandomizeLocation();
        }

        public void RandomizeLocation()
        {
            XPos = random.Next(0, 200);
            YPos = random.Next(0, 200);
        }

        public void CheckCollision(int x, int y)
        {
            int leftBoundary = XPos - 10;
            int rightBoundary = XPos + 10;
            int topBoundary = YPos - 10;
            int bottomBoundary = YPos + 10;

            if (x >= leftBoundary && x <= rightBoundary 
                && y >= topBoundary && y <= bottomBoundary)
            {
                CoinCollected?.Invoke();
            }
        }


    }
}
