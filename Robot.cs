using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    class Robot
    {
        public static int xStartPos = 100;
        public static int yStartPos = 105;
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int moveUnit { get; set; }

        public delegate void OutOfBoundsHandler(string msg);

        public event OutOfBoundsHandler OutOfBounds;

        public Robot() 
        {
            XPos = xStartPos;
            YPos = yStartPos;
            moveUnit = 1;
        }

        public void MoveNorth(int y, int units)
        {
            if (y - units < yStartPos - 100) 
            {
                YPos = yStartPos - 100;
                OutOfBounds?.Invoke("*Bonk*");
            }
            else
            {
                YPos -= units;
                OutOfBounds?.Invoke("");
            }
        }

        public void MoveSouth(int y, int units)
        {
            if (y + units > yStartPos + 100)
            {
                YPos = yStartPos + 100;
                OutOfBounds?.Invoke("*Bonk*");
            }
            else
            {
                YPos += units;
                OutOfBounds?.Invoke("");
            }
        }

        public void MoveEast(int x, int units)
        {
            if (x + units > xStartPos + 100)
            {
                XPos = xStartPos + 100;
                OutOfBounds?.Invoke("*Bonk*");
            }
            else
            {
                XPos += units;
                OutOfBounds?.Invoke("");
            }
        }

        public void MoveWest(int x, int units)
        {
            if (x - units < xStartPos - 100)
            {
                XPos = xStartPos - 100;
                OutOfBounds?.Invoke("*Bonk*");
            }
            else
            {
                XPos -= units;
                OutOfBounds?.Invoke("");
            }
        }

    }
}
