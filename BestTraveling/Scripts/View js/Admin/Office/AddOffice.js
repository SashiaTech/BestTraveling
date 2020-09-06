$(document).ready(function () {
    alert('test');
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