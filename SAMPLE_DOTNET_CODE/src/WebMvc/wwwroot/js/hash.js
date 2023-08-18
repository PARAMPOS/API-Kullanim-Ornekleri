function getSHA2B64(data, successCallback) {
    fetch(location.origin + "/api/op/sha2b64", {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
            "RequestVerificationToken": document.querySelector("input[name='__RequestVerificationToken']")?.value
        },
        body: JSON.stringify(data)
    }).then(response => {
        response.text().then(result => {
            if (successCallback)
                successCallback(result);
        }).catch(reason => console.log(reason));
    }).catch(reason => console.log(reason));
}
// todo Boş yere yükleniyor. Transfer edilmesi gerekiyor.
function generateHash() {
    const data = {
        clientCode: document.querySelector("#CLIENT_CODE")?.value,
        guid: document.querySelector("#GUID")?.value,
        taksit: document.querySelector("#Taksit")?.value,
        islemTutar: document.querySelector("#Islem_Tutar")?.value,
        toplamTutar: document.querySelector("#Toplam_Tutar")?.value,
        siparisId: document.querySelector("#Siparis_ID")?.value,
        hataURL: document.querySelector("#Hata_URL")?.value,
        basariliURL: document.querySelector("#Basarili_URL")?.value
    }
    getSHA2B64(data, result => {
        const resultLabel = document.querySelector("#result");
        resultLabel.className = "mt-3 text-success";
        resultLabel.textContent = result;
    });    
}