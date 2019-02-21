﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    public class Population
    {
        int size;
        Ant[] ants;

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
            for (int step = 0; step < 300; step++)
            {
                foreach (Ant ant in ants)
                {
                    ant.current = ant.Decode(ant.current);
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