$(document).ready(function () {
    Read_Districts();
    
$('#btn_AddDistrict').click(function () {
        $('#modal_AddDistrict').modal('show');
        $.ajax({
            url: '/Admin/District/AddDistrict',
            method: 'GET',
            dataType: 'html',
            success: function (response) {
                $('#modal_AddDistrict .modal-body').empty().html(response);
            },
            error: function () {
                toastr.error('something went wrong. please contact to administrator');
            }
        });
    });
});


function AddDistrictSuccess(result) {
    if (result == true) {
        $('#modal_AddDistrict').modal('hide');
        toastr.success('District saved successfully');
    }
}
function AddDistrictFaliure() {
    toastr.error('something went wrong. please contact to administrator!');
}

function Read_Districts() {
    $.ajax({
        url: '/Admin/District/Read_Districts',
        method: 'GET',
        dataType: 'json',
        success: function (response) {
            $('#grd_District').DataTable({
                data: response,
                paging: false,
                searching: false,
                scrollY: 300,
                scrollX: true,
                scrollCollapse: true,
                columns: [
                    {
                        'data': 'Name',
                        'render': function (data, type, row) {
                            return '<a href="#" style="cursor:pointer" onclick=UpdateDistrict("' + row.DistrictId + '")>' + row.Name + '</a>';
                        }
                    },
                    {'data':'Code'},
                    { 'data': 'StateName' },
                    { 'data':'CountryName'},
                    {
                        'data': 'IsActive',
                        'render': function (data) {
                            if (data == true) {
                                return '<span>Y</span>';
                            } else {
                                return '<span style="color:red">N</span>';
                            }
                        }
                    },
                    {
                        'data': 'DistrictId',
                        'render': function (data) {
                            var html = "<div class=\"btn-group\">";
                            html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
                            //html += "<i class=\"fa fa-caret-down\"></i>";
                            html += "</a>";
                            html += "<ul class=\"dropdown-menu pull-right\" role=\"menu\" >";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=UpdateDistrict('" + data + "')><i class='fa fa-edit'></i> Edit</a></li>";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=DeleteDistrict('" + data + "') ><i class='fa fa-remove'></i> Delete</a></li>";
                            html += "</ul>";
                            html += "</div>";
                            return html;
                        }
                    }
                ],
            });
        },
        error: function () {
            toastr.error('something went wrong. please contact to adminstrator!');
        }
    });
}

function UpdateDistrict(DistrictId) {
    $('#modal_UpdateDistrict').modal('show');
    $.ajax({
        url: '/Admin/District/UpdateDistrict',
        method: 'GET',
        dataType: 'html',
        data: { DistrictId: DistrictId },
        success: function (response) {
            $('#modal_UpdateDistrict .modal-body').empty().html(response);
        },
        error: function () {
            toastr.error('something went wrong. please contact to administrator!');
        }
    });
}
function DeleteDistrict(DistrictId) {
    $.ajax({
        url: '/Admin/District/RemoveDistrict',
        method: 'GET',
        dataType: 'json',
        data: { DistrictId: DistrictId },
        success: function (response) {
            if (response == true) {
                toastr.success('District removed successfully');
            } else {
                toastr.error('something went wrong.');
            }
        },
        error: function () {
            toastr.error('something went wrong. please contact to adminstrator!');
        }
    });
}


function UpdateDistrictSuccess(response) {
    if (response == true) {
        toastr.success('District updated successfully');
        $('#modal_UpdateDistrict').modal('hide');
    } else {
        toastr.error('something went wrong');
    }
}

function UpdateDistrictFaliure() {
    toastr.error('something went wrong.');
}