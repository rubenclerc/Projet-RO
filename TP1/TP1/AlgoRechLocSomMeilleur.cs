using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class AlgoRechLocSomMeilleur : Algo
    {
        public AlgoRechLocSomMeilleur(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {
            // Initialisation
            List<Ville> villes = new List<Ville>(this.Villes);
            AlgoPlusProcheVoisin algo = new AlgoPlusProcheVoisin(villes);
            Tournee courante = algo.Executer();
            bool fini = false;

            while (!fini)
            {
                fini = true;

                // Explore le voisinage
                for (int i = 0; i < courante.Villes.Count; i++)
                {

                    for (int j = 0; j < courante.Villes.Count; j++)
                    {
                        Tournee voisin = new Tournee(new List<Ville>(courante.Villes));

                        Ville tmp = voisin.Villes[i];
                        voisin.Villes[i] = voisin.Villes[j];
                        voisin.Villes[j] = tmp;

                        // Si le cout du voisinage est meilleur on le prend
                        if (voisin.Cout() < courante.Cout())
                        {
                            courante = voisin;
                            fini = false;
                        }

                    }

                }
            }

            return courante;
        }
    }
}
