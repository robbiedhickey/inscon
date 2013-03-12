$(document).ready(function() {
    $('.datepicker').datepicker();

    // Grab focus on first field that has error 
    $("input[type=text]").first().focus();
});