
function mostrarForm() {
    if ($('#formularioLivro').css('display') == 'none') {
        $('#formularioLivro').css('display', 'inline');
        $('#showless').css('display', 'inline');
        $('#add').css('display', 'none');
    }
    else {
        $('#formularioLivro').css('display', 'none');
        $('#add').css('display', 'inline');
        $('#showless').css('display', 'none');
    }
}

function editarLivro(livro) {
    alert(livro);
}

function excluirLivro(idLivro) {
    alert(idLivro);
}




