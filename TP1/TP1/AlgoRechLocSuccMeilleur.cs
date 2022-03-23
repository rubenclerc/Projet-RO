using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    class AlgoRechLocSuccMeilleur : Algo
    {
        public AlgoRechLocSuccMeilleur(List<Ville> villes) : base(villes) {}

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
                    Tournee voisin = new Tournee(new List<Ville>(courante.Villes));

                    if (i < voisin.Villes.Count - 1)
                    {
                        Ville tmp = voisin.Villes[i];
                        voisin.Villes[i] = voisin.Villes[i + 1];
                        voisin.Villes[i + 1] = tmp;
                    }
                    else
                    {
                        Ville tmp = voisin.Villes[i];
                        voisin.Villes[i] = voisin.Villes[0];
                        voisin.Villes[0] = tmp;
                    }

                    // Si le cout du voisinage est meilleur on le prend
                    if (voisin.Cout() < courante.Cout())
                    {
                        courante = voisin;
                        fini = false;
                    }

                }
            }

            return courante;
        }
    }
}
