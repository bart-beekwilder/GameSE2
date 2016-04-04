using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Object
    {
        protected int positionX;
        protected int positionY;

        public Object(int X, int Y)
        {
            positionX = X;
            positionY = Y;
        }
    }
}
