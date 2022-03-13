function AddMarker(latitude, longitude, title, icone, map) {
    var latLng = new google.maps.LatLng(latitude, longitude);
    var marker = new google.maps.Marker({
        position: latLng,
        title: title,
        icon: icone
    });
    marker.setMap(map);
}

function MonteOMapa() {
    var meuEndereco = new google.maps.LatLng(-22.905895419011326, -43.17685031645948);
    var mapOptions = {
        center: meuEndereco,
        zoom: 15,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("mapDiv"), mapOptions);
    return map;
}