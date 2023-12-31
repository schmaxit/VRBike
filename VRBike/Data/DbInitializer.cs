﻿using VRBike.Models;
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
                new Tour{Difficulty="4: challenging",TumbUrl = "a1.webp", Color="blue",Distanza=25,Salita=730,Discesa=730, MapCenter="[45.55, 10.9845]",MapZoom=12,GeoJsonFile="a1.json",TourCollectionID=1 ,PageTitle="Grezzana tour A1" , Raccolta="local, collina, grezzana, valpolicella", Percorso="Grezzana, Vigo, monte Comun, Stallavena", Description="Suggestivo percorso in E-MTB intermedio, buon allenamento richiesto, da Grezzana verso il Monte Comun con un interessante passaggio sterrato sotto il monte Dordera. Molto panoramico sia sul versante della Valpantena che su quello della Valpolicella; in località Saline è possibile scorgere anche il Lago di Garda.",Active = true},
                new Tour{Difficulty="2: easy",TumbUrl = "11A.webp", Color="blue",Distanza=8,Salita=140,Discesa=30, MapCenter="[45.494663, 10.867992]",MapZoom=12,GeoJsonFile="11A.json",TourCollectionID=1 ,PageTitle="Valpolicella tour 11A" , Raccolta="local, collina, valpolicella", Percorso="Parona, Arbizzano, S. Maria, S. Vito, Moron, Negrar di Valpolicella", Description="Itinerario di accesso a Negrar da Parona. Presenta un percorso pianeggiante con due tratti sterrati prima di Arbizzano e tra Santa Maria e San Vito.\r\nIl percorso in direzione opposta (verso sud) è differente rispetto alla traccia GPS in rispetto della viabilità esistente: seguire la segnaletica).\r\nAdatto a tutte le biciclette, non richiede particolare allenamento.",Active = true},
                new Tour{Difficulty="2: easy",TumbUrl = "11B.webp", Color="blue",Distanza=8,Salita=63,Discesa=0, MapCenter="[45.494663, 10.867992]",MapZoom=12,GeoJsonFile="11B.json",TourCollectionID=1 ,PageTitle="Valpolicella tour 11B" , Raccolta="local, collina, valpolicella", Percorso="Valgatara, S. Floriano, Arbizzano, Quar, Arbizzano", Description="Collegamento da Arbizzano a Valgatara; pianeggiante ed asfaltato con esclusione del collegamento con Arbizzano. Su viabilità minore.\r\nAdatto a tutte le biciclette, non richiede particolare allenamento.",Active = true},
                new Tour{Difficulty="2: easy",TumbUrl = "16A.webp", Color="blue",Distanza=19,Salita=160,Discesa=160, MapCenter="[45.494663, 10.867992]",MapZoom=12,GeoJsonFile="16A.json",TourCollectionID=1 ,PageTitle="Valpolicella tour 16A" , Raccolta="local, collina, valpolicella", Percorso="Arcè, Bure, San Micheletto, Fumane, Casterna, San Pietro in Cariano, Pescantina", Description="Percorso pianeggiante con qualche limitata rampetta breve; due brevi tratti sterrati dopo Arcè e dopo San Pietro in Cariano; su viabilità minore è adatto a tutte le biciclette e non richiede particolare allenamento.",Active = true},
                new Tour{Difficulty="3: medium",TumbUrl = "47.webp", Color="blue",Distanza=27,Salita=778,Discesa=810, MapCenter="[45.522005, 10.889948]",MapZoom=12,GeoJsonFile="47.json",TourCollectionID=1 ,PageTitle="Valpolicella tour 47" , Raccolta="local, collina, valpolicella", Percorso="Negrar di Valp.-Marano di Valp.-Fumane--Mazzurega-San Giorgio di Valp.-Sant’Ambrogio di Valp.", Description="Da Negrar scavalcamento di tre dorsali pedemontane, la Masua, Marano e Cavalo;\r\ndecisamente movimentato con salite ripetute. Richiede allenamento alle salite e biciclette adatte.",Active = true},
                new Tour{Difficulty="2: easy",TumbUrl = "valsugana.webp", Color="blue",Distanza=40,Salita=120,Discesa=370, MapCenter="[46.047981, 11.459785]",MapZoom=12,GeoJsonFile="valsugana.json",TourCollectionID=1 ,PageTitle="Valsugana" , Raccolta="local, epmc", Percorso="Valsugana", Description="EPMC 2023",Active = true},
                new Tour{Difficulty="2: easy",TumbUrl = "bolzano.webp", Color="blue",Distanza=16,Salita=50,Discesa=50, MapCenter="[46.495938, 11.358688]",MapZoom=12,GeoJsonFile="bolzano.json",TourCollectionID=1 ,PageTitle="Bolzano" , Raccolta="local, collina, epmc", Percorso="Bolzano", Description="EPMC 2023",Active = true}
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
                new TourMarker{TourID=7, Classname="bl-div-icon", Html="1", IconSize="[20, 20]", Position="[45.365, 11.203545]"},
                new TourMarker{TourID=10, Classname="bl-div-icon", Html="Verona Mantova", IconSize="[100, 20]", Position="[45.22, 10.817]"},
                new TourMarker{TourID=10, Classname="bl-div-icon", Html="7", IconSize="[20, 20]", Position="[45.38, 10.911]"},
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
                new TourMarker{TourID=17, Classname="bl-div-icon", Html="11A", IconSize="[30, 20]", Position="[45.52, 10.93111]"},
                new TourMarker{TourID=18, Classname="bl-div-icon", Html="11B", IconSize="[30, 20]", Position="[45.52, 10.910]"},
                new TourMarker{TourID=19, Classname="bl-div-icon", Html="16A", IconSize="[30, 20]", Position="[45.52, 10.87257]"},
                new TourMarker{TourID=20, Classname="bl-div-icon", Html="47", IconSize="[25, 20]", Position="[45.55, 10.912]"},
                new TourMarker{TourID=21, Classname="bl-div-icon", Html="Valsugana", IconSize="[70, 20]", Position="[46.047981, 11.459785]"},
                new TourMarker{TourID=22, Classname="bl-div-icon", Html="Bolzano", IconSize="[60, 20]", Position="[46.495938, 11.358688]"},


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
                new Bikeapp { TourID = 17, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1323181940?ref=wtd&share_token=aUupbF2tuX2QDV1d7JyjMlxIYBvHxr5W52fFUwk7HuIfoDUrjf", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 17, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/11a-parona-arbizzano-s-maria-s-vito-moron-negrar-di-valpolicella?referrer=gpsies.com&fileId=octoxuwxlqpjexln",Icon="alltrails.png"},
                new Bikeapp { TourID = 18, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1323194329?ref=wtd&share_token=aiCKcis6MyinJ9gkSz6NgujXBudTF58V3QuY4EEpYhi9ZOve0O", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 18, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/11b-valgatara-s-floriano-arbizzano-quar-arbizzano?referrer=gpsies.com&fileId=qrbvuuiawwvyxijy",Icon="alltrails.png"},
                new Bikeapp { TourID = 19, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1323205541?ref=wtd&share_token=aPxkN7brOC0SaAKjN1GfEcEJBHQ4PP3p05IPpynSKCfE6EKFGf", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 19, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/16a-arce-bure-san-micheletto-fumane-casterna-san-pietro-in-cariano-pescantina?referrer=gpsies.com&fileId=tmgmcjfazatxcyon",Icon="alltrails.png"},
                new Bikeapp { TourID = 20, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1323213960?ref=wtd&share_token=aeebDG78LSBAqFmKgyU0WVw7xj4fCDCofMVnlUDXsdX4Mpb45X", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 20, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/47-negrar-di-valp-marano-di-valp-fumane-mazzurega-san-giorgio-di-valp-santambrogio-di-valp?u=m",Icon="alltrails.png"},
                
                new Bikeapp { TourID = 21, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1326222899?ref=wtd&share_token=ajEZasc8ICKGXiCbqIixAiPCSfiwMGGNSF32OYmaWBWOjnm4xl", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 21, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/valsugana-10-epmc-2023-158fc2d?u=m&sh=awpf2v",Icon="alltrails.png"},
                new Bikeapp{ TourID = 21, Title="Wikiloc" , Link="https://it.wikiloc.com/percorsi-bicicletta-da-turismo/valsugana-10-epmc-2023-148422308",Icon="wikiloc.png"},
                new Bikeapp{ TourID = 21, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=1e0Xjjx7HH1S-Z6fDJY_DGl8jqcOWYHc&usp=sharing",Icon="google.png"},

                new Bikeapp { TourID = 22, Title = "Komoot", Link = "https://www.komoot.com/it-it/tour/1326222559?ref=wtd&share_token=amk7QMk6wRs3VaG8zRrn3NChdujg55uU4eXrj1a0uJygfG9CU2", Icon = "komoot.svg" },
                new Bikeapp{ TourID = 22, Title="Alltrails" , Link="https://www.alltrails.com/it-it/explore/map/bolzano-10-epmc-2023-faad952?u=m&sh=awpf2v",Icon="alltrails.png"},
                new Bikeapp{ TourID = 22, Title="Wikiloc" , Link="https://it.wikiloc.com/percorsi-bicicletta-da-turismo/bolzano-10-epmc-2023-148422236",Icon="wikiloc.png"},
                new Bikeapp{ TourID = 22, Title="Google Maps" , Link="https://www.google.com/maps/d/u/0/edit?mid=1jPhyxAgtAAHf4b4zpmbPziqb_7Erat0&usp=sharing",Icon="google.png"}

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
                new Video{Icon="Video11A.webp", TourID =17, Title="Verona Bike, Valpolicella tour ufficiale 11A Parona Arbizzano, cicloturismo, GPS", Link ="https://youtu.be/3BK6OKA9JW4"},
            };

            context.Videos.AddRange(videos);
            context.SaveChanges();


        
        
        
        }
    }
}
