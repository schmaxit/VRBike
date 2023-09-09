/*!
 * Start Bootstrap - Bare v5.0.9 (https://startbootstrap.com/template/bare)
 * Copyright 2013-2023 Start Bootstrap
 * Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-bare/blob/master/LICENSE)
 */
// This file is intentionally blank
// Use this file to add JavaScript to your project
var lat;
var lon;
var map;
var circle;
var zoomlevel = 10;
var viewCenter = [45.42, 10.98];
let viewMinZoom = 9;
let center = false;

function getMap(mapcenter, mapzoom, mapminzoom) {
  if (mapcenter != undefined) {
    viewCenter = mapcenter;
  }
  if (mapzoom != undefined) {
    zoomlevel = mapzoom;
  }
  if (mapminzoom != undefined) {
    viewMinZoom = mapminzoom;
  }

    map = L.map("map",{
        scrollWheelZoom: 'center',
        fullscreenControl: true,
        fullscreenControlOptions: {
            position: 'topleft'
        }
    });

  map.setView(viewCenter, zoomlevel);
  map.createPane("puntatore");
  map.getPane("puntatore").style.zIndex = 650;
  map.getPane("puntatore").style.pointerEvents = "none";
  map.createPane("local");
  map.getPane("local").style.zIndex = 600;
  map.getPane("markerPane").style.zIndex = 700;
  var principale = L.tileLayer(
    "https://tile.openstreetmap.org/{z}/{x}/{y}.png",
    {
      maxZoom: 18,
      minZoom: viewMinZoom,
      crossOrigin: "",
      attribution:
        '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>',
    }
  ).addTo(map);

    map.on("zoomend", function (e) {
   
        zoomlevel = e.target._zoom;
        if (map.getZoom() >= 11) {
          
            map.addLayer(LocalLayerGroup);
        } else {
            map.removeLayer(LocalLayerGroup);
        }
      
    });
  
    var container = L.DomUtil.create("input", "navContainer");
  Watermark = L.Control.extend({
    onAdd: function (map) {
      map.customControl = this;
     
      container.type = "button";
          container.title = "center";
          container.style.height = "40px";
      

      if (center) {
        container.style.backgroundColor = "blue";
          container.style.color = "white";
          container.value = "stop navigation";
      } else {
        container.style.backgroundColor = "white";
          container.style.color = "black";
          container.value = "start navigation";
      }

      container.onclick = function (e) {
        L.DomEvent.stopPropagation(e);
       
          center = !center;
     
        if (center) {
          container.style.backgroundColor = "blue";
            container.style.color = "white";
            container.value = "stop navigation";
            startWatch();
        } else {
          container.style.backgroundColor = "white";
            container.style.color = "black";     
            container.value = "start navigation";
            clearWatch();
        }
      };

      return container;
    },

    onRemove: function (map) {
      // Nothing to do here
    },
  });

  watermark = function (opts) {
    return new Watermark(opts);
  };

  watermark({ position: "bottomleft" }).addTo(map);

}

function addCircle() {

  circle = L.circleMarker([lat, lon], {
    color: "blue",
    fillColor: "blue",
    fillOpacity: 1,
    radius: 10,
    pane: "puntatore",
  }).addTo(map);
}

const options = {
    enableHighAccuracy: true,
    maximumAge: 5000,
    timeout: 5000,
};

function error(error) {
    console.log("no position detected");
    lat = 45.42;
    lon = 10.98;
}

function showPosition(position) {
    lat = position.coords.latitude;
    lon = position.coords.longitude;
    console.log("position found: " + lat + " " + lon);
   
    //lat = 45.42;
    //lon = 10.98;
    if (map != undefined) {
        if (center) {
            map.setView([lat, lon], zoomlevel, { animation: true });
            if (circle != undefined) {
                circle.setLatLng([lat, lon]);
                if (!map.hasLayer(circle)) {
                    map.addLayer(circle);
                }

                
            } else {
                addCircle();

            }
        }
        //

    } else {
        console.log("no map");
        // getMap();
    }
}

let watchID="";
function startWatch() {
    watchID = navigator.geolocation.watchPosition(
        showPosition,
        error,
        options
    );
};

function clearWatch() {
    navigator.geolocation.clearWatch(watchID);
  
    if (circle != undefined) {
        map.removeLayer(circle);
    }
};

  

