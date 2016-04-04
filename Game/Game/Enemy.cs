using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Enemy:Object
    {
        public Enemy(int positionX, int positionY) : base(positionX, positionY)
        {
            World.map[positionX, positionY] = 3;
        }

        public void MoveEnemy()
        {
            int playerX = 0;
            int playerY = 0;
            int positionX2 = positionX;
            int positionY2 = positionY;
            bool secondloop = false;
            bool done = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (World.GetMap(i, j) == 4)
                    {
                        playerX = i;
                        playerY = j;
                    }
                }
            }
            while (done == false)
            {
                if (positionX > playerX)/* || secondloop == true) && World.GetMap(positionX--, positionY)) != 0*/
                {
                    World.map[positionX, positionY] = 0;
                    World.map[--positionX, positionY] = 3;
                    done = true;
                }
                else if ((positionY > playerY)) /*|| secondloop == true) && World.GetMap(positionX, positionY++) != 0)*/
                {
                    World.map[positionX, positionY] = 0;
                    World.map[positionX, --positionY] = 3;
                    done = true;
                }
                else if ((positionX < playerX)) /*|| secondloop == true) && World.GetMap(positionX++, positionY) != 0)*/
                {
                    World.map[positionX, positionY] = 0;
                    World.map[++positionX, positionY] = 3;
                    done = true;
                }
                else if ((positionY < playerY)) /*|| secondloop == true) && World.GetMap(positionX, positionY++) != 0)*/
                {
                    World.map[positionX, positionY] = 0;
                    World.map[positionX, ++positionY] = 3;
                    done = true;
                }
                secondloop = true;
            }
        }
    }
}
