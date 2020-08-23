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
        success: function (result) {
            $('#grd_Country').DataTable({
                data: result,
                paging: false,
                searching: false,
                scrollY: 300,
                columns: [
                    {
                        'data': 'Name',
                        'render': function (data, type, row) {
                            return '<a href="#" style=cursor:pointer onClick=updateCountry("'+row.CountryId+'")>' + row.Name + '</a >';
                        }
                    },
                    { 'data': 'Code' },
                    {
                        'data':'CountryId',
                        'render': function (data) {
                            var html = "<div class=\"btn-group\">";
                            html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
                            //html += "<i class=\"fa fa-caret-down\"></i>";
                            html += "</a>";
                            html += "<ul class=\"dropdown-menu pull-right\" role=\"menu\" >";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=updateCountry('"+data+"')><i class='fa fa-edit'></i> Edit</a></li>";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=DeleteCountry('" + data + "') ><i class='fa fa-remove'></i> Delete</a></li>";
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


function onAddOperation(e) {
    if (e == true) {
        toastr.success('Data saved successfully');
        $('#addCountryModal').modal('hide');
    }
    else {
        toastr.error('Something went wrong.');
    }
}
//function onsuccess(e) {
//    toastr.error('Something went wrong.');
//}

function updateCountry(countryId) {
    $('#modal_UpdateCountry').modal('show');

    $.ajax({
        url: '/Admin/Country/UpdateCountry',
        method: 'GET',
        dataType: 'html',
        data: { CountryId: countryId },
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            $('#modal_UpdateCountry .modal-body').empty().html(result);
        },
        error: function (result) {
            toastr.error('something went wrong');
        }
    });
}

function onUpdateCountry(e) {
    toastr.success('Data saved successfully');
    $('#modal_UpdateCountry').modal('hide');
}

function onFailureUpdateCountry(e) {
    toastr.error('something went wrong. please contact to administrator');
}


function BuildActionMenu(data) {
    var html = "<div class=\"btn-group\">";
    html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
    html += "<i class=\"fa fa-caret-down\"></i>";
    html += "</a>";
    html += "<ul class=\"dropdown-menu pull-right edit-delte\" role=\"menu\" >";
    html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" href='" + SiteUrl + "/Admin/Country/UpdateCountry?CountryId=" + data + "'><i class='fa fa-edit'></i> Edit</a></li>";
    html += "<li role=\"presentation\"><a href='#' role=\"menuitem\" tabindex=\"-1\" onclick=DeleteGeneralJournal('" + data.GeneralJournalId + "') ><i class='fa fa-remove'></i> Delete</a></li>";
    html += "</ul>";
    html += "</div>";
    return html;
}

function DeleteCountry(CountryId) {
    alert(CountryId);
    $.ajax({
        url: '/Admin/Country/DeleteCountry',
        method: 'GET',
        data: { CountryId: CountryId },
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