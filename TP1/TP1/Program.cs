using System;
using System.Collections.Generic;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Villes
            List<Ville> villes = Parser.Parse("C:\\Users\\rc438799\\Desktop\\Projet-RO\\instances\\top80.txt");

            // Algo croissant
            AlgoCroissant algoCroissant = new AlgoCroissant(villes);
            Tournee t = algoCroissant.Executer();
            Console.Write("Algo croissant: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout());

            // Algo aléatoire
            AlgoAleatoire algoAleatoire = new AlgoAleatoire(villes);
            t = algoAleatoire.Executer();
            Console.Write("Algo aléatoire: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout());

            // Algo plus proche voisin
            AlgoPlusProcheVoisin algoPlusProcheVoisin = new AlgoPlusProcheVoisin(villes);
            t = algoPlusProcheVoisin.Executer();
            Console.Write("Algo plus proche voisin: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout());
        }
    }
}
