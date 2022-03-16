using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace TP1
{
    public class Parser
    {
        // Méthodes
        public static List<Ville> Parse(string path)
        {
            // Initialisation
            List<Ville> villes = new List<Ville>();
            Ville ville;
            string[] words;
            int id;
            string nom;
            double latitude, longitude;
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";

            // Chaque ligne est transformée en une ville et est ajoutée à la liste
            foreach(string line in File.ReadLines(path))
            {
                words  = line.Split(" ");

                id = int.Parse(words[0]);
                nom = words[1];
                latitude = Convert.ToDouble(words[2], provider);
                longitude = Convert.ToDouble(words[3], provider);

                ville = new Ville(id, nom, latitude, longitude);
                villes.Add(ville);
            }

            return villes;
        }

    }
}
