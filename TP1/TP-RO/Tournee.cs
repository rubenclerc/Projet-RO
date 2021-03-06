using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
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

        public List<Ville> Renverser(int i, int j)
        {
            // Initialisation
            Tournee voisine = new Tournee(new List<Ville>(this.Villes));
            List<Ville> liste = new List<Ville>();

            // Démêle un noeud de la tournée et renvoie une liste ordonnée
            for(int k=0; k < i; k++)
            {
                liste.Add(voisine.Villes[k]);
            }

            for(int k = j;k >= i; k--)
            {
                liste.Add(voisine.Villes[k]);
            }

            for(int k=j+1; k < voisine.Villes.Count; k++)
            {
                liste.Add(voisine.Villes[k]);
            }

            return liste;
        }
    }
}
