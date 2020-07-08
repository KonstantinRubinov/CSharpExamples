window.onload = getAll;

var mainUrl = 'http://localhost:53084/api/'
var heroUrl = mainUrl + "heroes/";

function HeroesList(jdata) {
    htmlStr = "<table border='1'>";
    //if (Array.isArray(json['jdata'])) {
    for (var i = 0; i < jdata.length; i++) {
        htmlStr += "<tr>";
        htmlStr += "<td> " + jdata[i].id + "</td >";
        htmlStr += "<td> " + jdata[i].name + "</td >";
        ChooserToDelete(jdata[i].id + ", " + jdata[i].name);
        htmlStr += "</tr>";
    }
    //} else {
    //    htmlStr += "<tr><td> " + jdata.id + "</td >";
    //    htmlStr += "<td>" + jdata.name + "</td ></tr>";
    //}

    htmlStr += "</table>";
    return htmlStr;
}

function OneHero(jdata) {
    htmlStr = "<table border='1'>";
    htmlStr += "<tr><td> " + jdata.id + "</td >";
    htmlStr += "<td>" + jdata.name + "</td ></tr>";

    htmlStr += "</table>";
    return htmlStr;
}

function getAll() {
    fetch(heroUrl)
        .then(function (response) {
            return response.text();
        })
        .then(function (data) {
            heroes = JSON.parse(data);
            document.getElementById("heroes").innerHTML = HeroesList(heroes);
        });
}

function getById(id) {
    var id = document.getElementById("heroeIdToGet").value;
    fetch(heroUrl + id)
        .then(function (response) {
            return response.text();
        })
        .then(function (data) {
            heroes = JSON.parse(data);
            document.getElementById("heroes").innerHTML = OneHero(heroes);
        });
}

function addHero() {
    var name = document.getElementById("heroeName").value;
    var o = `{"name":"${name}"}`;
    fetch(heroUrl,
        {
            headers:
            {
                'Authorization': 'Basic JohnBryce',
                'content-type': 'application/json'
            },
            method: 'POST',
            body: o
        })
        .then(response => getAll());
}

function updateHero() {
    var id = document.getElementById("heroeIdToUpdate").value;
    var name = document.getElementById("heroeNameToUpdate").value;
    var o = `{"id":${id}, "name":"${name}"}`;
    fetch(heroUrl + id,
        {
            headers:
            {
                'Authorization': 'Basic JohnBryce',
                'content-type': 'application/json'
            },
            method: 'PUT',
            body: o
        })
        .then(response => getAll());
}

function deleteHero() {
    var id = document.getElementById("heroeIdToDelete").value;
    var o = `{"id":${id}"}`;
    alert(id);
    fetch(heroUrl + id,
        {
            headers:
            {
                'Authorization': 'Basic JohnBryce',
                'content-type': 'application/json'
            },
            method: 'DELETE',
            body: o
        })
        .then(response => getAll());
}

function ChooserToDelete(hero) {
    var x = document.getElementById("toDelete");
    var option = document.createElement("option");
    option.text = hero;
    x.add(option);
}