using System;
using System.Collections.Generic;

namespace TP1
{
    class Program
    {
        static void Main()
        {
            // Villes
            List<Ville> villes = Parser.Parse("C:\\Users\\rc438799\\Desktop\\Projet-RO\\instances\\top80.txt");

            // Algo croissant
            AlgoCroissant algoCroissant = new AlgoCroissant(villes);
            Tournee t = algoCroissant.Executer();
            Console.Write("Algo croissant: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km");

            // Algo aléatoire
            AlgoAleatoire algoAleatoire = new AlgoAleatoire(villes);
            t = algoAleatoire.Executer();
            Console.Write("Algo aléatoire: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km");

            // Algo plus proche voisin
            AlgoPlusProcheVoisin algoPlusProcheVoisin = new AlgoPlusProcheVoisin(villes);
            t = algoPlusProcheVoisin.Executer();
            Console.Write("Algo plus proche voisin: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km");

            // Algo plus proche voisin amélioré
            AlgoPlusProcheVoisinAmeliore algoPlusProcheVoisinAmeliore = new AlgoPlusProcheVoisinAmeliore(villes);
            t = algoPlusProcheVoisinAmeliore.Executer();
            Console.Write("Algo plus proche voisin amélioré: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km");

            // Algo insertion proche
            AlgoInsertionProche algoInsertionProche = new AlgoInsertionProche(villes);
            t = algoInsertionProche.Executer();
            Console.Write("Algo insertion proche: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km");

            // Algo insertion loin
            AlgoInsertionLoin algoInsertionLoin = new AlgoInsertionLoin(villes);
            t = algoInsertionLoin.Executer();
            Console.Write("Algo insertion loin: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km");

            // Algo Recherche Locale: echange de successeurs premier d'abord
            AlgoRechLocSuccPremier algoRechLocSuccPremier = new AlgoRechLocSuccPremier(villes);
            t = algoRechLocSuccPremier.Executer();
            Console.Write("Algo recherche local (ech de succs premier d'abord): ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km");

            // Algo Recherche Locale: echange de successeurs meilleur d'abord
            AlgoRechLocSuccMeilleur algoRechLocSuccMeilleur = new AlgoRechLocSuccMeilleur(villes);
            t = algoRechLocSuccMeilleur.Executer();
            Console.Write("Algo recherche local (ech de succs meilleur d'abord): ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km");


        }
    }
}
