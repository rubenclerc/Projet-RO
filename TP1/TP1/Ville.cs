using System;
using System.Collections.Generic;
using System.Text;

namespace TP1
{
    class Ville
    {
        // Attributs
        private int id;
        private string nom;
        private double latitude;
        private double longitude;

        // Propriétés
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }

        // Constructeurs
        public Ville(int id, string nom, double latitude, double longitude)
        {
            this.Id = id;
            this.Nom = nom;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public Ville(Ville v2)
        {
            this.Id = v2.Id;
            this.Nom = v2.Nom;
            this.Latitude = v2.Latitude;
            this.Longitude = v2.Longitude;
        }


        // Méthodes
        public double Distance(Ville v2)
        {
            // Initialisation
            double res = 0;
            int r = 6371;

            // Ville 1
            double x1 = this.longitude * (Math.PI / 180);
            double y1 = this.latitude * (Math.PI / 180);

            // Ville 2
            double x2 = v2.longitude * (Math.PI / 180);
            double y2 = v2.latitude * (Math.PI / 180);

            // Calcul
            res = Math.Abs(r * Math.Acos(Math.Sin(y1) * Math.Sin(y2)) + (Math.Cos(y1)*Math.Cos(y2))*Math.Cos(x1*x2));

            return res;
        }

        public string ToString()
        {
            return this.Id + ": " + this.Nom + " se situe en " + this.Latitude + " et " + this.Longitude;
        }
    }
}
