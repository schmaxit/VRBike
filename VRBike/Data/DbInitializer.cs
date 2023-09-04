using VRBike.Models;
namespace VRBike.Data
{
    public class DbInitializer
    {
        public static void Initialize(VRBikeContext context) {

            if (context.Tours.Any())
            {
                return;   // DB has been seeded
            }

            var tourcollection = new TourCollection[]
            {
                new TourCollection{ PageTitle="nazionali"},
                new TourCollection{ PageTitle="regionali"},
                new TourCollection{ PageTitle="locali"},
                new TourCollection{ PageTitle="terre del custoza"},
                new TourCollection{ PageTitle="valpolicella"}
            };

            context.ToursCollections.AddRange(tourcollection);
            context.SaveChanges();

            var tours = new Tour[]
            {

                new Tour{MapCenter="[45.46, 10.76]",MapZoom=11, GeoJsonFile="bussolengo-lago.json", TourCollectionID=4, PageTitle="By bike tra vigne e parchi" , Raccolta="local", Percorso="Bussolengo Pacengo Garda", Description="Terre del Custoza"},
                new Tour{MapCenter="[45.38, 10.8]",MapZoom=11, GeoJsonFile="16.json",TourCollectionID=4,PageTitle="tour 16" , Raccolta="local", Percorso="Sommacampagna Villafranca", Description="Terre del Custoza"},
                new Tour{GeoJsonFile="ev7.json",TourCollectionID=1,PageTitle="Eurovelo 7" , Raccolta="national", Percorso="Rovereto Garda Mantova", Description=""}

            };

            context.Tours.AddRange(tours);
            context.SaveChanges();

            var bikeapps = new Bikeapp[]
            {
                new Bikeapp{ TourID = 1, Title="Komoot" , Link="#"},
                new Bikeapp{ TourID = 1, Title="Alltrails" , Link="#"},
                new Bikeapp{ TourID = 2, Title="Komoot" , Link="#"},
                new Bikeapp{ TourID = 3, Title="Komoot" , Link="#"},
            };

            context.Bikeapps.AddRange(bikeapps);
            context.SaveChanges();

            var videos = new Video[]
            {
                new Video{ TourID =1, Title="Bussolengo Pacengo youtube video", Link ="#"},
                 new Video{ TourID =2, Title="Sommacampagna youtube video", Link ="#"},
                  new Video{ TourID =3, Title="EV7 youtube video", Link ="#"},
            };

            context.Videos.AddRange(videos);
            context.SaveChanges();


        
        
        
        }
    }
}
