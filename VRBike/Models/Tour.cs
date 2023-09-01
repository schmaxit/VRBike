namespace VRBike.Models
{
    public class Tour
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Percorso { get; set; }
        public string Raccolta { get; set; }

        public string Risorse { get; set; }

        public ICollection<Bikeapp> Bikeapps { get; set; }

        public ICollection<Video> Videos { get; set; }



    }
}
