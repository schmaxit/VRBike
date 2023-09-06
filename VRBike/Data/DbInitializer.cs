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
                new TourCollection{ PageTitle="all"},
             //   new TourCollection{ PageTitle="regionali"},
             //   new TourCollection{ PageTitle="locali"},
             //   new TourCollection{ PageTitle="terre del custoza"},
             //   new TourCollection{ PageTitle="valpolicella"}
            };

            context.ToursCollections.AddRange(tourcollection);
            context.SaveChanges();

            var tours = new Tour[]
            {

                new Tour{Color="blue", Distanza=13,Salita=130,Discesa=150, MapCenter="[45.46, 10.76]",MapZoom=11, GeoJsonFile="bussolengo-lago.json", TourCollectionID=1, PageTitle="terre del custoza By bike tra vigne e parchi" , Raccolta="custoza, local", Percorso="Bussolengo Pacengo Garda", Description="Terre del Custoza"},
                new Tour{Color="blue",Distanza=13,Salita=70,Discesa=130, MapCenter="[45.46, 10.76]",MapZoom=11, GeoJsonFile="16.json",TourCollectionID=1,PageTitle="terre del custoza tour 16" , Raccolta="custoza, local", Percorso="Sommacampagna Villafranca", Description="Terre del Custoza"},
                new Tour{Color="red", Distanza=133,Salita=590,Discesa=740, MapCenter="[45.46, 10.76]",MapZoom=10,GeoJsonFile="ev7.json",TourCollectionID=1,PageTitle="Eurovelo 7" , Raccolta="national", Percorso="Rovereto Garda Mantova", Description=""},
                new Tour{Color="blue",Distanza=18,Salita=70,Discesa=170,MapCenter="[45.46, 10.76]",MapZoom=11,GeoJsonFile="29.json",TourCollectionID=1,PageTitle="terre del custoza tour 29" , Raccolta="custoza, local", Percorso="Bussolengo Castelnuovo", Description=""},
                new Tour{Color="blue",Distanza=22,Salita=140,Discesa=170,MapCenter="[45.46, 10.76]",MapZoom=11,GeoJsonFile="30.json",TourCollectionID=1,PageTitle="terre del custoza tour 30" , Raccolta="custoza, local", Percorso="Bussolengo Castelnuovo", Description=""},
                new Tour{Color="blue",Distanza=11,Salita=110,Discesa=220,MapCenter="[45.46, 10.76]",MapZoom=11,GeoJsonFile="35.json",TourCollectionID=1,PageTitle="terre del custoza tour 35" , Raccolta="custoza, local", Percorso="Bussolengo Sommacampagna", Description=""},
                new Tour{Color="purple",Distanza=54,Salita=70,Discesa=100,MapCenter="[45.42, 10.98]",MapZoom=10,GeoJsonFile="adigesud.json",TourCollectionID=1 ,PageTitle="Parco adige sud" , Raccolta="local, regional", Percorso="Verona Legnago", Description=""},
                new Tour{Color="purple",Distanza=56,Salita=80,Discesa=130,MapCenter="[45.42, 10.98]",MapZoom=10,GeoJsonFile="cca.json",TourCollectionID=1 ,PageTitle="claudia augusta" , Raccolta="local, regional", Percorso="Verona Ostiglia", Description=""},
                new Tour{Color="blue",Distanza=32,Salita=10,Discesa=60, MapCenter="[45.42, 10.98]",MapZoom=10,GeoJsonFile="cdr.json",TourCollectionID=1 ,PageTitle="ciclovia delle risorgive" , Raccolta="local", Percorso="Zevio Valeggio sul Mincio", Description=""},
                new Tour{Color="purple",Distanza=44,Salita=50,Discesa=100,MapCenter="[45.42, 10.76]",MapZoom=10,GeoJsonFile="vrma.json",TourCollectionID=1 ,PageTitle="Verona Mantova" , Raccolta="regional, local", Percorso="Verona Mantova", Description=""},
                new Tour{Color="red",Distanza=112,Salita=830,Discesa=860,MapCenter="[45.42, 10.98]",MapZoom=10,GeoJsonFile="i1.json",TourCollectionID=1 ,PageTitle="itinerario 1" , Raccolta="regional, national", Percorso="Garda Verona Vicenza", Description=""},
                new Tour{Color="blue",Distanza=20,Salita=130,Discesa=100, MapCenter="[45.55, 10.8]",MapZoom=10,GeoJsonFile="valpo11.json",TourCollectionID=1 ,PageTitle="valpolicella tour 11" , Raccolta="valpolicella, local", Percorso="Verona Domegliara", Description=""},
                new Tour{Color="blue",Distanza=32,Salita=1120,Discesa=260, MapCenter="[45.55, 10.95]",MapZoom=10,GeoJsonFile="valpo12.json",TourCollectionID=1 ,PageTitle="valpolicella tour 12" , Raccolta="valpolicella, local", Percorso="Verona Fosse", Description=""},
                new Tour{Color="blue",Distanza=33,Salita=524,Discesa=150, MapCenter="[45.55, 10.9]",MapZoom=10,GeoJsonFile="valpo46.json",TourCollectionID=1 ,PageTitle="valpolicella tour 46" , Raccolta="valpolicella, local", Percorso="Verona Peri", Description=""},

            };

            context.Tours.AddRange(tours);
            context.SaveChanges();

            var tourMarkers = new TourMarker[]
            {
                new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.28, 10.73]"},
                new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.38, 10.7]"},
                new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.45, 10.695]"},
                new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.55, 10.719]"},
                new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.62, 10.852]"}
            };
            context.TourMarkers.AddRange(tourMarkers);
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
