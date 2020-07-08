var mainUrl = 'http://localhost:51129/api/'
var userUrl = mainUrl + "users/";


function addUser() {
    var userId = $("#userId").val();
    var userNickName = $("#userNickName").val();
    var userGender = $("#userGender").val();
    var userBirthDate = $("#userBirthDate").val();
    var userMonthPay = $("#userMonthPay").val();
    var o = `{"userId":"${userId}", "userNickName":"${userNickName}", "userGender":"${userGender}", "userBirthDate":"${userBirthDate}",  "userMonthPay":"${userMonthPay}"}`;
    $.ajax('http://localhost:51129/api/users/',
        {
            contentType: "application/json",
            method: "post",
            data: o,
            success: function (resp) {
                $("#userId").val(resp.userId);
                $("#userNickName").val(resp.userNickName);
                $("#userGender").val(resp.userGender);
                $("#userBirthDate").val(new Date(resp.userBirthDate).toISOString().split('T')[0]);
                $("#userMonthPay").val(resp.userMonthPay);
                $("#pensionPay").val(resp.pensionPay);
            },
            error: function (req, status, err) {
                console.log('something went wrong', status, err);
            }
        }
    );
}