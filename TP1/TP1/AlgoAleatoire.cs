using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    public class AlgoAleatoire : Algo
    {
        public AlgoAleatoire(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {
            List<Ville> shufVilles = this.Villes;
            Random rand = new Random();
            int len = shufVilles.Count;
            int i = 0;

            while(len > 1)
            {
                len--;
                i = rand.Next(len + 1);
                Ville tmp = shufVilles[i];
                shufVilles[i] = shufVilles[len];
                shufVilles[len] = tmp;
            }            

            return new Tournee(shufVilles);
        }
    }
}
