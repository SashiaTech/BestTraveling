$(document).ready(function () {

    $.ajax({
        url: '/Admin/Office/Read_Offices',
        method: 'GET',
        dataType: 'json',
        success: function (result) {
            $('#grd_Office').DataTable({
                data: result,
                searching: false,
                scrollY: 350,
                scrollX: true,
                paging:false,
                columns: [
                    {
                        'data': 'Name',
                        'render': function (data, type, row) {
                            return '<a style="cursor:pointer" onclick=UpdateOffice("'+row.OfficeId+'")>'+row.Name+'</a>';
                        }
                    },
                    { 'data': 'Code' },
                    { 'data': 'CountryName' },
                    { 'data': 'StateName' },
                    { 'data': 'CityName' },
                    { 'data': 'Address1' },
                    {
                        'data': 'OfficeId',
                        'render': function (data) {
                            var html = "<div class=\"btn-group\">";
                            html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
                            //html += "<i class=\"fa fa-caret-down\"></i>";
                            html += "</a>";
                            html += "<ul class=\"dropdown-menu pull-right\" role=\"menu\" >";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=UpdateOffice('" + data + "')><i class='fa fa-edit'></i> Edit</a></li>";
                            html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=DeleteOffice('" + data + "') ><i class='fa fa-remove'></i> Delete</a></li>";
                            html += "</ul>";
                            html += "</div>";
                            return html;
                        }
                    }
                ]
            });
        },
        error: function () {
            toastr.error('something went wrong. please contact to administrator!');
        }
    });

    

});

function UpdateOffice(OfficeId) {
    window.location.href = '/Admin/Office/UpdateOffice?OfficeId='+OfficeId;
    //$.ajax({
    //    url: '/Admin/Office/UpdateOffice',
    //    dataType: 'html',
    //    method: 'GET',
    //    data: { OfficeId: OfficeId },
    //    success: function (result) {
    //        if (result == true) {
    //            toastr.success('Office updated successfully.');
    //        }
    //    },
    //    error: function () {
    //        toastr.error('something went wrong. please contact to administrator');
    //    }
    //});
}

function DeleteOffice(OfficeId) {

}