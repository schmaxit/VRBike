var LocalLayerGroup = L.layerGroup();
function addLocalMarker(classname, text, iconsize, position, linkurl) {
   
    var localmarkersLayer = L.featureGroup();
    var Icon = L.divIcon({
        className: classname,
        html: text,
        iconSize: iconsize,
    });
    var marker = L.marker(position, { icon: Icon })
        .addTo(localmarkersLayer)
        .on("click", function (ev) {
            window.location.href = linkurl;
        });
    LocalLayerGroup.addLayer(localmarkersLayer);
    map.addLayer(LocalLayerGroup);
}


