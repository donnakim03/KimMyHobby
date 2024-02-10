// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#calculateBtn').on('click', function () {
        calculateTotal(); // Run calculateTotal() function when they press on the button
    });

    function calculateTotal() {
        var price = 25; // current price per hour
        var totalCost = 0; // total cost estimation
        var enteredHours = parseFloat($('#hours').val()); // pull value from input by user on the webpage

        // Check if they entered a positive number
        if (enteredHours >= 0) {
            totalCost = enteredHours * price;
            $('#totalCost').text(totalCost.toFixed(2)); // changes the text of the tag with the id totalCost to whatever was the calculated total cost
        }
    }