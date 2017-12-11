var uri = 'api/books';

$(document).ready(function () {
    // Send an AJAX request
    $.getJSON(uri)
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data, function (key, item) {
                // Add a list item for the product.
                $('<li>', { text: formatItem(item) }).appendTo($('#books'));
            });
        });
});

function formatItem(item) {
    return item.Book_Name + ': $' + item.Book_Price;
}

function find() {
    var id = $('#book_id').val();
    $.getJSON(uri + '/' + id)
        .done(function (data) {
            $('#book').text(formatItem(data));
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#book').text('Error: ' + err);
        });
}