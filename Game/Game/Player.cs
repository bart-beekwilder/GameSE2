using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    class Player:Object
    {
        public int hitpoints { get; set; }

        public Player(int positionX, int positionY): base (positionX, positionY)
        {
                World.map[positionX,positionY] = 4;
        }

        public void MovePlayer(string sidefacing)
        {
            int pos2X = positionX;
            int pos2Y = positionY;
            if (sidefacing == "up" && positionX > 0)
            {
                pos2X -= 1;
            }
            else if (sidefacing == "down" && positionX < 9)
            {
                pos2X += 1;
            }
            else if (sidefacing == "left" && positionY > 0)
            {
                pos2Y -= 1;
            }
            else if (sidefacing == "right" && positionY < 9)
            {
                pos2Y += 1;
            }
            if (World.GetMap(pos2X, pos2Y) != 1 && World.GetMap(pos2X, pos2Y) != 5)
            {
                World.map[positionX, positionY] = 0;
                World.map[pos2X, pos2Y] = 4;
                positionX = pos2X;
                positionY = pos2Y;
            }
            else if (World.GetMap(pos2X, pos2Y) == 5)
            {
                MessageBox.Show("Hier is het spel gewonnen", "2DO");
            }
        }
    }
}
