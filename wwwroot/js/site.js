// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', (event) => {
    const popup = document.getElementById("validationPopup");
    const closeBtn = document.getElementsByClassName("close")[0];
    const validationSummary = document.querySelector('.popup-message-box');

    if (validationSummary && validationSummary.innerHTML.trim() !== "") {
        popup.style.display = "block";
    }

    closeBtn.onclick = function () {
        popup.style.display = "none";
    }

    window.onclick = function (event) {
        if (event.target == popup) {
            popup.style.display = "none";
        }
    }
});
