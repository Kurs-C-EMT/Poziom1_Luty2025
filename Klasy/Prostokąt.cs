using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    internal class Prostokąt
    {
        public int x1;
        public int x2;
        public int y1;
        public int y2;

        public int ObliczPole()
        {
            int bokA = Math.Abs(x1 - x2);
            int bokB = Math.Abs(y1 - y2);
            return bokA * bokB;
        }

        public void Przesuń(int przX, int przY)
        {
            x1 = x1 + przX;
            x2 = x2 + przX;
            y1 = y1 + przY;
            y2 = y2 + przY;
        }
    }
}
