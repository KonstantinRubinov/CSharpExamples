window.onload = init;


var mainUrl = 'http://localhost:51245/api/';
var customersUrl = mainUrl + 'customers/';
var ordersUrl = mainUrl +'orders/';
var orderDetailsUrl = mainUrl +'orderDetails/';

function init() {
    var query = customersUrl
    fetch(query)
        .then(function (response) {
            return response.text();
        })
        .then(function (data) {
            customers = JSON.parse(data);
            document.getElementById("customersDiv").innerHTML = CustomersIDList(customers);
        });
}

function getOrders(e, s) {
    var el = e.target.innerText;
    var query = ordersUrl + el;
    fetch(query)
        .then(function (response) {
            return response.text();
        })
        .then(function (data) {

            orders = JSON.parse(data);
            document.getElementById("customerId").innerHTML = "Details about customer " + "<span id='forCustomerDetails' onclick='getCustomerDetails(event)'>" + el + "</span>";
            document.getElementById("ordersDiv").innerHTML = OrdersList(orders);
            document.getElementById("orderDetailsDiv").innerHTML = "";
        });
}

function getOrderDetails(e, s) {
    var el = e.target.innerText;
    var query = orderDetailsUrl + el;
    fetch(query)
        .then(function (response) {
            return response.text();
        })
        .then(function (data) {
            orderDetails = JSON.parse(data);
            document.getElementById("orderDetailsDiv").innerHTML = OrderDetailsList(orderDetails);
        });
}

function CustomersIDList(customers) {
    htmlStr = "<table>";

    for (var i = 1; i < customers.length; i++) {
        htmlStr += "<tr><td class='id' style='cursor:pointer' onclick='getOrders(event, 0)'>" + customers[i].CustomerID + "</td></tr>";
    }
    htmlStr += "</table>";
    return htmlStr;
}

function OrdersList(orders) {
    htmlStr = "<table border='1'>";
    htmlStr += "<tr>";
    htmlStr += "<td>" + "OrderID" + "</td>";
    htmlStr += "<td>" + "CustomerID" + "</td>";
    htmlStr += "<td>" + "EmployeeID" + "</td>";
    htmlStr += "<td>" + "OrderDate" + "</td>";
    htmlStr += "<td>" + "RequiredDate" + "</td>";
    htmlStr += "<td>" + "ShippedDate" + "</td>";
    htmlStr += "<td>" + "ShipVia" + "</td>";
    htmlStr += "<td>" + "Freight" + "</td>";
    htmlStr += "<td>" + "ShipName" + "</td>";
    htmlStr += "<td>" + "ShipAddress" + "</td>";
    htmlStr += "<td>" + "ShipCity" + "</td>";
    htmlStr += "<td>" + "ShipRegion" + "</td>";
    htmlStr += "<td>" + "ShipPostalCode" + "</td>";
    htmlStr += "<td>" + "ShipCountry" + "</td>";
    htmlStr += "<td>" + "ShipRegion" + "</td>";
    htmlStr += "</tr>";

    for (var i = 0; i < orders.length; i++) {
        htmlStr += "<tr>";
        htmlStr += "<td class='id' style='cursor:pointer' onclick='getOrderDetails(event, 0)'>" + orders[i].OrderID + "</td>";
        htmlStr += "<td>" + orders[i].CustomerID + "</td>";
        htmlStr += "<td>" + orders[i].EmployeeID + "</td>";
        htmlStr += "<td>" + orders[i].OrderDate + "</td>";
        htmlStr += "<td>" + orders[i].RequiredDate + "</td>";
        htmlStr += "<td>" + orders[i].ShippedDate + "</td>";
        htmlStr += "<td>" + orders[i].ShipVia + "</td>";
        htmlStr += "<td>" + orders[i].Freight + "</td>";
        htmlStr += "<td>" + orders[i].ShipName + "</td>";
        htmlStr += "<td>" + orders[i].ShipAddress + "</td>";
        htmlStr += "<td>" + orders[i].ShipCity + "</td>";
        htmlStr += "<td>" + orders[i].ShipRegion + "</td>";
        htmlStr += "<td>" + orders[i].ShipPostalCode + "</td>";
        htmlStr += "<td>" + orders[i].ShipCountry + "</td>";
        htmlStr += "<td>" + orders[i].ShipRegion + "</td>";
        htmlStr += "</tr>";
    }
    htmlStr += "</table>";
    return htmlStr;
}

function OrderDetailsList(orderDetails) {
    htmlStr = "<table border='1'>";
    htmlStr += "<tr>";
    htmlStr += "<td>" + "OrderID" + "</td>";
    htmlStr += "<td>" + "ProductID" + "</td>";
    htmlStr += "<td>" + "UnitPrice" + "</td>";
    htmlStr += "<td>" + "Quantity" + "</td>";
    htmlStr += "<td>" + "Discount" + "</td>";
    htmlStr += "</tr>";

    for (var i = 0; i < orderDetails.length; i++) {
        htmlStr += "<tr>";
        htmlStr += "<td class='id' style='cursor:pointer' onclick='getOrderDetails(event, 0)'>" + orderDetails[i].OrderID + "</td>";
        htmlStr += "<td>" + orderDetails[i].ProductID + "</td>";
        htmlStr += "<td>" + orderDetails[i].UnitPrice + "</td>";
        htmlStr += "<td>" + orderDetails[i].Quantity + "</td>";
        htmlStr += "<td>" + orderDetails[i].Discount + "</td>";
        htmlStr += "</tr>";
    }
    htmlStr += "</table>";
    return htmlStr;
}

function getCustomerDetails(e) {
    alert(e.target.innerText);
    if (document.getElementById("modelDialog").style.display === "")
        document.getElementById("modelDialog").style = "block";
    else document.getElementById("modelDialog").style = "";
}
