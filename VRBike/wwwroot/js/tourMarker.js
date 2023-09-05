function addTourMarker(classname, text, iconsize, position, linkurl) {
    console.log('marker position: ' + position)

var Icon = L.divIcon({
    className: classname,
    html: text,
    iconSize: iconsize,
});
    var marker = L.marker(position, { icon: Icon })
    .addTo(map)
    .on("click", function (ev) {
        window.location.href = linkurl;
    });
}