// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function deleteCat() {
    var id = $("#catToDeleteId").html();

    window.location = "Home/Delete/" + id;
}

function getCatToDelete(catName, id) {
    $("#catName").html(catName);
    $("#catToDeleteId").html(id);
}

function edit(id) {
    window.location = "Home/Edit/" + id
}

function handleAddCat() {
    var $button = $(".add-button-wrapper");
    var $form = $(".add-form-wrapper");

    $button.addClass("invisible");
    $form.removeClass("invisible");
    //$form.css("margin-top", "-40px");
}

function cancelAdd() {
    var $button = $(".add-button-wrapper");
    var $form = $(".add-form-wrapper");

    $form.addClass("invisible");
    $button.removeClass("invisible");
}
