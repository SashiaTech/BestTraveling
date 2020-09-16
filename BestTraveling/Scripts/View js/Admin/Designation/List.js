$(document).ready(function () {debugger
    Designation_Read();
    $('#btn_AddDesignation').click(function () {
        $('#addDesignationModal').modal('show');

        $.ajax({
            url: '/Admin/Designation/AddDesignation',
            dataType: 'html',
            contentType: 'application/json; charset=utf-8',
            method: 'GET',
            success: function (result) {
                //alert(result);
                $('#addDesignationModal .modal-body').empty().html(result);
            },
            error: function (result) {
                toastr.error('Something went wrong.');
            }
        });


    });
});



function Designation_Read() {debugger
    $.ajax({
        url: '/Admin/Designation/Designation_Read',
        method: 'GET',
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            $('#grd_Designation').DataTable({
                data: result,
                paging: false,
                searching: false,
                scrollY: 300,
                columns: [
                    {
                        'data': 'Designation',
                        'render': function (data, type, row) {debugger
                            return '<a href="#" style=cursor:pointer onClick=updateDesignation("' + row.DesignationId + '")>' + row.Name + '</a >';
                        }
                    },
                    { 'data': 'Code' },
                    {
                        'data':'DesignationId',
                        'render': function (data) {debugger
                            var html = "<div class=\"btn-group\">";
                            html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
                            //html += "<i class=\"fa fa-caret-down\"></i>";
                            html += "</a>";
                            html += "<ul class=\"dropdown-menu pull-right\" role=\"menu\" >";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=updateDesignation('"+data+"')><i class='fa fa-edit'></i> Edit</a></li>";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=DeleteDesignation('" + data + "') ><i class='fa fa-remove'></i> Delete</a></li>";
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


function onAddOperation(e) {debugger
    if (e == true) {
        toastr.success('Data saved successfully');
        $('#addDesignationModal').modal('hide');
    }
    else {
        toastr.error('Something went wrong.');
    }
}
//function onsuccess(e) {
//    toastr.error('Something went wrong.');
//}

function updateDesignation(designationId) {debugger
    $('#modal_UpdateDesignation').modal('show');

    $.ajax({
        url: '/Admin/Designation/UpdateDesignation',
        method: 'GET',
        dataType: 'html',
        data: { DesignationId: designationId },
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            $('#modal_UpdateDesignation .modal-body').empty().html(result);
        },
        error: function (result) {
            toastr.error('something went wrong');
        }
    });
}

function onUpdateDesignation(e) {
    toastr.success('Data saved successfully');
    $('#modal_UpdateDesignation').modal('hide');
}

function onFailureUpdateDesignation(e) {
    toastr.error('something went wrong. Please contact to administrator');
}


//function BuildActionMenu(data) {debugger
//    var html = "<div class=\"btn-group\">";
//    html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
//    html += "<i class=\"fa fa-caret-down\"></i>";
//    html += "</a>";
//    html += "<ul class=\"dropdown-menu pull-right edit-delte\" role=\"menu\" >";
//    html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" href='" + SiteUrl + "/Admin/Designation/UpdateDesignation?DesignationId=" + data + "'><i class='fa fa-edit'></i> Edit</a></li>";
//    html += "<li role=\"presentation\"><a href='#' role=\"menuitem\" tabindex=\"-1\" href='" + SiteUrl + "/Admin/Designation/DeleteDesignation?DesignationId=" + data + "'><i class='fa fa-remove'></i> Delete</a></li>";
//    html += "</ul>";
//    html += "</div>";
//    return html;
//}

function DeleteDesignation(designationId) {debugger
    //alert(DesignationId);
    $.ajax({
        url: '/Admin/Designation/DeleteDesignation',
        method: 'GET',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        data: { DesignationId: designationId },
        success: function (result) {
            if (result == true) {
                toastr.success('Data deleted successfully');
            } else {
                toastr.error('something went wrong!');
            }
            
        },
        error: function (result) {
            toastr.error('something went wrong. please contact to administrator!');
        }
    });

}