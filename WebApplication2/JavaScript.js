$(document).ready(function () {
    function sendData() {
        var a = $('#txtA').val();
        var b = $('#txtB').val();

        if (isNaN(a) || isNaN(b)) {
            alert('Vui lòng nhập giá trị hợp lệ cho đáy lớn , đáy nhỏ và chiều cao.');
            return;
        }

        var dataToSend = {
            soa: a,
            sob: b,
        };

        $.ajax({
            url: "WebForm1.aspx",
            type: "POST",
            data: JSON.stringify(dataToSend),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                $('#lblResult').text('Diện tích hình thang là: ' + response);
            },
            error: function (xhr, status, error) {
                $('#lblResult').text('Có lỗi xảy ra: ' + xhr.responseText);
            }
        });
    }

    $("#btnCalculate").click(function () {
        sendData();
    });
});
