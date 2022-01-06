$(document).ready(function () {
    $("#protocolo").change(function () {
        alert("The text has been changed.");
    });
});

function CarregarDataPrevisaoPorNatureza() {
    var naturezaId = $('#natureza').val();
    const nomeController = 'Recepcao';
    const url = `https://localhost:7054/api/v1`;
    var endPoint = `${url}/${nomeController}/CalcularPrazoPorNatureza/${naturezaId}`;
    $.ajax({
        method: "GET",
        url: endPoint,
        success: function (response) {
            if (isNullOrEmpty(response.mensagemRetorno)) {
                var data = new Date(response.result);
                $('#dataprevisao').val(data.toLocaleDateString());
                return;
            }
            M.toast({
                html: "Erro ao carregar data previsão",
                classes: 'carmesim darken-4 rounded',
            });

        },
        error: function (xhr, textStatus, errorThrown) {
            M.toast({
                html: "Erro ao obter dados para edição do livro",
                classes: 'carmesim darken-4 rounded',
            });
        }
    });
 
}
