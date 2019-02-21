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
        public Gene current = null;

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

        public Gene Decode(Gene current) // Afkoder kromosomet, ved at parre værdierne i hver node med en funktion
        {
            // Checker om det er første gang Decode er i gang med dette gen
            if (current == null)
            {
                current = this.chromosome.root;
            }

            // Check om der er mad foran myren
            else if (current.type == 0) 
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

            // Bevæg myren
            else if (current.type == 1) 
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
            }

            // Drej mod højre (facing ++ mod 4)
            else if (current.type == 2) 
            {
                facing = (facing + 1) % 4;
            }

            // Drej mod venstre (facing -- mod 4)
            else if (current.type == 3) 
            {
                facing = (facing - 1) % 4;
            }

            // Split i 2 grene
            else if (current.type == 4) 
            {
                Decode(current.left);
                Decode(current.right);
            }

            // Sætter current tilbage til roden, hvis det forrige gen ikke var en splitter
            if (current.previous.type != 4) 
            {
                current = this.chromosome.root;
            }

            // Returnerer den nye current
            return current;
        }
    }   
}
