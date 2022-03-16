using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class Tournee
    {
        // Attributs
        private List<Ville> villes;

        // Propriétés
        public List<Ville> Villes { get => villes; set => villes = value; }

        // Constructeurs
        public Tournee(List<Ville> villes)
        {
            this.Villes = villes;
        }

        public Tournee() 
        {
            this.villes = new List<Ville>();
        }

        // Méthodes
        public void AfficheVilles()
        {
            foreach (Ville ville in villes)
            {
                Console.WriteLine(ville.ToString());
            }
        }

        /// <summary>
        /// Affiche les identifiants des villes de la tournée
        /// </summary>
        public void AfficheTour()
        {
            Console.Write("[");

            foreach(Ville v in this.Villes)
            {
                if(this.Villes.IndexOf(v) != 0)
                {
                    Console.Write(", ");
                }

                Console.Write(v.Id);
            }

            Console.WriteLine("]");
        }

        /// <summary>
        /// Calcule le cout de la tournée (distance totale)
        /// </summary>
        /// <returns>cout</returns>
        public double Cout()
        {
            double res = 0;

            // Calcule le tour
            for(int i=0; i < this.Villes.Count-1; i++)
            {
                res += this.Villes[i].Distance(this.Villes[i + 1]);
            }

            // Revient au départ
            res += this.Villes[this.Villes.Count - 1].Distance(this.Villes[0]);

            return res;
        }
    }
}
