document.addEventListener("DOMContentLoaded", function() {

    var invoiceCheck = document.querySelector('#invoiceCheck');
    console.log(invoiceCheck);
    var invoiceDiv = document.querySelector('#invoice');
    invoiceCheck.addEventListener("CheckboxStateChange", function(event) {
        invoiceDiv.classList.toggle("hidden");
        });

});