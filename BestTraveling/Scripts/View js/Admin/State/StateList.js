    $(document).ready(function () {

        $.ajax({
            url: '/Admin/State/State_Read',
            method: 'GET',
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                $('#grd_State').DataTable({
                    data: result,
                    paging: false,
                    searching: false,
                    scrollY: 300,
                    columns: [
                        {
                            'data': 'Name',
                            'render': function (data, type, row) {
                                return '<a href="#" style=cursor:pointer; onclick=onUpdateState("'+row.StateId+'")>'+row.Name+'</a>';
                            }
                        },
                        { 'data': 'Code' },
                        //{'data':'Active'},
                        { 'data': 'CountryName' },
                        {
                            'data': 'StateId',
                            'render': function (data) {
                                var html = "<div class=\"btn-group\">";
                                html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
                                //html += "<i class=\"fa fa-caret-down\"></i>";
                                html += "</a>";
                                html += "<ul class=\"dropdown-menu pull-right bg-primary\" role=\"menu\" >";
                                html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=onUpdateState('" + data + "')><i class='fa fa-edit'></i> Edit</a></li>";
                                html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=DeleteState('" + data + "') ><i class='fa fa-remove'></i> Delete</a></li>";
                                html += "</ul>";
                                html += "</div>";
                                return html;
                            }
                        },
                    ]
                });
            },
            error: function (e) {
                toastr.error('something went wrong');
            }
        });

		//$('#example').DataTable({
        //	'paging': false,
        //	'scrollY': '450px',
        //	'searching': true,
        //	'autoWidth': true,
        //	'scrollCollapse': true,
        //	'footerCallback': false
        //});


        $('#btn_AddState').click(function () {
            $('#modal_AddState').modal('show');

            $.ajax({
                url: '/Admin/State/AddState',
                method: 'GET',
                dataType: 'html',
                contentType: 'application/json; charset=utf-8',
                success: function (result) {
                    $('#modal_AddState .modal-body').empty().html(result);
                },
                error: function (e) {
                    toastr.error('something went wrong!');
                }
            });

        });
    });


function OnAddState(e) {
    if (e == true) {
        toastr.success('State saved successfully');
        $('#modal_AddState').modal('hide');
    } else {
        toastr.error('something went wrong!');
    }
}


function OnFailsAddState(e) {
    toastr.error('something went wrong. please contact to administrator');
}

function onUpdateState(stateId) {
    $('#modal_UpdateState').modal('show');

    $.ajax({
        url: '/Admin/State/UpdateState',
        method: 'GET',
        data: { StateId: stateId},
        dataType: 'html',
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            $('#modal_UpdateState .modal-body').empty().html(result);

        },
        error: function (e) {
            toastr.error('something went wrong. Please contact to administrator !111');
        }
    });


}



function OnUpdateStateSuccess(e) {
    if (e == true) {
        toastr.success('State updated successfully');
        $('#modal_UpdateState').modal('hide');
    } else {
        toastr.error('something went wrong !');
    }
}


function onFailsStateUpdate(e) {
    toastr.error('something went wrong');
}


function DeleteState(stateId) {
    $.ajax({
        url: '/Admin/State/DeleteState',
        method: 'GET',
        dataType: 'json',
        data: { StateId: stateId },
        success: function (result) {
            if (result == true) {
                toastr.success('State deleted successfully');
            } else {
                toastr.error('something went wrong!');
            }
        },
        error: function (e) {
            toastr.error('something went wrong. please contact to administrator');
        }
    });
}