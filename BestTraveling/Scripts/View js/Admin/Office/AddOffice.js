$(document).ready(function () {

    $('#grd_OperatorList').DataTable({
        scrollY: 500,
        scrollX: true,
        paging: false,
        searching:false,
    });

    $('#btn_AddOperator').click(function () {
        $('#modal_AddOperator').modal('show');

    });


    $('#btn_AddOperator').click(function () {
        $('#modal_AddOperator').modal('show');
        $.ajax({
            url: '/Admin/Operators/AddOperator',
            method: 'GET',
            dataType: 'html',
            success: function (response) {
                $('#modal_AddOperator .modal-body').empty().html(response);        
            },
            error: function () {
                toastr.error('something went wrong. please contact to administrator!');
            }
        });
    });
});

function AddOfficeSuccess(result) {
    if (result == true) {
        toastr.success('Office saved successfully.');
    } else {
        toastr.error('someting went wrong!');
    }
}

function AddOfficeFailure() {
    toastr.error('something went wrong!');
}


function UpdateOfficeSuccess(result) {
    if (result == true) {
        toastr.success('Office updated successfully.');
    } else {
        toastr.error('something went wrong!');
    }
}

function UpdateOfficeFailure() {
    toastr.error('something went wrong!');
}


