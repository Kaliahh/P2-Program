using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    public class Chromosome
    {
        public Gene root;

        public Chromosome()
        {
            root = new Gene(0);
        }

        public Chromosome(int initial)
        {
            root = new Gene(initial);
        }
        
        public void AddGene(int type) // Tilføjer et gen til kromosomet
        {
            Gene newGene = new Gene(type);

            // Hvis kromosomet er tomt
            if (root == null) 
            {
                // Sæt det tilføjede gen som roden
                root = newGene;
                return;
            }
        }

        

        public void Print() // Printer træet ud så man kan læse det
        {

        }
    }
}
