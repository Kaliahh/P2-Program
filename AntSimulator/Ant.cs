using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    enum Facings : int { N, E, S, W };
    enum Coords : int { X, Y };

    public class Ant
    {
        public Chromosome chromosome = new Chromosome();

        public int[] coords = { 0, 0 };
        public int facing = (int)Facings.N; 
        public double fitness;

        // TODO: Mangler rent faktisk at checke om der er mad
        public bool FoodAhead() // Checker om myren kan se mad foran den
        {
            bool isFood = false;

            for (int distance = 1; distance < 4; distance++) // Myren kan se 3 pladser frem
            {
                int[] check_coords = coords; // Koordinatet der checkes skal nulstilles hver gang

                switch (facing)
                {
                    case (int)Facings.N:
                        check_coords[(int)Coords.Y] += distance;
                        break;

                    case (int)Facings.E:
                        check_coords[(int)Coords.X] += distance;
                        break;

                    case (int)Facings.S:
                        check_coords[(int)Coords.Y] -= distance;
                        break;

                    case (int)Facings.W:
                        check_coords[(int)Coords.X] -= distance;
                        break;
                }

                if (isFood)
                {
                    return true;
                }
            }

            return isFood;
        }

        public void Decode() // Afkoder træet, ved at parre værdierne i hver node med en funktion
        {
            Gene current = chromosome.root;

            while (current != null)
            {
                if (current.type == 0) // Check om der er mad foran myren
                {
                    bool choice = FoodAhead();

                    if (choice)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current = current.right;
                    }
                }

                else if (current.type == 1) // Bevæg myren
                {
                    switch (facing)
                    {
                        case (int)Facings.N: // Gå mod nord
                            coords[(int)Coords.Y] += 1;
                            break;

                        case (int)Facings.E: // Gå mod øst
                            coords[(int)Coords.X] += 1;
                            break;

                        case (int)Facings.S: // Gå mod syd
                            coords[(int)Coords.Y] -= 1;
                            break;

                        case (int)Facings.W: // Gå mod vest
                            coords[(int)Coords.X] -= 1;
                            break;
                    }

                    current = null;
                }

                else if (current.type == 2) // Drej mod højre (facing ++ mod 4)
                {
                    facing = (facing + 1) % 4;
                    current = null;
                }

                else if (current.type == 3) // Drej mod venstre (facing -- mod 4)
                {
                    facing = (facing - 1) % 4;
                    current = null;
                }
            }

            return;
        }
    }   
}
