using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class Tournee
    {
        // Attributs
        private List<Ville> villes;

        // Propriétés
        public List<Ville> Villes { get => villes; set => villes = value; }

        // Constructeur
        public Tournee(List<Ville> villes)
        {
            this.Villes = villes;
        }

        // Méthodes
        public void AfficheVilles()
        {
            foreach (Ville ville in villes)
            {
                Console.WriteLine(ville.ToString());
            }
        }

    }
}
