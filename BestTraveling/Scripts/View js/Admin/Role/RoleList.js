$(document).ready(function () {
    Read_Roles();

    //$('#example').DataTable({
    //    'paging': false,
    //    'scrollY': '450px',
    //    'searching': false,
    //    'autoWidth': true,
    //    'scrollCollapse': true,
    //    'footerCallback': false
    //});

    $('#btn_AddRole').click(function () {
        $('#modal_AddRole').modal('show');
        $.ajax({
            url: '/Admin/Role/AddRole',
            method: 'GET',
            dataType: 'html',
            success: function (response) {
                $('#modal_AddRole .modal-body').empty().html(response);
            },
            error: function () {
                toastr.error('something went wrong. please contact to administrator.');
            }
        });
    });

});

function Read_Roles() {
    $.ajax({
        url: '/Admin/Role/Read_Role',
        method: 'GET',
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            $('#grd_Role').DataTable({
                data: result,
                paging: false,
                searching: false,
                scrollY: 300,
                columns: [
                    {
                        'data': 'Name',
                        'render': function (data, type, row) {
                            return '<a href="#" style=cursor:pointer onClick=updateRole("' + row.RoleId + '")>' + row.Name + '</a >';
                        }
                    },
                    { 'data': 'Code' },
                    { 'data': 'Description' },
                    {
                        'data': 'RoleId',
                        'render': function (data) {
                            var html = "<div class=\"btn-group\">";
                            html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
                            //html += "<i class=\"fa fa-caret-down\"></i>";
                            html += "</a>";
                            html += "<ul class=\"dropdown-menu pull-right\" role=\"menu\" >";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=updateRole('" + data + "')><i class='fa fa-edit'></i> Edit</a></li>";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=DeleteRole('" + data + "') ><i class='fa fa-remove'></i> Delete</a></li>";
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


function updateRole(RoleId) {
    $.ajax({
        url: '/Admin/Role/UpdateRole',
        method: 'GET',
        dataType: 'html',
        data: { RoleId: RoleId },
        success: function (result) {
            $('#modal_UpdateRole').modal('show');
            $('#modal_UpdateRole .modal-body').empty().html(result);
        }, error: function () {
            toastr.error('something went wrong. please contact to administrator');
        }
    });
}

function DeleteRole(RoleId) {
    $.ajax({
        url: '/Admin/Role/RemoveRole',
        method: 'GET',
        dataType: 'json',
        data: { RoleId: RoleId },
        success: function (response) {
            if (response == true) {
                toastr.success('Role removed successfully.');
            } else {
                toastr.error('something went wrong.');
            }
        },
        error: function () {
            toastr.error('something went wrong.');
        }
    });
}


function AddRoleSuccess(e) {
    if (e == true) {
        $('#modal_AddRole').modal('hide');
        toastr.success('Role saved successfully.');
        //Read_Roles();
    } else {
        toastr.error('something went wrong.');
    }
}

function AddRoleFailure() {
    toastr.error('something went wrong.');
}

function UpdateRoleSuccess(e) {
    if (e == true) {
        $('#modal_UpdateRole').modal('hide');
        toastr.success('Role updated successfully');
    } else {
        toastr.error('something went wrong.');
    }
}

function UpdateRoleFailure() {
    toastr.error('something went wrong.');
}
