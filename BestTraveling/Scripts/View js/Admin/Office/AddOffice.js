$(document).ready(function () {
    Read_Operators();
   

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


function Read_Operators() {
    $.ajax({
        url: '/Admin/Operators/Read_Operators',
        method: 'GET',
        dataType: 'json',
        success: function (res) {
            $('#grd_OperatorList').DataTable({
                scrollY: 500,
                scrollX: true,
                paging: false,
                searching: false,
                data: res,
                columns: [
                    {
                        'data': 'Name',
                        'render': function (data, type, row) {
                            return '<a href="#" style=cursor:pointer onClick=pdateOperator("' + row.OperatorId + '")>' + row.Name + '</a >';
                        }
                    },
                    { 'data': 'Code' },
                    { 'data': 'Designation' },
                    { 'data': 'City' },
                    { 'data': 'Gender' },
                    {
                        'data': 'OperatorId',
                        'render': function (data) {
                            var html = "<div class=\"btn-group\">";
                            html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
                            //html += "<i class=\"fa fa-caret-down\"></i>";
                            html += "</a>";
                            html += "<ul class=\"dropdown-menu pull-right\" role=\"menu\" >";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=UpdateOperator('" + data + "')><i class='fa fa-edit'></i> Edit</a></li>";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=DeleteOperator('" + data + "') ><i class='fa fa-remove'></i> Delete</a></li>";
                            html += "</ul>";
                            html += "</div>";
                            return html;
                        }
                    }
                ],
            });
        },
        error: function () {
            toastr.error('something went wrong. please contact to administrator');
        }
    });
}


function DeleteOperator(OperatorId) {
    $.ajax({
        url: '/Admin/Operators/DeleteOperator',
        method: 'GET',
        dataType: 'json',
        data: { OperatorId: OperatorId },
        success: function (res) {
            if (res == true) {
                toastr.success('Operator deleted successfully.');
            } else {
                toastr.error('something went wrong!');
            }
        },
        error: function () {
            toastr.error('something went wrong. please contact to administrator!');
        }
    });
}