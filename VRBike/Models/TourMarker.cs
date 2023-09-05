namespace VRBike.Models
{
    public class TourMarker
    {
        public int TourMarkerID { get; set; }
        public int TourID { get; set; }
        public string IconSize { get; set; }
        public string Classname { get; set; }
        public string Position { get; set; }
        public string Html { get; set; }
        public string Tooltip { get; set; }
        public string LinkUrl { get; set; }
        public bool Active { get; set; }

    }
}
