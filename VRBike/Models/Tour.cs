﻿using System.ComponentModel.DataAnnotations.Schema;

namespace VRBike.Models
{
    public class Tour
    {
        public int TourID { get; set; }
        public int TourCollectionID { get; set; }

        public string PageTitle { get; set; }
        public string Description { get; set; }
        public string Percorso { get; set; }
        public string Raccolta { get; set; }
        public string Risorse { get; set; }
        public string GeoJsonFile { get; set; }
        public string MapCenter { get; set; }
        public int MapZoom { get; set; }



        public ICollection<Bikeapp> Bikeapps { get; set; }

        public ICollection<Video> Videos { get; set; }



    }
}
