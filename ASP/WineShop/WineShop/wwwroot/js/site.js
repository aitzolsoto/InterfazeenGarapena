// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*Saskira gehitzeko*/
$(document).ready(function () {
    $(".AddLink").click(function (e) {
        e.preventDefault();
        // Get the id from the link
        var recordToAdd = $(this).attr("data-id");
        var kantitatea = parseInt($(this).attr("data-kantitatea"));
        var salneurria = parseFloat($(this).attr("data-salneurria"));
        var guztira = parseFloat($("#cart-total").text());
        if (recordToAdd !== '') {
            // Perform the ajax put
            $.post("/Saskia/SaskiaGehituAjax", { "id": recordToAdd, "kantitatea": kantitatea, "salneurria": salneurria, "guztira": guztira },
                function (data) {
                    // Successful requests get here
                    // Update the page elements
                    $("#item-count-" + recordToAdd).text(data.kantitatea.toString());
                    $("#cart-total").text((data.guztira + data.salneurria).toString());
                    $("#update-message").text(data.mezua);
                });
        }
    });
})

/*Saskira gehitzeko*/
$(document).ready(function () {
    $(".RemoveLink").click(function (e) {
        e.preventDefault();
        // Get the id from the link
        var recordToDel = $(this).attr("data-id");
        var kantitatea = parseInt($(this).attr("data-kantitatea"));
        var salneurria = parseFloat($(this).attr("data-salneurria"));
        var guztira = parseFloat($("#cart-total").text());
        if (recordToDel !== '') {
            // Perform the ajax put
            $.post("/Saskia/SaskiaKenduAjax", { "id": recordToDel, "kantitatea": kantitatea, "salneurria": salneurria, "guztira": guztira },
                function (data) {
                    // Successful requests get here
                    // Update the page elements
                    if (data.kantitatea > 0) {
                        $("#item-count-" + recordToDel).text(data.kantitatea.toString());
                        $("#cart-total").text((data.guztira - data.salneurria).toString());
                        $("#update-message").text(data.mezua);
                    } else {
                        $("#item-count-" + recordToDel).text(data.kantitatea.toString());
                        $("#update-message").text(data.mezua);
                    }
                    
                });
        }
    });
})

