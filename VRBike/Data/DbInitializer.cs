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

                new Tour{Difficulty="1: very easy", TumbUrl="vigne.webp", Color="blue", Distanza=13,Salita=130,Discesa=150, MapCenter="[45.46, 10.76]",MapZoom=11, GeoJsonFile="bussolengo-lago.json", TourCollectionID=1, PageTitle="terre del custoza By bike tra vigne e parchi" , Raccolta="custoza, local, collina", Percorso="Bussolengo, Pacengo, Garda", Description="Terre del Custoza"},
                new Tour{Difficulty="2: easy",TumbUrl="c16.webp",Color="blue",Distanza=32,Salita=160,Discesa=130, MapCenter="[45.46, 10.76]",MapZoom=11, GeoJsonFile="16.json",TourCollectionID=1,PageTitle="terre del custoza tour 16" , Raccolta="custoza, local, valpolicella, adige, collina", Percorso="Villafranca, Sommacampagna, Bussolengo, Pescantina, Cavaion", Description="ciclovia tra Terre del Custoza e Valpolicella"},
                new Tour{Difficulty="3: medium",TumbUrl="ev7.webp",Color="red", Distanza=133,Salita=590,Discesa=740, MapCenter="[45.46, 10.76]",MapZoom=10,GeoJsonFile="ev7.json",TourCollectionID=1,PageTitle="Eurovelo 7" , Raccolta="national, montagna, collina", Percorso="Rovereto, Garda, Lazise, Peschiera, Valeggio sul Mincio, Mantova", Description=""},
                new Tour{Difficulty="2: easy",TumbUrl="c29.webp",Color="blue",Distanza=18,Salita=70,Discesa=170,MapCenter="[45.46, 10.76]",MapZoom=11,GeoJsonFile="29.json",TourCollectionID=1,PageTitle="terre del custoza tour 29" , Raccolta="custoza, local, collina", Percorso="Bussolengo, Castelnuovo", Description=""},
                new Tour{Difficulty="2: easy",TumbUrl = "c30.webp", Color="blue",Distanza=22,Salita=140,Discesa=170,MapCenter="[45.46, 10.76]",MapZoom=11,GeoJsonFile="30.json",TourCollectionID=1,PageTitle="terre del custoza tour 30" , Raccolta="custoza, local, collina", Percorso="Bussolengo, Castelnuovo", Description=""},
                new Tour{Difficulty="2: easy",TumbUrl="c35.webp", Color="blue",Distanza=11,Salita=110,Discesa=220,MapCenter="[45.46, 10.76]",MapZoom=11,GeoJsonFile="35.json",TourCollectionID=1,PageTitle="terre del custoza tour 35" , Raccolta="custoza, local, collina", Percorso="Bussolengo, Sommacampagna", Description=""},
                new Tour{Difficulty="3: medium",TumbUrl="adigesud.webp",Color="purple",Distanza=54,Salita=70,Discesa=100,MapCenter="[45.42, 10.98]",MapZoom=10,GeoJsonFile="adigesud.json",TourCollectionID=1 ,PageTitle="Parco adige sud" , Raccolta="local, regional, adige", Percorso="Verona, Zevio, Legnago", Description=""},
                new Tour{Difficulty="3: medium",TumbUrl = "cca.webp", Color="purple",Distanza=56,Salita=80,Discesa=130,MapCenter="[45.42, 10.98]",MapZoom=10,GeoJsonFile="cca.json",TourCollectionID=1 ,PageTitle="claudia augusta" , Raccolta="local, regional", Percorso="Verona, Castel d'Azzano,Isola della Scala, Ostiglia", Description=""},
                new Tour{Difficulty="3: medium",TumbUrl="cdr.webp",Color="blue",Distanza=32,Salita=10,Discesa=60, MapCenter="[45.42, 10.98]",MapZoom=10,GeoJsonFile="cdr.json",TourCollectionID=1 ,PageTitle="ciclovia delle risorgive" , Raccolta="local", Percorso="Zevio, Castel d'Azzano, Villafranca, Valeggio sul Mincio", Description=""},
                new Tour{Difficulty="3: medium",TumbUrl = "vrma.webp", Color="purple",Distanza=44,Salita=50,Discesa=100,MapCenter="[45.42, 10.76]",MapZoom=10,GeoJsonFile="vrma.json",TourCollectionID=1 ,PageTitle="Verona Mantova" , Raccolta="regional, local", Percorso="Verona, Dossobuono, Povegliano, Villafranca, Mantova", Description=""},
                new Tour{Difficulty="4: challenging",TumbUrl="i1.webp",Color="red",Distanza=112,Salita=830,Discesa=860,MapCenter="[45.42, 10.98]",MapZoom=10,GeoJsonFile="i1.json",TourCollectionID=1 ,PageTitle="itinerario 1" , Raccolta="regional, adige, collina", Percorso="Garda, Rivoli, Bussolengo, Verona, Soave, Vicenza", Description=""},
                new Tour{Difficulty="3: medium",TumbUrl = "valpo11.webp", Color="blue",Distanza=20,Salita=130,Discesa=100, MapCenter="[45.55, 10.8]",MapZoom=10,GeoJsonFile="valpo11.json",TourCollectionID=1 ,PageTitle="valpolicella tour 11" , Raccolta="valpolicella, local", Percorso="Verona, Domegliara", Description=""},
                new Tour{Difficulty="5: very challenging",TumbUrl="valpo12.webp",Color="blue",Distanza=32,Salita=1120,Discesa=260, MapCenter="[45.55, 10.95]",MapZoom=10,GeoJsonFile="valpo12.json",TourCollectionID=1 ,PageTitle="valpolicella tour 12" , Raccolta="valpolicella, local, montagna", Percorso="Verona, Avesa, Sant'Anna d'Alfaedo, Fosse", Description=""},
                new Tour{Difficulty="4: challenging",TumbUrl = "ev7.webp", Color="blue",Distanza=33,Salita=524,Discesa=150, MapCenter="[45.55, 10.9]",MapZoom=10,GeoJsonFile="valpo46.json",TourCollectionID=1 ,PageTitle="valpolicella tour 46" , Raccolta="valpolicella, local, adige, collina", Percorso="Verona, Domegliara, Dolcè, Peri", Description=""},
                new Tour{Difficulty="5: very challenging",TumbUrl = "aida.webp", Color="red",Distanza=178,Salita=800,Discesa=930, MapCenter="[45.55, 10.9]",MapZoom=10,GeoJsonFile="aida.json",TourCollectionID=1 ,PageTitle="ciclovia Aida" , Raccolta="national, collina", Percorso="Brescia,Peschiera del Garda, Sommacampagna, Verona,Soave, Vicenza", Description=""}

            };

            context.Tours.AddRange(tours);
            context.SaveChanges();

            var tourMarkers = new TourMarker[]
            {
                new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.28, 10.73]"},
                new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.38, 10.7]"},
                //new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.45, 10.695]"},
                new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.55, 10.719]"},
                new TourMarker{TourID=3, Classname="bl-div-icon", Html="EV7", IconSize="[35, 20]", Position="[45.62, 10.852]"},
                new TourMarker{TourID=15, Classname="bl-div-icon", Html="AIDA", IconSize="[40, 20]", Position="[45.45, 10.5515]"},
                new TourMarker{TourID=15, Classname="bl-div-icon", Html="AIDA", IconSize="[40, 20]", Position="[45.412, 10.85]"},
                new TourMarker{TourID=15, Classname="bl-div-icon", Html="AIDA", IconSize="[40, 20]", Position="[45.4, 11.125]"},
                new TourMarker{TourID=8, Classname="bl-div-icon", Html="Claudia augusta", IconSize="[100, 20]", Position="[45.22, 11.01145]"},
                new TourMarker{TourID=9, Classname="bl-div-icon", Html="CDR", IconSize="[40, 20]", Position="[45.35, 10.8]"},
                new TourMarker{TourID=9, Classname="bl-div-icon", Html="CDR", IconSize="[40, 20]", Position="[45.365, 11.06]"},
                new TourMarker{TourID=7, Classname="bl-div-icon", Html="Adige sud", IconSize="[65, 20]", Position="[45.32, 11.265]"},
                new TourMarker{TourID=10, Classname="bl-div-icon", Html="Verona Mantova", IconSize="[100, 20]", Position="[45.22, 10.817]"},
                new TourMarker{TourID=1, Classname="bl-div-icon", Html="Vigne e parchi", IconSize="[85, 20]", Position="[45.474, 10.775]"},        
                new TourMarker{TourID=2, Classname="bl-div-icon", Html="16", IconSize="[25, 20]", Position="[45.38, 10.80155]"},
                new TourMarker{TourID=4, Classname="bl-div-icon", Html="29", IconSize="[25, 20]", Position="[45.42, 10.7565]"},
                new TourMarker{TourID=5, Classname="bl-div-icon", Html="30", IconSize="[25, 20]", Position="[45.44, 10.794]"},
                new TourMarker{TourID=6, Classname="bl-div-icon", Html="35", IconSize="[25, 20]", Position="[45.44, 10.8365]"},
                new TourMarker{TourID=12, Classname="bl-div-icon", Html="11", IconSize="[25, 20]", Position="[45.52, 10.838]"},
                new TourMarker{TourID=13, Classname="bl-div-icon", Html="12", IconSize="[25, 20]", Position="[45.62, 10.9445]"},
                new TourMarker{TourID=11, Classname="bl-div-icon", Html="I1", IconSize="[20, 20]", Position="[45.469, 10.9]"},
                new TourMarker{TourID=11, Classname="bl-div-icon", Html="I1", IconSize="[20, 20]", Position="[45.55, 10.81915]"},
                new TourMarker{TourID=11, Classname="bl-div-icon", Html="I2", IconSize="[20, 20]", Position="[45.478687, 11.48]"},
                new TourMarker{TourID=11, Classname="bl-div-icon", Html="I2", IconSize="[20, 20]", Position="[45.409064, 11.265]"},
                new TourMarker{TourID=14, Classname="bl-div-icon", Html="46", IconSize="[25, 20]", Position="[45.62, 10.866]"},
                
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
