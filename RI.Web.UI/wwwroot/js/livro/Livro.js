const nomeController = 'Livro';
const url = `https://localhost:7054/api/v1`;

function mostrarForm() {

    $('#btnEditar').css('display', 'none');
    $('#btnSalvar').css('display', 'inline');

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

function CarregarCamposEditarLivro(livroId) {
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
                carretorTextoInput('idlivro', response.result.id);
                carretorTextoInput('descricao', response.result.descricaoLivro);
                carretorTextoInput('sigla', response.result.sigla);
                carretorTextoInput('sessao', response.result.sessao);
                carretorTextoInput('ultimasequencia', response.result.ultimaSequenciaUtilizada);
                carregarSelectPeloValor('controlaSeqLivro', response.result.controlaSequenciaDoLivro);
                carregarSelectPeloValor('seqatozero', response.result.permiteSequenciaDoAtoZero);
                carregarSelectPeloValor('tipolivro', response.result.livroTJ.id);
                carregarSelectBooleano('enviarDOI', response.result.enviarDOI);
                carregarSelectBooleano('apontarindisponibilidade', response.result.indisponibilidade);
                carregarSelectBooleano('controlaseqato', response.result.controlaSequenciaDoAto);
                carregarSelectBooleano('seqatoinicial', response.result.sequenciaInicialAtos);
                carregarSelectBooleano('validar_reg_anterior', response.result.validarRegistroAnterior);
                carregarSelectBooleano('permitegarantia', response.result.permiteDescreverGarantia);
                carregarSelectBooleano('permitegarantia', response.result.permiteDescreverGarantia);
                carregarSelectBooleano('transcricao', response.result.transcricao);
                carregarSelectBooleano('enviarBDL', response.result.enviaBDL);
                $('#btnSalvar').css('display', 'none');
                $('#btnEditar').css('display', 'inline');
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

function editarLivro() {
    var livro = {

    };

    var endPoint = `${url}/${nomeController}/EditarLivro/`;

    $.ajax({
        method: "PUT",
        url: endPoint,
        dataType: "json",
        contentType: 'application/json; charset=UTF-8',
        data: JSON.stringify({
            "id": parseInt($('#idlivro').val()),
            "descricaoLivro": $('#descricao').val(),
            "sigla": $('#sigla').val(),
            "ultimaSequenciaUtilizada": $('#ultimasequencia').val(),
            "sessao": $('#sessao').val(),
            "controlaSequenciaDoAto": retornarTrueOrFalse($('#controlaseqato').val()),
            "PermiteSequenciaDoAtoZero": $('#seqatozero').val(),
            "controlaSequenciaDoLivro": $('#controlaSeqLivro').val(),
            "sequenciaInicialAtos": $('#seqatoinicial').val(),
            "permiteDescreverGarantia": $('#permitegarantia').val(),
            "enviarDOI": retornarTrueOrFalse($('#enviarDOI').val()),
            "validarRegistroAnterior": retornarTrueOrFalse($('#validar_reg_anterior').val()),
            "indisponibilidade": retornarTrueOrFalse($('#apontarindisponibilidade').val()),
            "transcricao": retornarTrueOrFalse($('#transcricao').val()),
            "enviaBDL": parseInt($('#enviarBDL').val()),
            "livroTJ": {
                "id": $('#tipolivro').val(),
                "descricao": $('#tipolivro').val()
            }
        }),

        success: function (response) {

            if (isNullOrEmpty(response.mensagemRetorno)) {
                location.reload(true);
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
    console.log(livro);
}

function excluirLivro(idLivro) {
    $('.modal').modal({
        dismissble: true
    });
    $('#modal').modal('open');
    $(".texto").text("Deseja realmente excluir?");

}




