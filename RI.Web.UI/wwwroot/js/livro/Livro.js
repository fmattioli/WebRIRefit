const nomeController = 'Livro';
const url = `https://localhost:7054/api/v1`;

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

function editarLivro(livroId) {
    if ($('#formularioLivro').css('display') == 'none') {
        $('#formularioLivro').css('display', 'inline');
        $('#showless').css('display', 'inline');
        $('#add').css('display', 'none');
    }

    var endPoint = `${url}/${nomeController}/${livroId}`;

    $.ajax({
        method: "GET",
        url: endPoint,
        success: function (response) {
            if (isNullOrEmpty(response.mensagemRetorno)) {
                carretorTextoInput('descricao', response.result.descricaoLivro);
                carretorTextoInput('sigla', response.result.sigla);
                carretorTextoInput('sessao', response.result.sessao);
                carretorTextoInput('ultimasequencia', response.result.ultimaSequenciaUtilizada);
                carregarSelectPeloValor('controlaSeqLivro', response.result.controlaSequenciaDoLivro);
                carregarSelectPeloValor('seqatozero', response.result.permiteSequenciaDoAtoZero);
                carregarSelectPeloValor('tipolivro', response.result.livroTJ.idLivroTJ);
                carregarSelectBooleano('enviarDOI', response.result.enviarDOI);
                carregarSelectBooleano('apontarindisponibilidade', response.result.indisponibilidade);
                carregarSelectBooleano('controlaseqato', response.result.controlaSequenciaDoAto);
                carregarSelectBooleano('seqatoinicial', response.result.sequenciaInicialAtos);
                carregarSelectBooleano('validar_reg_anterior', response.result.validarRegistroAnterior);
                carregarSelectBooleano('permitegarantia', response.result.permiteDescreverGarantia);
                carregarSelectBooleano('permitegarantia', response.result.permiteDescreverGarantia);
                carregarSelectBooleano('transcricao', response.result.transcricao);
                carregarSelectBooleano('enviarBDL', response.result.enviaBDL);
                return;
            }

            M.toast({
                html: response.msgErro,
                classes: 'black darken-4 rounded',
            });

        },
        error: function (xhr, textStatus, errorThrown) {
            M.toast({
                html: "Erro ao obter dados para edição do livro",
                classes: 'carmesim darken-4 rounded',
            });
        }
    })
}

function excluirLivro(idLivro) {
    $('.modal').modal({
        dismissble: true
    });
    $('#modal').modal('open');
    $(".texto").text("Deseja realmente excluir?");

}




