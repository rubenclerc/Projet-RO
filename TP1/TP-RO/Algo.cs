using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    public abstract class Algo
    {
        private List<Ville> villes;

        public List<Ville> Villes { get => villes; set => villes = value; }

        public abstract Tournee Executer();

        public Algo(List<Ville> villes) => this.Villes = villes;
    }
}
