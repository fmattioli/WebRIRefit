const nomeController = 'Livro';
const url = `https://localhost:7054/api/v1`;



function limparCampos() {
    $('#livroForm').trigger("reset");
    mostrarForm();
}
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
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem("tokenAuth")
        },
        success: function (response) {

            if (isNullOrEmpty(response.mensagemRetorno)) {
                carretorTextoInput('idlivro', response.result.id);
                carretorTextoInput('descricao', response.result.descricaoLivro);
                carretorTextoInput('sigla', response.result.sigla);
                carretorTextoInput('sessao', response.result.sessao);
                carretorTextoInput('ultimasequencia', response.result.ultimaSequenciaUtilizada);
                carregarSelectPeloValor('controlaSeqLivro', response.result.controlaSequenciaDoLivro);
                carregarSelectPeloValor('seqatozero', response.result.permiteSequenciaDoAtoZero);
                carregarSelectPeloValor('tipolivro', response.result.idLivroTJ);
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
    var formValido = true;
    $('input[type="text"]').each(function () {
        if ($.trim($(this).val()).length == 0) 
            formValido = false;
    });

    $('select').each(function () {
        if ($.trim($(this).val()).length == 0) 
            formValido = false;
    });

    if (formValido) {
        var endPoint = `${url}/${nomeController}/EditarLivro/`

        $.ajax({
            method: "PUT",
            url: endPoint,
            headers: {
                "Authorization": "Bearer " + sessionStorage.getItem("tokenAuth")
            },
            dataType: "json",
            contentType: 'application/json; charset=UTF-8',
            data: JSON.stringify({
                "id": parseInt($('#idlivro').val()),
                "descricaoLivro": $('#descricao').val(),
                "sigla": $('#sigla').val(),
                "ultimaSequenciaUtilizada": $('#ultimasequencia').val(),
                "sessao": $('#sessao').val(),
                "controlaSequenciaDoAto": retornarTrueOrFalse(parseInt($('#controlaseqato').val())),
                "PermiteSequenciaDoAtoZero": $('#seqatozero').val(),
                "controlaSequenciaDoLivro": $('#controlaSeqLivro').val(),
                "sequenciaInicialAtos": parseInt($('#seqatoinicial').val()),
                "permiteDescreverGarantia": parseInt($('#permitegarantia').val()),
                "enviarDOI": retornarTrueOrFalse(parseInt($('#enviarDOI').val())),
                "validarRegistroAnterior": retornarTrueOrFalse(parseInt($('#validar_reg_anterior').val())),
                "indisponibilidade": retornarTrueOrFalse(parseInt($('#apontarindisponibilidade').val())),
                "transcricao": retornarTrueOrFalse(parseInt($('#transcricao').val())),
                "enviaBDL": parseInt($('#enviarBDL').val()),
                "idLivroTJ": $('#tipolivro').val()

            }),

            success: function (response) {
                if (isNullOrEmpty(response.mensagemRetorno)) {
                    M.toast({
                        html: "Livro alterado com sucesso.",
                        classes: 'carmesim darken-4 rounded',
                    });

                    mostrarForm();
                }

            },
            error: function (xhr, textStatus, errorThrown) {
                M.toast({
                    html: "Erro ao obter dados para edição do livro",
                    classes: 'carmesim darken-4 rounded',
                });
            }
        })
    }
}



function adicionarLivro() {
    var formValido = true;
    $('input[type="text"]').each(function () {
        if ($.trim($(this).val()).length == 0) {
            formValido = false;
        }
    });

    $('select').each(function () {
        if ($.trim($(this).val()).length == 0) {
            formValido = false;
        }
    });

    if (formValido) {
        var endPoint = `${url}/${nomeController}/AdicionarLivro/`;
        $.ajax({
            method: "POST",
            url: endPoint,
            headers: {
                "Authorization": "Bearer " + sessionStorage.getItem("tokenAuth")
            },
            dataType: "json",
            contentType: 'application/json; charset=UTF-8',
            data: JSON.stringify({
                "descricaoLivro": $('#descricao').val(),
                "sigla": $('#sigla').val(),
                "ultimaSequenciaUtilizada": $('#ultimasequencia').val(),
                "sessao": $('#sessao').val(),
                "controlaSequenciaDoAto": retornarTrueOrFalse(parseInt($('#controlaseqato').val())),
                "PermiteSequenciaDoAtoZero": $('#seqatozero').val(),
                "controlaSequenciaDoLivro": $('#controlaSeqLivro').val(),
                "sequenciaInicialAtos": parseInt($('#seqatoinicial').val()),
                "permiteDescreverGarantia": parseInt($('#permitegarantia').val()),
                "enviarDOI": retornarTrueOrFalse(parseInt($('#enviarDOI').val())),
                "validarRegistroAnterior": retornarTrueOrFalse(parseInt($('#validar_reg_anterior').val())),
                "indisponibilidade": retornarTrueOrFalse(parseInt($('#apontarindisponibilidade').val())),
                "transcricao": retornarTrueOrFalse(parseInt($('#transcricao').val())),
                "enviaBDL": parseInt($('#enviarBDL').val()),
                "idLivroTJ": $('#tipolivro').val(),
                "Ativo": true

            }),

            success: function (response) {
                if (isNullOrEmpty(response.mensagemRetorno)) {
                    M.toast({
                        html: "Livro cadastrado com sucesso.",
                        classes: 'carmesim darken-4 rounded',
                    });

                    location.reload(true);
                }

            },
            error: function (xhr, textStatus, errorThrown) {
                M.toast({
                    html: "Erro ao inserir o livro",
                    classes: 'carmesim darken-4 rounded',
                });
            }
        })
        console.log(livro);
    }
    else {
        if (!formValido) {
            M.toast({
                html: "Preencha os campos corretamente.",
                classes: 'carmesim darken-4 rounded',
            });
        }
    }
}


function excluirLivro(livroId) {
    $('.modal').modal({
        dismissble: true
    });

    $('#modal').modal('open');
    $(".texto").text("Deseja realmente excluir?");

    var endPoint = `${url}/${nomeController}/${livroId}`;

    $(".btnExcluir").on('click', function () {
        $.ajax({
            method: "DELETE",
            url: endPoint,
            headers: {
                "Authorization": "Bearer " + sessionStorage.getItem("tokenAuth")
            },
            dataType: "json",
            data: { Id: livroId },
            success: function (response) {
                if (isNullOrEmpty(response.mensagemRetorno)) {
                    M.toast({
                        html: "Livro excluído com sucesso!",
                        classes: 'carmesim darken-4 rounded',
                    });
                    $('#modal').modal('close');
                    location.reload(true);
                }
            },
            error: function (xhr, textStatus, errorThrown) {
                M.toast({
                    html: "Erro ao excluir especialidade",
                    classes: 'black darken-4 rounded',
                });
            }
        })
    })

}




