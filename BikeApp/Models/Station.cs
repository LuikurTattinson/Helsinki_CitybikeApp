﻿namespace BikeApp.Models
{
    public class Station
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Nimi { get; set; }
        public string? Namn { get; set; }
        public string? Osoite { get; set; }
        public string? Kaupunki { get; set; }
        public string? Operaattor { get; set; }
        public string? Kapasiteet { get; set; }
        public int jrn_to { get; set; }
        public int jrn_from { get; set; }
        public int avg_dist_from { get; set; }
        public int avg_dist_to { get; set; }

    }
}
