using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    public class Population
    {
        int size;
        double max_fitness = 0;
        Ant[] ants;
        Ant best_ant;

        public Population(int size)
        {
            this.size = size;
            ants = new Ant[size];
        }

        public void Populate() // Initialiserer befolkningen, opbygger træerne
        {
            foreach (Ant ant in ants)
            {
                ant.chromosome.Initialize();
            }
        }

        public void Evaluate() // Evaluerer befolkningen, og sætter individernes fitness værdi
        {
            for (int step = 0; step < 300; step++) // Simuleringen varer 300 time steps
            {
                foreach (Ant ant in ants)
                {
                    ant.current = ant.Decode(ant.current);
                }
            }

            foreach (Ant ant in ants)
            {
                if (ant.chromosome.fitness >= this.max_fitness) // Gemmer den bedste myrer
                {
                    best_ant = ant;
                }
            }
        }

        public void Select() // Vælger de myrer der skal have lov til at reproducere
        {
            
        }

        public void Crossover() // Bytter rundt på nodes på udvalgte dele af befolkningen
        {
            
        }

        public void Mutate() // Muterer nodes, en hvis procentdel af gangene i stedet for crossover
        {
            
        }
    }
}
