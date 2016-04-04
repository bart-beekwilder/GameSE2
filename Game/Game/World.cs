using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class World
    {
        private int Score {get; }
        public static int[,] map = new int[10, 10]
        {
            {0,0,0,0,0,0,0,1,0,5 },
            {0,0,1,1,0,1,0,1,0,0 },
            {0,0,0,1,0,1,1,1,1,1 },
            {1,1,0,1,0,1,1,1,0,0 },
            {0,0,0,1,0,0,0,0,0,0 },
            {0,1,1,1,0,0,0,0,0,0 },
            {0,1,0,0,0,1,1,1,0,1 },
            {0,1,0,0,0,1,0,0,0,0 },
            {0,1,1,1,0,1,0,1,1,0 },
            {0,0,0,0,0,0,0,0,0,0 },
        };

        public World()
        {
            
        }

        public static int GetMap(int x, int y)
        {
            return map[x,y];
        }

        public bool CheckLocation(string sideFacing)
        {
            return true;
        }

        public int PlayerAttacked()
        {
            return 0;
        }

        private void PowerUp()
        {
            
        }

        private void GenerateObjects()
        {
            
        }

        private void RaiseScore()
        {
            
        }

        private void GameEnd()
        {
            
        }
    }
}
