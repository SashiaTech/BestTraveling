$(document).ready(function () {
   
    $('#btn_AddCountry').click(function () {
        $('#addCountryModal').modal('show');

        $.ajax({
            url: '/Admin/Country/AddCountry',
            dataType: 'html',
            contentType: 'application/json; charset=utf-8',
            method: 'GET',
            success: function (result) {
                //alert(result);
                $('#addCountryModal .modal-body').empty().html(result);
            },
            error: function (result) {
                //alert('error' + result);
            }
        });


    });
});

function onAddOperation(e) {
    if (e == true) {
        alert('data saved successfully');
        $('#addCountryModal').modal('hide');
    }
    else {
        alert('something went wrong');
    }
}
function onsuccess(e) {
    alert('something went wrong');
}