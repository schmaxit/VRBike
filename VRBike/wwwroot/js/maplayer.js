function addLayer(JsonFile, lineweight, mapColor,linkUrl) {
  
    fetch("/geojson/" + JsonFile)
        .then((res) => res.json())
        .then((data) => {
            // add GeoJSON layer to the map once the file is loaded
            L.geoJson(data, {
                style: function (feature) {
                    return { color: mapColor, weight: lineweight, opacity: 1 };
                },
            })
                .addTo(map)
                .on("click", function (ev) {
                    window.location.href = linkUrl;
                   
                });
        });
}
