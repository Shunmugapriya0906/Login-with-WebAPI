var GetLogin = function () {
    var Username = $('#txtUsername').val();
    var Password = $('#txtpassword').val();
    var url = "/api/values/GetLogin";
    var data = JSON.stringify({ "Username": Username, "password": password });
    $.ajax({
        type: "Post",
        data: loginData,
        url: loginUrl,
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            alert(result)
        },
        error: function (result) {
            alert(result)
        }
    });
};