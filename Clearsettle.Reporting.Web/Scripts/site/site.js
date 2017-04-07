function GetReport(from, to) {
    AjaxGet('../Home/GetReport', { from: from, to:to }, 'divReport', true);
}

function GetTransaction(transactionid) {
    AjaxGet('../Home/GetTransaction', { transactionId: transactionid }, 'divTransaction', false);
}

function GetMerchant(transactionid) {
   AjaxGet('../Home/GetMerchant', { transactionId: transactionid }, 'divMerchant', false);
}

function GetClient(transactionid) {
    AjaxGet('../Home/GetClient', { transactionId: transactionid }, 'divClient', false);
}

function AjaxGet(url, data, divForShow, isPost) {
    $.ajax({
        type: isPost ? "POST" : "GET",
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