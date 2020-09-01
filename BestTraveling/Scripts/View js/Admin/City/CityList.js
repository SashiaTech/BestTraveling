$(document).ready(function () {
    Read_Cities();


    //$('#example').DataTable({
    //    'paging': false,
    //    'scrollY': '450px',
    //    'scrollX': true,
    //    'searching': true
    //});


    $('#btn_AddCity').click(function () {
        $('#modal_AddCity').modal('show');

        $.ajax({
            url: '/Admin/City/AddCity',
            method: 'GET',
            dataType: 'html',
            success: function (response) {
                $('#modal_AddCity .modal-body').empty().html(response);
            },
            error: function () {
                toastr.error('something went wrong. please conatact to administrator !');
            }
        });
    });
});


function AddCitySuccess(flag) {
    if (flag == true) {
        toastr.success('City saved successfully');
        $('#modal_AddCity').modal('hide');
    }
    else {
        toastr.error('something went wrong !');
    }
}

function AddCityFailure() {
    toastr.error('something went wrong !');
}

function Read_Cities() {
    $.ajax({
        url: '/Admin/City/Read_Cities',
        method: 'GET',
        dataType: 'json',
        success: function (response) {
            //$('#grd_City').DataTable({

            //});

            $('#grd_City').DataTable({
                data: response,
                paging: false,
                searching: false,
                scrollY: 300,
                columns: [
                    {
                        'data': 'Name',
                        'render': function (data, type, row) {
                            return '<a href="#" style=cursor:pointer onClick=updateCity("' + row.CityId + '")>' + row.Name + '</a >';
                        }
                    },
                    { 'data': 'Code' },
                    {'data':'DistrictName'},
                    { 'data': 'StateName' },
                    {'data':'Country'},
                    {
                        'data': 'IsActive',
                        'render': function (data) {
                            if (data == true) {
                                return 'Y';
                            } else {
                                return 'N';
                            }
                        }
                    },
                    {
                        'data': 'CityId',
                        'render': function (data) {
                            var html = "<div class=\"btn-group\">";
                            html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
                            //html += "<i class=\"fa fa-caret-down\"></i>";
                            html += "</a>";
                            html += "<ul class=\"dropdown-menu pull-right\" role=\"menu\" >";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=updateCity('" + data + "')><i class='fa fa-edit'></i> Edit</a></li>";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=DeleteCity('" + data + "') ><i class='fa fa-remove'></i> Delete</a></li>";
                            html += "</ul>";
                            html += "</div>";
                            return html;
                        }
                    }
                ],
            });


        },
        error: function () { }
    });
}


function updateCity(CityId) {
    $('#modal_UpdateCity').modal('show');
    $.ajax({
        url: '/Admin/City/UpdateCity',
        method: 'GET',
        dataType: 'html',
        data: {CityId:CityId},
        success: function (response) {
            $('#modal_UpdateCity .modal-body').empty().html(response);
        },
        error: function () {
            toastr.error('something went wrong. please contact to administrator!');
        }
    });

}

function DeleteCity(CityId) {
    $.ajax({
        url: '/Admin/City/RemoveCity',
        method: 'GET',
        dataType: 'json',
        data: { CityId: CityId },
        success: function (response) {
            if (response == true) {
                toastr.success('City deleted successfully');
            } else {
                toastr.error('something went wrong!');
            }
            
        },
        error: function () {
            toastr.error('something went wrong!');
        }
    });
}

function UpdateCitySuccess(response) {
    if (response == true) {
        toastr.success('City updated successfully');
        $('#modal_UpdateCity').modal('hide');
    }
}

function UpdateCityFailure() {
    toastr.error('something went wrong!');
}