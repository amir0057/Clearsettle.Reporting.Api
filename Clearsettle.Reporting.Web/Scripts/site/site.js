function GetReport(from, to) {
    AjaxGet('/Home/GetReport', { from: from, to:to }, 'divReport');
}

function GetTransaction(transactionid) {
    AjaxGet('/Home/GetTransaction', { transactionId: transactionid }, 'divTransaction');
}

function GetMerchant(transactionid) {
    AjaxGet('/Home/GetMerchant', { transactionId: transactionid }, 'divMerchant');
}

function GetClient(transactionid) {
    AjaxGet('/Home/GetClient', { transactionId: transactionid }, 'divClient');
}

function AjaxGet(url, data, divForShow) {
    $.ajax({
        type: "POST",
        url: url,
        data: data,
        dataType: "html",
        success: function (r) {
            $('#' + divForShow).html(r);
        },
        error: function (e) {

        }
    });
}