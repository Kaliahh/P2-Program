using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    class Program
    {
        static void Main()
        {
            int[][] grid = MakeGrid();

            Population population = new Population(100);

            population.Populate();

            for (int i = 0; i < 100; i++)
            {
                population.Evaluate();
                population.Select();
                population.Crossover();
                population.Mutate();
            }

            Console.ReadLine();
        }

        public static int[][] MakeGrid()
        {
            Console.Write("Input bredden af koordinatsættet: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Input højden af koordinatsættet: ");
            int height = int.Parse(Console.ReadLine());

            int[][] grid = new int[width][];

            for (int i = 0; i < width; i++)
            {
                grid[i] = new int[height];
            }

            return grid;
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
