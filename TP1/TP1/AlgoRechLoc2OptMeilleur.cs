using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class AlgoRechLoc2OptMeilleur : Algo
    {
        public AlgoRechLoc2OptMeilleur(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {
            // Initialisation
            Tournee courante = new Tournee(this.Villes);
            bool fini = false;

            while (!fini)
            {
                fini = true;

                // Exploration des voisines en recherche de boucle à démeler
                for (int i = 0; i < courante.Villes.Count; i++)
                {
                    for (int j = i + 1; j < courante.Villes.Count; j++)
                    {
                        Tournee voisin = new Tournee(new List<Ville>(courante.Villes));
                        double distI = courante.Villes[i].Distance(courante.Villes[(i + 1) % courante.Villes.Count]);
                        double distJ = courante.Villes[j].Distance(courante.Villes[(j + 1) % courante.Villes.Count]); ;
                        double distIJ = courante.Villes[i].Distance(courante.Villes[j]);
                        double distIJ1 = courante.Villes[(i + 1) % courante.Villes.Count].Distance(courante.Villes[(j + 1) % courante.Villes.Count]);

                        if (distI + distJ > distIJ + distIJ1)
                        {
                            List<Ville> inter = new List<Ville>();
                            inter = courante.Renverser(i + 1, j);

                            Tournee intermediaire = new Tournee(inter);

                            if (voisin.Cout() > intermediaire.Cout())
                            {
                                courante = intermediaire;
                                fini = false;
                            }
                        }

                    }
                }
            }

            return courante;
        }
    }
}
