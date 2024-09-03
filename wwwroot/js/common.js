window.showToastr = function (type, message) {
    if (type == "success") {
        toastr.success(message)
    }
    if (type == "error") {
        toastr.error(message)
    }
}

window.showSWT = function (type, message) {
    if (type == "success") {
        Swal.fire({
            title: "Good job!",
            text: message,
            icon: "success"
        });
    }
    if (type == "error") {
        Swal.fire({
            icon: "error",
            title: "Oops...",
            text: message,
            footer: '<a href="#">Why do I have this issue?</a>'
        });
    }
}
