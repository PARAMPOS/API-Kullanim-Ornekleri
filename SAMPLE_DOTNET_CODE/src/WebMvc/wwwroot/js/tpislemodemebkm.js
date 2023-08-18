function isFloat(n) {
    return Number(n) === n && n % 1 !== 0;
}
function validateHashInputs() {
    const clientCode = document.querySelector('input[hash-input="CLIENT_CODE"]');
    const guid = document.querySelector('input[hash-input="GUID"]');
    const amount = document.querySelector('input[hash-input="Amount"]');
    const orderId = document.querySelector('input[hash-input="Order_ID"]');
    const errorURL = document.querySelector('input[hash-input="Error_URL"]');
    const successURL = document.querySelector('input[hash-input="Success_URL"]');
    // Validation Rules for Taksit
    if (!taksit.value || isNaN(taksit.value))
        return false;
    // Validation Rules for IslemTutar
    if (!islemTutar.value || isFloat(islemTutar.value))
        return false;
    // Validation Rules for ToplamTutar
    if (!toplamTutar.value || isFloat(toplamTutar.value))
        return false;
    // Validation Rules for SiparisId
    if (!orderId.value)
        return false;
    return true;
}
function generateHash() {
    const clientCode = document.querySelector('[hash-input="CLIENT_CODE"]');
    const guid = document.querySelector('[hash-input="GUID"]');
    const amount = document.querySelector('[hash-input="Amount"]');
    const orderId = document.querySelector('[hash-input="Order_ID"]');
    const errorURL = document.querySelector('[hash-input="Error_URL"]');
    const successURL = document.querySelector('[hash-input="Success_URL"]');
    const hashResult = document.querySelector('[hash-result]');
    if (!validateHashInputs()) {
        alert("Error");
        return false;
    }
    getSHA2B64({
        clientCode: clientCode.value,
        guid: guid.value,
        amount: amount.value,
        orderId: orderId.value,
        errorURL: errorURL.value,
        successURL: successURL.value
    }, result => {
        hashResult.value = result;
    });
}
document.addEventListener("DOMContentLoaded", () => {

});