using System;
using System.Collections.Generic;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser p = new Parser("C:\\Users\\rc438799\\Desktop\\top80.txt");
            List<Ville> villes = p.Parse();
            Tournee t = new Tournee(villes);

            t.AfficheVilles();
        }
    }
}
