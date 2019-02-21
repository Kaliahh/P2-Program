using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    public class Chromosome
    {
        public Gene root = new Gene(0);
        public double fitness = 0;
        public int depth = 0;
        
        public void Initialize() // Opbygger kromosomet
        {
            AddGene(root);
        }

        private void AddGene(Gene current) // Tilføjer et gen, hvis genets type tillader det
        {
            switch (current.type)
            {
                case 0: case 4:
                    AddSplitterGene(current);
                    depth++;
                    return;

                case 1: case 2: case 3:
                    depth++;
                    return;
            }
            return;
        }

        private void AddSplitterGene(Gene current) //Tilføjer et gen med to grene
        {
            Random random = new Random();
            int rnd;

            // Tilføjer et gen på venstre gren, og dykker ned i den med AddGene
            rnd = random.Next(5);
            current.left = new Gene(rnd) { previous = current };
            AddGene(current.left);

            // Tilføjer et gen på højre gren, og dykker ned i den med AddGene
            rnd = random.Next(5);
            current.right = new Gene(rnd) { previous = current };
            AddGene(current.left);
        }
        
        public void Print() // Printer træet ud så man kan læse det
        {

        }
    }
}
