$(document).ready(function () {
    obterLivros();
});
function mostrarForm() {
    if ($('#formularioLivro').css('display') == 'none') {
        $('#formularioLivro').css('display', 'inline');
    }
    else {
        $('#formularioLivro').css('display', 'none');
    }
}

function editarLivro() {
    if ($('#formularioLivro').css('display') == 'none') {
        $('#formularioLivro').css('display', 'inline');
    }
    else {
        $('#formularioLivro').css('display', 'none');
    }
}

function obterLivros() {
    
    $.ajax({
        url: "https://localhost:7054/api/v1/Livro",
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            console.log(response);

        },
        error: function (xhr, textStatus, errorThrown) {
            M.toast({
                html: "Erro ao adicionar usuário",
                classes: 'black darken-4 rounded',
            });
        }
    });

}


