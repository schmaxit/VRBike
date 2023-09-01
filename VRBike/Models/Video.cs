namespace VRBike.Models
{
    public class Video
    {

        public int VideoID { get; set; }
        public int TourID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public bool Active { get; set; }
    }
}
