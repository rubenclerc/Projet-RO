using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public class AlgoCroissant : Algo
    {
        public AlgoCroissant(List<Ville> villes) : base(villes) {}

        public override Tournee Executer()
        {
            return new Tournee(this.Villes);
        }
    }
}
