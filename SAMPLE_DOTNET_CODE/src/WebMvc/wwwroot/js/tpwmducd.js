function isFloat(n) {
    return Number(n) === n && n % 1 !== 0;
}
function validateHashInputs() {
    const taksit = document.querySelector('input[hash-input="Taksit"]');
    const islemTutar = document.querySelector('input[hash-input="Islem_Tutar"]');
    const toplamTutar = document.querySelector('input[hash-input="Toplam_Tutar"]');
    const siparisId = document.querySelector('input[hash-input="Siparis_ID"]');
    const clientCode = document.querySelector('input[hash-input="CLIENT_CODE"]');
    const guid = document.querySelector('input[hash-input="GUID"]');
    const hataURL = document.querySelector('input[hash-input="Hata_URL"]');
    const basariliURL = document.querySelector('input[hash-input="Basarili_URL"]');
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
    if (!siparisId.value)
        return false;
    return true;
}
function generateHash() {
    const taksit = document.querySelector('[hash-input="Taksit"]');
    const islemTutar = document.querySelector('[hash-input="Islem_Tutar"]');
    const toplamTutar = document.querySelector('[hash-input="Toplam_Tutar"]');
    const siparisId = document.querySelector('[hash-input="Siparis_ID"]');
    const clientCode = document.querySelector('[hash-input="CLIENT_CODE"]');
    const guid = document.querySelector('[hash-input="GUID"]');
    const hataURL = document.querySelector('[hash-input="Hata_URL"]');
    const basariliURL = document.querySelector('[hash-input="Basarili_URL"]');
    const hashResult = document.querySelector('[hash-result]');
    if (!validateHashInputs()) {
        alert("Error");
        return false;
    }
    getSHA2B64({
        clientCode: clientCode.value,
        guid: guid.value,
        taksit: taksit.value,
        islemTutar: islemTutar.value,
        toplamTutar: toplamTutar.value,
        siparisId: siparisId.value
    }, result => {
        hashResult.value = result;
    });
}
document.addEventListener("DOMContentLoaded", () => {        

});