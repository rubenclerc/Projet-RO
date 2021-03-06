using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    class AlgoPlusProcheVoisin : Algo
    {
        public AlgoPlusProcheVoisin(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {

            // Initialisation
            List<Ville> nonVisite = new List<Ville>(this.Villes);
            List<Ville> visite = new List<Ville>();

            Ville depart = nonVisite[0];
            visite.Add(depart);
            nonVisite.Remove(depart);

            Ville aAjouter;

            // Tant qu'il reste une ville non visitée on ajoute la ville la plus proche
            while(nonVisite.Count > 0)
            {
                aAjouter = this.PlusProche(depart, nonVisite);

                visite.Add(aAjouter);
                nonVisite.Remove(aAjouter);

                depart = aAjouter;
            }

            return new Tournee(visite);
        }

        public Ville PlusProche(Ville v1, List<Ville> nonVisites)
        {
            // Initialisation
            Ville res = null;
            double distance = -1;
            double previousDistance;

            // Calcule la distance avec chaque ville et prend la plus petite à chaque fois
            foreach(Ville v in nonVisites)
            {
                previousDistance = v1.Distance(v);

                if (res == null)
                {
                    res = v;
                    distance = previousDistance;
                }
                else if(previousDistance < distance){
                    res = v;
                    distance = previousDistance;
                }

            }

            return res;
        }
    }
}
