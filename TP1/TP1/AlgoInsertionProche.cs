using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class AlgoInsertionProche : Algo
    {
        public AlgoInsertionProche(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {
            // Initialisation
            List<Ville> nonVisite = new List<Ville>(this.Villes);
            List<Ville> res = this.PlusEloignes(nonVisite);
            Ville suivante = null;
            double distanceMin = 999999;
            double distance;
            int index = 0;

            // Supprime les 2 villes les plus éloignées de villes non visitées
            nonVisite.Remove(res[0]);
            nonVisite.Remove(res[1]);

            // Tant qu'il reste des villes non visitées, on ajoute à la tournée la ville la plus proche d'elle
            while(nonVisite.Count > 0)
            {
                // Pour chaque ville de la tournée on teste successivement la distance aux villes non visitées
                foreach(Ville depart in res)
                {
                    foreach(Ville arrivee in nonVisite)
                    {
                        distance = depart.Distance(arrivee);

                        if(distance < distanceMin)
                        {
                            distanceMin = distance;
                            suivante = arrivee;
                            index = res.IndexOf(depart);
                        }
                    }

                }

                // Mise à jour des variables
                res.Insert(index+1, suivante);
                distanceMin = 99999;
                nonVisite.Remove(suivante);
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
            foreach(Ville depart in villes)
            {
                foreach(Ville arrivee in villes)
                {
                    if(depart.Id != arrivee.Id)
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
