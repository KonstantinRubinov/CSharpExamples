//window.onload = getAllEmployees;

var url = 'http://localhost:52042/api/employees/'

function EmployeesList(jdata) {
    htmlStr = "<table border='1'>";
    //if (Array.isArray(json['jdata'])) {
    for (var i = 0; i < jdata.length; i++) {
        htmlStr += "<tr>";
        htmlStr += "<td> " + jdata[i].ID + "</td >";
        htmlStr += "<td> " + jdata[i].FirstName + "</td >";
        htmlStr += "<td> " + jdata[i].LastName + "</td >";
        htmlStr += "<td> " + jdata[i].Gender + "</td >";
        htmlStr += "<td> " + jdata[i].Salary + "</td >";
        ChooserToDelete(jdata[i].ID + ", " + jdata[i].FirstName + " " + jdata[i].LastName);
        htmlStr += "</tr>";
    }
    htmlStr += "</table>";
    return htmlStr;
}

function OneEmployee(jdata) {
    htmlStr = "<table border='1'>";
    htmlStr += "<tr>";
    htmlStr += "<td> " + jdata.ID + "</td >";
    htmlStr += "<td> " + jdata.FirstName + "</td >";
    htmlStr += "<td> " + jdata.LastName + "</td >";
    htmlStr += "<td> " + jdata.Gender + "</td >";
    htmlStr += "<td> " + jdata.Salary + "</td >";
    htmlStr += "</tr>";
    htmlStr += "</table>";
    return htmlStr;
}

function getAllEmployees() {
    var UserName = document.getElementById("UserName").value;
    var Password = document.getElementById("Password").value;
    namepass = btoa(`${UserName}:${Password}`);
    fetch(url,
            {
                headers:
                {
                    'Authorization': 'Basic ' + namepass,
                    'content-type': 'application/json'
                },
                method: 'GET'
            }
        )
        .then(function (response) {
            return response.text();
        })
        .then(function (data) {
            heroes = JSON.parse(data);
            document.getElementById("heroes").innerHTML = EmployeesList(heroes);
        });
}

function getEmployeesById() {
    var id = document.getElementById("employeeIdToGet").value;
    //alert(id);
    fetch(url + id)
        .then(function (response) {
            return response.text();
        })
        .then(function (data) {
            heroes = JSON.parse(data);
            document.getElementById("heroes").innerHTML = OneEmployee(heroes);
        });
}

function addEmployees() {
    var FirstName = document.getElementById("FirstName").value;
    var LastName = document.getElementById("LastName").value;
    var Gender = document.getElementById("Gender").value;
    var Salary = document.getElementById("Salary").value;

    namepass = btoa(`all:all`);
    var o = `{"FirstName":"${FirstName}", "LastName":"${LastName}", "Gender":"${Gender}" ,"Salary":"${Salary}"}`;
    //alert(o);

    fetch(url,
            {
                headers:
                {
                    'Authorization': 'Basic ' + namepass,
                    'content-type': 'application/json'
                },
                method: 'POST',
                body: o
            }
        )
        .then(function (response) {
            return response.text();
        })
        .then(function (data) {
            heroes = JSON.parse(data);
            document.getElementById("heroes").innerHTML = OneEmployee(heroes);
        });
}

function updateEmployees() {
    var IdToUpdate = document.getElementById("IdToUpdate").value;
    var FirstNameToUpdate = document.getElementById("FirstNameToUpdate").value;
    var LastNameToUpdate = document.getElementById("LastNameToUpdate").value;
    var GenderToUpdate = document.getElementById("GenderToUpdate").value;
    var SalaryToUpdate = document.getElementById("SalaryToUpdate").value;

    var o = `{"ID":"${IdToUpdate}", "FirstName":"${FirstNameToUpdate}", "LastName":"${LastNameToUpdate}", "Gender":"${GenderToUpdate}" ,"Salary":"${SalaryToUpdate}"}`;
    
    //alert(o);
    
    fetch(url + IdToUpdate,
        {
            headers:
            {
                'Authorization': 'Basic JohnBryce',
                'content-type': 'application/json'
            },
            method: 'PUT',
            body: o
        })
        .then(function (response) {
            return response.text();
        })
        .then(function (data) {
            heroes = JSON.parse(data);
            document.getElementById("heroes").innerHTML = OneEmployee(heroes);
        });
}

function deleteEmployees() {
    var id = document.getElementById("employeeIdToDelete").value;
    var o = `{"id":${id}"}`;
    //alert(id);
    fetch(url + id,
        {
            headers:
            {
                'Authorization': 'Basic JohnBryce',
                'content-type': 'application/json'
            },
            method: 'DELETE',
            body: o
        })
        .then(response => getAllEmployees());
}

function ChooserToDelete(hero) {
    var x = document.getElementById("toDelete");
    var option = document.createElement("option");
    option.text = hero;
    x.add(option);
}