using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Population population = new Population(100);

            population.Populate();

            for (int i = 0; i < 100; i++)
            {
                population.Evaluate();
                population.Select();
                population.Crossover();
                population.Mutate();
            }
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
