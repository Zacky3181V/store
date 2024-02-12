// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let option = {
    animation: true,
    delay: 1250
}

function Toast() {
    let toastHTMLElement = document.getElementById("EpicToast");

    let toastElement = new bootstrap.Toast(toastHTMLElement, option);
    toastElement.show();
}