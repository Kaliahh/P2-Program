using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    public class Grid
    {
        public int[][] coords;

        public Grid(int width, int height)
        {
            coords = new int[width][]; // Sætter bredden af koordinatsættet

            for (int i = 0; i < width;  i++)
            {
                coords[i] = new int[height]; // Sætter højden af koordinatsættet
            }
        }
    }
}
