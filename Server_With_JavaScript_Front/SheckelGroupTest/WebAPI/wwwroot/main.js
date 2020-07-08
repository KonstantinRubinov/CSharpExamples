var mainUrl = 'http://localhost:51129/api/'
var userUrl = mainUrl + "users/";


function addUser() {
    var userId = document.getElementById("userId").value;
    var userNickName = document.getElementById("userNickName").value;
    var userGender = document.getElementById("userGender").value;
    var userBirthDate = document.getElementById("userBirthDate").value;
    var userMonthPay = document.getElementById("userMonthPay").value;
    var o = `{"userId":"${userId}", "userNickName":"${userNickName}", "userGender":"${userGender}", "userBirthDate":"${userBirthDate}",  "userMonthPay":"${userMonthPay}"}`;
    fetch('http://localhost:51129/api/users/',
        {
            headers:
            {
                'content-type': 'application/json'
            },
            method: 'POST',
            body: o
        }).then(function (response) {
            return response.text();
        }).then(function (data) {
            user = JSON.parse(data);
            document.getElementById("userId").value = user.userId;
            document.getElementById("userNickName").value = user.userNickName;
            document.getElementById("userGender").value = user.userGender;
            document.getElementById("userBirthDate").value = new Date(user.userBirthDate).toISOString().substring(0, 10);
            document.getElementById("userMonthPay").value = user.userMonthPay;
            document.getElementById("pensionPay").value = user.pensionPay;
        });
}