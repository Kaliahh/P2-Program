using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    public class Chromosome
    {
        Gene root;

        public Chromosome()
        {
            root = null;
        }

        public Chromosome(int initial)
        {
            root = new Gene(initial);
        }
        
        public void AddGene(int type) // Tilføjer et gen til kromosomet
        {
            // Hvis kromosomet er tomt
            if (root == null) 
            {
                // Sæt det tilføjede gen som roden
                Gene newGene = new Gene(type);
                root = newGene;
                return;
            }
        }

        public void Decode() // Afkoder træet, ved at parre værdierne i hver node med en funktion
        {
            
        }

        public void Print() // Printer træet ud så man kan læse det
        {

        }
    }
}
