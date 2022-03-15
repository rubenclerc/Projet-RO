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

        public void TourneeCroissante()
        {
            Parser p = new Parser("C:\\Users\\rc438799\\Desktop\\top80.txt");
            List<Ville> villes = p.Parse();
            this.Villes = villes;
        }

        public void AfficheTour()
        {
            foreach(Ville v in this.Villes)
            {
                Console.Write(v.Id + ", ");
            }
        }

        public double Cout()
        {
            double cout = 0;

            foreach(Ville v in this.Villes)
            {

            }

            return cout;
        }

    }
}
