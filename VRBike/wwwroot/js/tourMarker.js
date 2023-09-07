var layerGroup = L.layerGroup();
function addTourMarker(classname, text, iconsize, position, linkurl) {
    console.log('tour marker: ' + text)
    var markersLayer = L.featureGroup();
    var Icon = L.divIcon({
        className: classname,
        html: text,
        iconSize: iconsize,
    });
    var marker = L.marker(position, { icon: Icon })
        .addTo(markersLayer)
    .on("click", function (ev) {
        window.location.href = linkurl;
    });
    layerGroup.addLayer(markersLayer);
    map.addLayer(layerGroup);
}