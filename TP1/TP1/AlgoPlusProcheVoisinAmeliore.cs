using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    class AlgoPlusProcheVoisinAmeliore : AlgoPlusProcheVoisin
    {
        public AlgoPlusProcheVoisinAmeliore(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {
            // Initialisation
            List<Ville> departs = new List<Ville>(this.Villes);
            List<Tournee> couts = new List<Tournee>();
 
            // On réalise l'algo des plus proches voisin pour chaque départ possible
            foreach(Ville d in departs)
            {

                // Initialisation
                List<Ville> nonVisite = new List<Ville>(this.Villes);
                List<Ville> visite = new List<Ville>();

                Ville depart = d;
                visite.Add(depart);
                nonVisite.Remove(depart);

                Ville aAjouter;

                // Tant qu'il reste une ville non visitée on ajoute la ville la plus proche
                while (nonVisite.Count > 0)
                {
                    aAjouter = this.PlusProche(depart, nonVisite);

                    visite.Add(aAjouter);
                    nonVisite.Remove(aAjouter);

                    depart = aAjouter;
                }

                // Ajoute la tournée à la liste de toutes les tournées
                couts.Add(new Tournee(visite));

            }

            // Retourne la tournée minimale
            return this.GetTourneeMin(couts);
        }

        private Tournee GetTourneeMin(List<Tournee> couts)
        {

            // Initialisation
            Tournee t = null;
            double cout;
            double coutMin = 99999;

            // Pour chaque tournée on calcule son cout et on la compare au cout min
            foreach(Tournee tournee in couts)
            {
                cout = tournee.Cout();

                // Si le cout courant est inférieur au cout min on met à jour les variables nécessaires
                if(cout < coutMin)
                {
                    coutMin = cout;
                    t = tournee;
                }
            }

            return t;
        }
    }
}
