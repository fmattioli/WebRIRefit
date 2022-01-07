$(document).ready(function () {
    $("#protocolo").change(function () {
        alert("The text has been changed.");
    });

    var data = new Date().toLocaleDateString();
    var dateHora = new Date().toLocaleTimeString();
    $('#dataprotocolo').val(data + " " + dateHora);
    M.updateTextFields();
});

function CarregarDataPrevisaoPorNatureza() {
    var naturezaId = $('#natureza').val();
    var tipoPrenotacao = $('#tipoprenotacao').val();
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
                CarregarDataExpiraNatureza(naturezaId, tipoPrenotacao);
                return;
            }
            M.toast({
                html: "Erro ao carregar data previsão",
                classes: 'carmesim darken-4 rounded',
            });

        },
        error: function (xhr, textStatus, errorThrown) {
            M.toast({
                html: "Erro ao carregar data previsão",
                classes: 'carmesim darken-4 rounded',
            });
        }
    });
 
}


function CarregarDataExpiraNatureza(naturezaId, tipoPrenotacaoId) {
    var naturezaId = $('#natureza').val();
    const nomeController = 'Recepcao';
    const url = `https://localhost:7054/api/v1`;
    var endPoint = `${url}/${nomeController}/CalcularPrazoPorNatureza/${naturezaId}/${tipoPrenotacaoId}`;
    $.ajax({
        method: "GET",
        url: endPoint,
        success: function (response) {
            if (isNullOrEmpty(response.mensagemRetorno)) {
                var data = new Date(response.result);
                $('#dataexpira').val(data.toLocaleDateString());
                M.updateTextFields();
                return;
            }
            M.toast({
                html: "Erro ao carregar data expira",
                classes: 'carmesim darken-4 rounded',
            });

        },
        error: function (xhr, textStatus, errorThrown) {
            M.toast({
                html: "Erro ao carregar data expira",
                classes: 'carmesim darken-4 rounded',
            });
        }
    });

}
