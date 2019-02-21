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
        public int depth;
        
        public void Initialize() // Opbygger kromosomet
        {
            AddGene(root);
        }

        private void AddGene(Gene current)
        {
            switch (current.type)
            {
                case 0: case 4:
                    AddSplitter(current);
                    return;

                case 1: case 2: case 3:
                    return;
            }
            return;
        }

        private void AddSplitter(Gene current)
        {
            Random random = new Random();

            // Tilføjer et gen på venstre gren, og dykker ned i den med AddGene
            current.left = new Gene(random.Next(5));
            current.left.previous = current;
            AddGene(current.left);

            // Tilføjer et gen på højre gren, og dykker ned i den med AddGene
            current.right = new Gene(random.Next(5));
            current.right.previous = current;
            AddGene(current.left);
        }
        
        public void Print() // Printer træet ud så man kan læse det
        {

        }
    }
}
