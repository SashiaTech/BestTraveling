$(document).ready(function () {
    Country_Read();
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
                toastr.error('Something went wrong.');
            }
        });


    });
});



function Country_Read() {
    $.ajax({
        url: '/Admin/Country/Country_Read',
        method: 'GET',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $('#grd_Country').DataTable({
                data: data,
                paging: false,
                searching: false,
                scrollY: 300,
                
                columns: [
                    { 'data': 'Name' },
                    { 'data': 'Code' },
                ],
            });
        },
        error: function () {
            toastr.error('something went wrong. please contact to administrator');
        }
    });
}

function onAddOperation(e) {
    if (e == true) {
        //alert('data saved successfully');
        toastr.success('Data saved successfully');
        $('#addCountryModal').modal('hide');
    }
    else {
        toastr.error('Something went wrong.');
    }
}
function onsuccess(e) {
    toastr.error('Something went wrong.');
}