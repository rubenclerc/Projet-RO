using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class AlgoPlusProcheVoisin : Algo
    {
        public AlgoPlusProcheVoisin(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {
            List<Ville> res = this.Villes;
            List<Ville> nonVisite = res;
            List<Ville> visite = new List<Ville>();

            while(nonVisite.Count > 0)
            {

            }

            return new Tournee(res);
        }
    }
}
