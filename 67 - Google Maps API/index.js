google.maps.event.addDomListener(window, "load", function () {

    var map = new google.maps.Map(document.getElementById("myMap"), { zoom: 16 });

    navigator.geolocation.watchPosition(function (position) {

        let latitude = position.coords.latitude;
        let longitude = position.coords.longitude;

        let latLng = new google.maps.LatLng(latitude, longitude);

        let infoWindow = new google.maps.InfoWindow({
            map: map,
            position: latLng,
            content: "You are here..."
        });

        map.setCenter(latLng);
    }, function (error) {
        alert(error.message);
    });

});