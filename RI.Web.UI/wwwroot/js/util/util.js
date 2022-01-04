function isNullOrEmpty(s) {
    return (s == null || s === "");
}

function carretorTextoInput(id, valueToSelect) {
    let element = document.getElementById(id);
    M.AutoInit();
    element.value = valueToSelect;
    $("#" + id).val();
    $("#" + id).focus();
}

function carregarSelectPeloValor(id, valueToSelect) {
    $('#' + id).val(parseInt(valueToSelect));
    $('#' + id).formSelect();
}


function carregarSelectBooleano(id, valueToSelect) {
    if (valueToSelect)
        $('#' + id).val(parseInt(1));
    else
        $('#' + id).val(parseInt(0));
    $('#' + id).formSelect();
}

function carregarSelectPeloNome(id, valueToSelect) {
    $(`#${id} option:contains(${valueToSelect})`).attr('selected', true);
    $('#' + id).formSelect();
}

function retornarTrueOrFalse(value) {
    if (value === 0)
        return false;
    return true;
}


function proximaPagina() {
    alert('oi');
}

