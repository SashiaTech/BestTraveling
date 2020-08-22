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
                        { 'data': 'Name' },
                        { 'data': 'Code' },
                        //{'data':'Active'},
                        { 'data': 'Country' },
                        {
                            'data': 'StateId',
                            'render': function (data) {
                                var html = "<div class=\"btn-group\">";
                                html += "<a class=\"btn  dropdown-toggle\" type=\"button\" id=\"dropdownMenu1\" data-toggle=\"dropdown\"> <i class='fa fa-cog'></i>";
                                //html += "<i class=\"fa fa-caret-down\"></i>";
                                html += "</a>";
                                html += "<ul class=\"dropdown-menu pull-right bg-primary\" role=\"menu\" >";
                                html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=updateCountry('" + data + "')><i class='fa fa-edit'></i> Edit</a></li>";
                                html += "<li role=\"presentation\"><a role=\"menuitem\" tabindex=\"-1\" style='cursor:pointer' onclick=DeleteCountry('" + data + "') ><i class='fa fa-remove'></i> Delete</a></li>";
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
