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

                new Tour{Difficulty="1: very easy", TumbUrl="vigne.webp", Color="blue", Distanza=13,Salita=130,Discesa=150, MapCenter="[45.46, 10.76]",MapZoom=13, GeoJsonFile="bussolengo-lago.json", TourCollectionID=1, PageTitle="terre del custoza By bike tra vigne e parchi" , Raccolta="custoza, local, collina, gabanel", Percorso="Bussolengo, Pacengo, Garda", Description="Giro in e-bike facile. Adatto a ogni livello di allenamento. Superfici perlopiù asfaltate. Adatto a ogni livello di abilità.",Active=true},
                new Tour{Difficulty="2: easy",TumbUrl="c16.webp",Color="blue",Distanza=32,Salita=160,Discesa=130, MapCenter="[45.437513, 10.895911]",MapZoom=11, GeoJsonFile="16.json",TourCollectionID=1,PageTitle="terre del custoza tour 16" , Raccolta="custoza, local, valpolicella, adige, collina", Percorso="Villafranca, Sommacampagna, Lugagnano, Bussolengo, Pescantina, Cavaion", Description="ciclovia tra Terre del Custoza e Valpolicella,Giro in bici facile. Adatto a ogni livello di allenamento. Superfici perlopiù asfaltate. Adatto a ogni livello di abilità.",Active=true},
                new Tour{Difficulty="3: medium",TumbUrl="ev7.webp",Color="red", Distanza=133,Salita=590,Discesa=740, MapCenter="[45.46, 10.76]",MapZoom=10,GeoJsonFile="ev7.json",TourCollectionID=1,PageTitle="Eurovelo 7" , Raccolta="national, montagna, collina", Percorso="Rovereto, Garda, Lazise, Peschiera, Valeggio sul Mincio, Mantova", Description="Giro in e-bike per esperti. Ottimo allenamento richiesto. In alcune parti del Tour potresti dover spingere la bici.",Active=true},
                new Tour{Difficulty="2: easy",TumbUrl="c29.webp",Color="blue",Distanza=18,Salita=70,Discesa=170,MapCenter="[45.454336, 10.761687]",MapZoom=12,GeoJsonFile="29.json",TourCollectionID=1,PageTitle="terre del custoza tour 29" , Raccolta="custoza, local, collina, gabanel", Percorso="Bussolengo, Castelnuovo", Description="Giro in e-bike facile. Adatto a ogni livello di allenamento. Superfici perlopiù asfaltate. Adatto a ogni livello di abilità.", Active = true},
                new Tour{Difficulty="2: easy",TumbUrl = "c30.webp", Color="blue",Distanza=22,Salita=140,Discesa=170,MapCenter="[45.431512, 10.785236]",MapZoom=11,GeoJsonFile="30.json",TourCollectionID=1,PageTitle="terre del custoza tour 30" , Raccolta="custoza, local, collina", Percorso="Bussolengo, Palazzolo,san Giorgio in Salici, Custoza, Valeggio sul Mincio", Description="Giro in e-bike facile. Adatto a ogni livello di allenamento. Superfici perlopiù asfaltate. Adatto a ogni livello di abilità.",Active=true},
                new Tour{Difficulty="2: easy",TumbUrl="c35.webp", Color="blue",Distanza=11,Salita=110,Discesa=220,MapCenter="[45.44, 10.8365]",MapZoom=12,GeoJsonFile="35.json",TourCollectionID=1,PageTitle="terre del custoza tour 35" , Raccolta="custoza, local, collina, gabanel", Percorso="Bussolengo, Palazzolo, Sona, Sommacampagna", Description="Giro in e-bike facile. Adatto a ogni livello di allenamento. Superfici perlopiù asfaltate. Adatto a ogni livello di abilità.", Active = true},
                new Tour{Difficulty="3: medium",TumbUrl="adigesud.webp",Color="purple",Distanza=54,Salita=70,Discesa=100,MapCenter="[45.32, 11.265]",MapZoom=10,GeoJsonFile="adigesud.json",TourCollectionID=1 ,PageTitle="Parco adige sud" , Raccolta="local, regional, adige", Percorso="Verona, Zevio, Legnago", Description="tour 1 - Giro in E-MTB intermedio. Buon allenamento richiesto. Superfici perlopiù asfaltate. Adatto a ogni livello di abilità.", Active = true},
                new Tour{Difficulty="3: medium",TumbUrl = "cca.webp", Color="purple",Distanza=56,Salita=80,Discesa=130,MapCenter="[45.270618, 10.997126]",MapZoom=10,GeoJsonFile="cca.json",TourCollectionID=1 ,PageTitle="claudia augusta" , Raccolta="local, regional", Percorso="Verona, Castel d'Azzano,Isola della Scala, Ostiglia", Description="Giro in E-MTB intermedio. Buon allenamento richiesto. Alcune parti del percorso potrebbero essere non asfaltate o difficili da percorrere in bici.", Active = false},
                new Tour{Difficulty="3: medium",TumbUrl="cdr.webp",Color="blue",Distanza=32,Salita=10,Discesa=60, MapCenter="[45.346199, 10.918768]",MapZoom=11,GeoJsonFile="cdr.json",TourCollectionID=1 ,PageTitle="ciclovia delle risorgive" , Raccolta="local", Percorso="Zevio, Castel d'Azzano, Villafranca, Valeggio sul Mincio", Description="Giro in e-bike facile. Adatto a ogni livello di allenamento. Superfici perlopiù asfaltate. Adatto a ogni livello di abilità.", Active = true},
                new Tour{Difficulty="3: medium",TumbUrl = "vrma.webp", Color="purple",Distanza=44,Salita=50,Discesa=100,MapCenter="[45.313347, 10.858430]",MapZoom=10,GeoJsonFile="vrma.json",TourCollectionID=1 ,PageTitle="Verona Mantova" , Raccolta="regional, local", Percorso="Verona, Dossobuono, Povegliano, Villafranca, Mantova", Description="tour 7 - Giro in bici intermedio. Buon allenamento richiesto. Superfici perlopiù asfaltate. Adatto a ogni livello di abilità.", Active = true},
                new Tour{Difficulty="4: challenging",TumbUrl="i1.webp",Color="red",Distanza=112,Salita=830,Discesa=860,MapCenter="[45.42, 10.98]",MapZoom=10,GeoJsonFile="i1.json",TourCollectionID=1 ,PageTitle="itinerario 1" , Raccolta="regional, adige, collina", Percorso="Garda, Rivoli, Bussolengo, Verona, Soave, Vicenza", Description="Giro in e-bike per esperti. Buon allenamento richiesto. In alcune parti del Tour potresti dover spingere la bici.", Active = true},
                new Tour{Difficulty="3: medium",TumbUrl = "valpo11.webp", Color="blue",Distanza=20,Salita=130,Discesa=100, MapCenter="[45.494663, 10.867992]",MapZoom=12,GeoJsonFile="valpo11.json",TourCollectionID=1 ,PageTitle="valpolicella tour 11" , Raccolta="valpolicella, local", Percorso="Verona, Domegliara", Description="Giro in E-MTB intermedio. Adatto a ogni livello di allenamento. Alcune parti del percorso potrebbero essere non asfaltate o difficili da percorrere in bici.", Active = true},
                new Tour{Difficulty="5: very challenging",TumbUrl="valpo12.webp",Color="blue",Distanza=32,Salita=1120,Discesa=260, MapCenter="[45.55, 10.95]",MapZoom=10,GeoJsonFile="valpo12.json",TourCollectionID=1 ,PageTitle="valpolicella tour 12" , Raccolta="valpolicella, local, montagna, collina", Percorso="Verona, Avesa, Sant'Anna d'Alfaedo, Fosse", Description="Giro in e-bike per esperti. Ottimo allenamento richiesto. Superfici perlopiù asfaltate. Adatto a ogni livello di abilità.", Active = true},
                new Tour{Difficulty="4: challenging",TumbUrl = "ev7.webp", Color="blue",Distanza=33,Salita=524,Discesa=150, MapCenter="[45.55, 10.9]",MapZoom=10,GeoJsonFile="valpo46.json",TourCollectionID=1 ,PageTitle="valpolicella tour 46" , Raccolta="valpolicella, local, adige, collina ", Percorso="Verona, Domegliara, Dolcè, Peri", Description="46 Corno, Settimo, Ponton, Volargne, Ceraino, Dolcè, Peri Collegamento tra la Ciclabile del Sole e la Ciclabile della Terra di Forti", Active = true},
                new Tour{Difficulty="5: very challenging",TumbUrl = "aida.webp", Color="red",Distanza=178,Salita=800,Discesa=930, MapCenter="[45.55, 10.9]",MapZoom=10,GeoJsonFile="aida.json",TourCollectionID=1 ,PageTitle="ciclovia Aida" , Raccolta="national, collina", Percorso="Brescia,Peschiera del Garda, Sommacampagna, Verona,Soave, Vicenza", Description="bicitalia 12 - ciclovia pedemontana alpina tour 9 - terre del Custoza 16, Giro in e-bike per esperti. Ottimo allenamento richiesto. Alcune parti del percorso potrebbero essere non asfaltate o difficili da percorrere in bici.",Active = true},
                new Tour{Difficulty="4: challenging",TumbUrl = "a1.webp", Color="blue",Distanza=25,Salita=730,Discesa=730, MapCenter="[45.55, 10.9845]",MapZoom=12,GeoJsonFile="a1.json",TourCollectionID=1 ,PageTitle="Grezzana A1" , Raccolta="local, collina, grezzana, valpolicella", Percorso="Grezzana, Vigo, monte Comun, Stallavena", Description="Suggestivo percorso in E-MTB intermedio, buon allenamento richiesto, da Grezzana verso il Monte Comun con un interessante passaggio sterrato sotto il monte Dordera. Molto panoramico sia sul versante della Valpantena che su quello della Valpolicella; in località Saline è possibile scorgere anche il Lago di Garda.",Active = true}

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
                new TourMarker{TourID=15, Classname="bl-div-icon", Html="AIDA", IconSize="[35, 17]", Position="[45.45, 10.5515]"},
                new TourMarker{TourID=15, Classname="bl-div-icon", Html="AIDA", IconSize="[35, 17]", Position="[45.412, 10.85]"},
                new TourMarker{TourID=15, Classname="bl-div-icon", Html="AIDA", IconSize="[35, 17]", Position="[45.4, 11.125]"},
                new TourMarker{TourID=15, Classname="bl-div-icon", Html="AIDA", IconSize="[35, 17]", Position="[45.534132,  11.48]"},
                new TourMarker{TourID=8, Classname="bl-div-icon", Html="Claudia augusta", IconSize="[100, 20]", Position="[45.22, 11.01145]"},
                new TourMarker{TourID=9, Classname="bl-div-icon", Html="CDR", IconSize="[40, 20]", Position="[45.35, 10.8]"},
                new TourMarker{TourID=9, Classname="bl-div-icon", Html="CDR", IconSize="[40, 20]", Position="[45.365, 11.06]"},
                new TourMarker{TourID=7, Classname="bl-div-icon", Html="Adige sud", IconSize="[65, 20]", Position="[45.32, 11.265]"},
                new TourMarker{TourID=10, Classname="bl-div-icon", Html="Verona Mantova", IconSize="[100, 20]", Position="[45.22, 10.817]"},
                //new TourMarker{TourID=1, Classname="bl-div-icon", Html="Gabanel", IconSize="[57, 17]", Position="[45.471, 10.82]"},
                new TourMarker{TourID=1, Classname="bl-div-icon", Html="Vigne parchi", IconSize="[80, 17]", Position="[45.474, 10.77]"},        
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
                new TourMarker{TourID=16, Classname="bl-div-icon", Html="A1", IconSize="[25, 20]", Position="[45.55, 10.9845]"},


            };
            context.TourMarkers.AddRange(tourMarkers);
            context.SaveChanges();


            var bikeapps = new Bikeapp[]
            { 
                new Bikeapp{ TourID = 1, Title="Komoot" , Link="https://www.komoot.com/it-it/tour/1203647576?ref=wtd", Icon="komoot.svg"},
                new Bikeapp{ TourID = 7, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/percorso-gpx-f885a14?u=m&sh=awpf2v",Icon="alltrails.png"},
                new Bikeapp{ TourID = 7, Title="Komoot" , Link="https://www.komoot.com/it-it/tour/1207822756?ref=wtd",Icon="komoot.svg"},
                new Bikeapp{ TourID = 7, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=1ULFcri5u-SIZzEf7WXh07rPfFfxya9M&ll=45.31071978818107%2C11.154302999999981&z=11",Icon="google.png"},
                new Bikeapp{ TourID = 7, Title="Wikiloc" , Link="https://it.wikiloc.com/percorsi-bicicletta-da-turismo/adige-sud-bicitalia-ciclovie-di-qualita-146972161",Icon="wikiloc.png"},
                new Bikeapp{ TourID = 1, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=1-YNur1EyJzVb8_8NBTOuryR7UpG5aV0&ll=45.47117140879776%2C10.783753500000012&z=13",Icon="google.png"},
                new Bikeapp{ TourID = 3, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=1UD1cxGbGZQ58wTL3QX3Rw2H-hvw4SDM&ll=45.31238889168365%2C11.5305435&z=7",Icon="google.png"},
                new Bikeapp { TourID = 3, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1215486611?ref=wtd", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 15, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=1J0wTNtFUx8Mt3MOZ4ZUdXGkBNxPqwrM&ll=45.513595528633346%2C10.36688899999998&z=8",Icon="google.png"},
                new Bikeapp { TourID = 15, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1208693743?ref=wtd", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 11, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=1LWPYJ06IhP6uKCuQ_kZuxOn-5VhQ0Eg&ll=45.48344838029972%2C11.140536500000024&z=11",Icon="google.png"},
                new Bikeapp { TourID =11, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1210224640?ref=wtd", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 11, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/regione-veneto-itinerario-i1-i2-garda-vicenza-4607f7f?u=m&sh=awpf2v",Icon="alltrails.png"},
                new Bikeapp{ TourID = 10, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=16GPR_uSur_yhOZLKhfdX6SgiLTT04b0&ll=45.291885531590125%2C10.891790000000023&z=11",Icon="google.png"},
                new Bikeapp { TourID = 10, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1230271716?ref=wtd", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 10, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/percorso-gpx-2000f63?u=m&sh=awpf2v",Icon="alltrails.png"},
                new Bikeapp{ TourID = 10, Title="Wikiloc" , Link="https://it.wikiloc.com/percorsi-bicicletta-da-turismo/ciclovia-verona-mantova-140304049",Icon="wikiloc.png"},
                new Bikeapp { TourID = 9, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1207785858?ref=wtd", Icon = "komoot.svg" },
                new Bikeapp { TourID = 8, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1207886784?ref=wtd", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 2, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=1hMtToLXQu16wsnq_cgYvkGRIFXhw9yw&ll=45.377897912491235%2C10.81776600000003&z=13",Icon="google.png"},
                new Bikeapp { TourID = 2, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1233976926?ref=wtd", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 4, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=13hJjNr7JJN7MsHNf-SZtJv-mQj7NYhw&ll=45.44464427081479%2C10.7810985&z=12",Icon="google.png"},
                new Bikeapp { TourID = 4, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1205339619?ref=wtd", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 5, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=1ctYeG0yorE6IRGCV3ZgcRmDLbb_B98s&ll=45.41570037470551%2C10.785760000000003&z=12",Icon="google.png"},
                new Bikeapp { TourID = 5, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1214158997?ref=wtd", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 6, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=18WXxUe4thTOnDyCJ3I0PFTB-8dBbhGI&ll=45.441400055403825%2C10.824864000000032&z=13",Icon="google.png"},
                new Bikeapp { TourID = 6, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1213878467?ref=wtd", Icon = "komoot.svg" },            
                new Bikeapp { TourID = 12, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1265731690?ref=&share_token=aeDBLj0E64F4u6Ps4HUCOQ1yFFzZ3Mg7gebukk6vhGL9OeOAOW", Icon = "komoot.svg" },
                new Bikeapp { TourID = 13, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1268235279?ref=wtd&share_token=aDd96Os8CC0c27GOZ4atKl08kJu1A4F55JqHWxmfxNsYpccQ2N", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 13, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/recording/12-verona-fiamene-fosse?referrer=gpsies",Icon="alltrails.png"},
                new Bikeapp{ TourID = 14, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/map--116877?u=m",Icon="alltrails.png"},
                new Bikeapp{ TourID = 16, Title="Alltrails" , Link="https://www.alltrails.com/explore/map/map-363763e-6",Icon="alltrails.png"},
                new Bikeapp { TourID = 16, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1288204519", Icon = "komoot.svg" },


            }; 

            context.Bikeapps.AddRange(bikeapps);
            context.SaveChanges();

            var videos = new Video[]
            {
                new Video{Icon="vigne.jpg", TourID =1, Title="Verona ciclabile by bike tra vigne e parchi, Bussolengo Gabanel bike hostel bici grill, Pacengo, GPS", Link ="https://www.youtube.com/watch?v=OrTfywT4eFo"},
                new Video{Icon="sommacampagna-salionze.jpg", TourID =15, Title="AIDA, Verona Sommacampagna Salionze, Bicitalia 12, pedemontana alpina, GPS, cicloturismo", Link ="https://www.youtube.com/watch?v=CYaz8pxv7Q0"},
                new Video{Icon="verona-palazzo.jpg", TourID =15, Title="Ciclovia aida Verona da San Massimo a Palazzo, Bicitalia 12, pedemontana alpina, GPS, cicloturismo", Link ="https://www.youtube.com/watch?v=ajgP9QDNfKE"},
                new Video{Icon="rivoli-affi.jpg", TourID =3, Title="Verona Eurovelo 7, pista ciclabile Rivoli Veronese Affi, cicloturismo, full video, GPS, bici grill", Link ="https://www.youtube.com/watch?v=hhtVDTyU5E4"},
                new Video{Icon="salionze-peschiera.jpg", TourID =3, Title="Salionze Peschiera cicloturismo, eurovelo 7, Bicitalia 1, Mantova 1, E6 regione veneto GPS", Link ="https://www.youtube.com/watch?v=gjpAFKG1spk"},
                new Video{Icon="rivoli-bussolengo.jpg", TourID=11, Title="Regione Veneto I1, Rivoli Bussolengo, canale Biffis passando da parco eolico, GPS, cicloturismo,", Link ="https://www.youtube.com/watch?v=0RQ0pLAd7x4"},
                new Video{Icon="adigesud.jpg", TourID =7, Title="Adige sud Verona Zevio Full Video GPS (ciclopedonale Marco Pantani), cicloturismo, ebike", Link ="https://www.youtube.com/watch?v=LGUyEcGm2Uw"},
                new Video{Icon="verona-bussolengo.jpg", TourID =11, Title="ciclabile regione veneto I1, Verona, Bussolengo, Fuul Video GPS, cicloturismo, Biffis", Link ="https://www.youtube.com/watch?v=QInQaADQAH4"},
                new Video{Icon="camuzzoni.jpg", TourID =11, Title="Verona Pista ciclabile, Diga Chievo Porta Palio canale Camuzzoni Full Video GPS, cicloturismo, ebike", Link ="https://www.youtube.com/watch?v=skg_Wwkl2hU"},
                new Video{Icon="risorgiveYT.webp", TourID =9, Title="Verona ciclabile delle risorgive, Zevio fiume Adige Povegliano, Full video GPS, cicloturismo, ebike", Link ="https://www.youtube.com/watch?v=UFszpAUKCSc"},
            };

            context.Videos.AddRange(videos);
            context.SaveChanges();


        
        
        
        }
    }
}
