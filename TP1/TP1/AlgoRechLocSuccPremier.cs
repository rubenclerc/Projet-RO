using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class AlgoRechLocSuccPremier : Algo
    {
        public AlgoRechLocSuccPremier(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {
            // Initialisation
            List<Ville> villes = new List<Ville>(this.Villes);
            Tournee courante = new Tournee(villes);
            bool fini = false;
            Tournee voisin = null;

            while (!fini)
            {
                fini = true;
                voisin = this.Exploration(courante);

                if(voisin.Cout() < courante.Cout())
                {
                    courante = new Tournee(voisin.Villes);
                    fini = false;
                }                

            }


            return courante;
        }

        private Tournee Exploration(Tournee t)
        {
            // Initialisation
            List<Ville> villes = t.Villes;
            Ville tmp = null;

            for (int i = 0; i < villes.Count; i++)
            {
                if (villes.IndexOf(villes[i]) < (villes.Count - 1))
                {
                    tmp = villes[i];
                    villes[i] = villes[i + 1];
                    villes[i + 1] = tmp;
                }
            }

            return new Tournee(villes);
        }
    }

}
