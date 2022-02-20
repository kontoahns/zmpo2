// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#movie-list').DataTable({
        "language": {
            "lengthMenu": "Pokaż _MENU_ na stronie",
            "zeroRecords": "Brak wyników",
            "info": "Strona _PAGE_ z _PAGES_",
            "infoEmpty": "Brak rekordów",
            "infoFiltered": "(Wyświetlono z _MAX_ wszystkich)",
            "search": "Szukaj:",
            "paginate": {
                "previous": "Poprzednia",
                "next": "Następna"
            }
        }
    } );
});