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
let center = true;

mobileAndTabletCheck = function () {
  let check = false;
  (function (a) {
    if (
      /(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino|android|ipad|playbook|silk/i.test(
        a
      ) ||
      /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(
        a.substr(0, 4)
      )
    )
      check = true;
  })(navigator.userAgent || navigator.vendor || window.opera);
  return check;
};

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

  console.log("passo da getmap 2");
    console.log(mapcenter);
    console.log(mapzoom);
  map = L.map("map");
  map.setView(viewCenter, zoomlevel);
  map.addControl(new L.Control.Fullscreen());
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

  map.on("click", function (e) {
    console.log("map click");
    if (map.customControl) {
      let cont = map.customControl.getContainer();
      console.log(center);
      center = false;
      cont.style.backgroundColor = "white";
      cont.style.color = "black";
    }
  });
  map.on("zoomend", function (e) {
    console.log("scripts zoom: " + e.target._zoom);
    zoomlevel = e.target._zoom;
  });

  Watermark = L.Control.extend({
    onAdd: function (map) {
      map.customControl = this;
      var container = L.DomUtil.create("input");
      container.type = "button";
      container.title = "center";
      container.value = "center";
      container.style.height = "40px";

      if (center) {
        container.style.backgroundColor = "blue";
        container.style.color = "white";
      } else {
        container.style.backgroundColor = "white";
        container.style.color = "black";
      }

      container.onclick = function (e) {
        L.DomEvent.stopPropagation(e);
        console.log("buttonClicked: " + center);
        center = !center;
        if (center) {
          container.style.backgroundColor = "blue";
          container.style.color = "white";
        } else {
          container.style.backgroundColor = "white";
          container.style.color = "black";
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

  //watermark({ position: "bottomleft" }).addTo(map);

  MyImg = L.Control.extend({
    onAdd: function (map) {
      map.mycustomImg = this;
      var img = L.DomUtil.create("img");
      img.src = "/images/location.svg";
      img.style.height = "60px";
      if (center) {
        img.src = "/images/location.svg";
      } else {
        img.src = "/image/locationGray.svg";
      }

      img.onclick = function (e) {
        L.DomEvent.stopPropagation(e);
        console.log("imgClicked: " + center);
        center = !center;
        if (center) {
          img.src = "/images/location.svg";
        } else {
          img.src = "/images/locationGray.svg";
        }
      };

      return img;
    },

    onRemove: function (map) {
      // Nothing to do here
    },
  });

  myImg = function (opts) {
    return new MyImg(opts);
  };

  myImg({ position: "bottomleft" }).addTo(map);
}

function addCircle() {
  console.log("add circle");
  circle = L.circleMarker([lat, lon], {
    color: "blue",
    fillColor: "blue",
    fillOpacity: 1,
    radius: 10,
    pane: "puntatore",
  }).addTo(map);
}

const controllo = mobileAndTabletCheck();
if (controllo) {
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

  const watchID = navigator.geolocation.watchPosition(
    showPosition,
    error,
    options
  );

  function showPosition(position) {
    lat = position.coords.latitude;
    lon = position.coords.longitude;
    console.log("position found: " + lat + " " + lon);
    //lat = 45.42;
    //lon = 10.98;
    if (map != undefined) {
      if (center) {
        map.setView([lat, lon], zoomlevel, { animation: true });
      }
      //
      if (circle != undefined) {
        circle.setLatLng([lat, lon]);
      } else {
        addCircle();
      }
    } else {
      console.log("no map");
      // getMap();
    }
  }
} else {
  console.log("desk");
  if (map != undefined) {
  } else {
    //getMap();
  }
}
