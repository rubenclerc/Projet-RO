using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    class AlgoRechLocSuccPremier : Algo
    {
        public AlgoRechLocSuccPremier(List<Ville> villes) : base(villes) { }

        public override Tournee Executer()
        {
            // Initialisation
            List<Ville> villes = new List<Ville>(this.Villes);
            AlgoPlusProcheVoisin algo = new AlgoPlusProcheVoisin(villes);
            Tournee courante = algo.Executer();
            bool fini = false;
            bool trouve;

            while (!fini)
            {
                fini = true;
                trouve = false;

                // Explore le voisinage
                for (int i = 0; i < courante.Villes.Count && !trouve; i++)
                {
                    Tournee voisin = new Tournee(new List<Ville>(courante.Villes));


                    if(i < voisin.Villes.Count - 1)
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
                        trouve = true;
                    }

                }
            }

            return courante;
        }
    }
}
