function AddOperator() {
    var OperatorModel = new Object();
    OperatorModel.OperatorId = '00000000-0000-0000-0000-000000000000';//$('#frm_AddOperator #OperatorId').val();
    OperatorModel.Name = $('#frm_AddOperator #Name').val();
    OperatorModel.Code = $('#frm_AddOperator #Code').val();
    OperatorModel.Contact = $('#frm_AddOperator #Contact').val();
    OperatorModel.DesignationId = $('#frm_AddOperator #DesignationId').val();
    OperatorModel.Address = $('#frm_AddOperator #Address').val();
    OperatorModel.CountryId = $('#frm_AddOperator #CountryId').val();
    OperatorModel.StateId = $('#frm_AddOperator #StateId').val();
    OperatorModel.CityId = $('#frm_AddOperator #CityId').val();
    OperatorModel.DistrictId = '00000000-0000-0000-0000-000000000000';
    OperatorModel.CreatedBy = '00000000-0000-0000-0000-000000000000';
    OperatorModel.IsDeleted = false;
    OperatorModel.CreatedDateTime = '2020-09-09 08:45:17.113';
    OperatorModel.ModifiedBy = '00000000-0000-0000-0000-000000000000';
    OperatorModel.ModifiedDateTime = '2020-09-09 08:45:17.113';
    OperatorModel.AddressId = '00000000-0000-0000-0000-000000000000';
    OperatorModel.GenderId = $('#frm_AddOperator #GenderId').val();

    



    debugger
    $.ajax({
        url: '/Admin/Operators/AddOperator',
        method: 'POST',
        dataType: 'json',
        data: { model: OperatorModel},
        success: function (res) {
            if (res == true) {
                toastr.success('Operator added successfully.');
            }
        },
        error: function () {
            toastr.error('something went wrong. please contact to administrator!');
        }
    });

}