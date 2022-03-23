using System;
using System.Collections.Generic;

namespace TPRO
{
    class Program
    {
        static void Main()
        {
            // Villes
            List<Ville> villes = Parser.Parse("G:\\Mon Drive\\Cours\\S4\\RO\\TP\\Projet-RO\\instances\\top80.txt");

            // Algo croissant
            AlgoCroissant algoCroissant = new AlgoCroissant(villes);
            Tournee t = algoCroissant.Executer();
            Console.Write("Algo croissant: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo aléatoire
            AlgoAleatoire algoAleatoire = new AlgoAleatoire(villes);
            t = algoAleatoire.Executer();
            Console.Write("Algo aléatoire: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo plus proche voisin
            AlgoPlusProcheVoisin algoPlusProcheVoisin = new AlgoPlusProcheVoisin(villes);
            t = algoPlusProcheVoisin.Executer();
            Console.Write("Algo plus proche voisin: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo plus proche voisin amélioré
            AlgoPlusProcheVoisinAmeliore algoPlusProcheVoisinAmeliore = new AlgoPlusProcheVoisinAmeliore(villes);
            t = algoPlusProcheVoisinAmeliore.Executer();
            Console.Write("Algo plus proche voisin amélioré: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo insertion proche
            AlgoInsertionProche algoInsertionProche = new AlgoInsertionProche(villes);
            t = algoInsertionProche.Executer();
            Console.Write("Algo insertion proche: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo insertion loin
            AlgoInsertionLoin algoInsertionLoin = new AlgoInsertionLoin(villes);
            t = algoInsertionLoin.Executer();
            Console.Write("Algo insertion loin: ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo Recherche Locale: echange de successeurs premier d'abord
            AlgoRechLocSuccPremier algoRechLocSuccPremier = new AlgoRechLocSuccPremier(villes);
            t = algoRechLocSuccPremier.Executer();
            Console.Write("Algo recherche locale (ech de succs premier d'abord): ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo Recherche Locale: echange de successeurs meilleur d'abord
            AlgoRechLocSuccMeilleur algoRechLocSuccMeilleur = new AlgoRechLocSuccMeilleur(villes);
            t = algoRechLocSuccMeilleur.Executer();
            Console.Write("Algo recherche locale (ech de succs meilleur d'abord): ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo Recherche Locale: echange de sommets premier d'abord
            AlgoRechLocSomPremier algoRechLocSomPremier = new AlgoRechLocSomPremier(villes);
            t = algoRechLocSomPremier.Executer();
            Console.Write("Algo recherche locale (ech de sommets premier d'abord): ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo Recherche Locale: echange de sommets meilleur d'abord
            AlgoRechLocSomMeilleur algoRechLocSomMeilleur = new AlgoRechLocSomMeilleur(villes);
            t = algoRechLocSomMeilleur.Executer();
            Console.Write("Algo recherche locale (ech de sommets meilleur d'abord): ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");

            // Algo Recherche Locale: echange 2-opt premier d'abord
            AlgoRechLoc2OptPremier algoRechLoc2OptPremier = new AlgoRechLoc2OptPremier(villes);
            t = algoRechLoc2OptPremier.Executer();
            Console.Write("Algo recherche locale (ech 2-opt premier d'abord): ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km\n");
            
            // Algo Recherche Locale: echange 2-opt meilleur d'abord
            AlgoRechLoc2OptMeilleur algoRechLoc2OptMeilleur = new AlgoRechLoc2OptMeilleur(villes);
            t = algoRechLoc2OptMeilleur.Executer();
            Console.Write("Algo recherche locale (ech 2-opt meilleur d'abord): ");
            t.AfficheTour();
            Console.WriteLine("Cout: " + t.Cout() + "km");
            

        }
    }
}
