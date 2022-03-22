using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class AlgoInsertionLoin : Algo
    {
        public AlgoInsertionLoin(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {
            // Initialisation
            List<Ville> nonVisite = new List<Ville>(this.Villes);
            List<Ville> res = this.PlusEloignes(nonVisite);
            double distance;
            double distanceMax = 0;
            int index = 0;
            Ville aInserer = null;

            // Supprime les 2 villes les plus éloignées de villes non visitées
            nonVisite.Remove(res[0]);
            nonVisite.Remove(res[1]);

            // Tant qu'il reste des villes non visitées, on ajoute à la tournée la ville la plus loin d'elle
            while (nonVisite.Count > 0)
            {
                // Trouve la ville la plus loin de la tournée
                foreach (Ville v in nonVisite)
                {
                    distance = v.DistanceTournee(res);

                    if (distance > distanceMax)
                    {
                        distanceMax = distance;
                        index = res.IndexOf(v.VilleDistance(res)) + 1;
                        aInserer = v;
                    }

                }

                res.Insert(index, aInserer);
                distanceMax = 0;
                nonVisite.Remove(aInserer);
            }

            return new Tournee(res);
        }

        private List<Ville> PlusEloignes(List<Ville> villes)
        {
            // Initialisation
            List<Ville> res = new List<Ville>();
            Ville d = null;
            Ville a = null;
            double distance;
            double distanceMax = 0;

            // Teste toutes les combinaisons possibles de villes
            foreach (Ville depart in villes)
            {
                foreach (Ville arrivee in villes)
                {
                    if (depart.Id != arrivee.Id)
                    {
                        distance = depart.Distance(arrivee);

                        // Si la distance courante est supérieure à la distance max on met à jour les variables
                        if (distance > distanceMax)
                        {
                            distanceMax = distance;
                            d = depart;
                            a = arrivee;
                        }
                    }
                }
            }

            // Ajout du départ et de l'arrivée
            res.Add(d);
            res.Add(a);


            return res;
        }
    }
}
