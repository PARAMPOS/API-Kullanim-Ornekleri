const cardTypes = {
    masterCard: 1,
    visa: 2,
    troy: 3
};
class TestCard {
    bankName = "";
    type = 0;
    cardNo = "";
    expirationDate = "";
    cardSecurityCode = "";
    card3DSecurePassword = "";
    constructor(bankName, type, cardNo, expirationDate, cardSecurityCode, card3DSecurePassword) {
        this.bankName = bankName;
        this.type = type;
        this.cardNo = cardNo;
        this.expirationDate = expirationDate;
        this.cardSecurityCode = cardSecurityCode;
        this.card3DSecurePassword = card3DSecurePassword;
    }
    getTypeName() {
        switch (this.type) {
            case 1:
                return "MasterCard"
            case 2:
                return "Visa"
            case 3:
                return "Troy";
            default:
                return undefined;
        }
    }
}
const testCards = [
    new TestCard("ZİRAAT BANKASI", cardTypes.visa, "4446763125813623", "12/26", "000", "a"),
    new TestCard("ZİRAAT BANKASI", cardTypes.visa, "4546711234567894", "12/26", "000", "a"),
    new TestCard("ZİRAAT BANKASI", cardTypes.masterCard, "5401341234567891", "12/26", "000", "a"),
    new TestCard("FİNANSBANK", cardTypes.visa, "4022774022774026", "12/26", "000", "a"),
    new TestCard("FİNANSBANK", cardTypes.visa, "4022780107947023", "01/50", "423", "a"),
    new TestCard("FİNANSBANK", cardTypes.visa, "4155650100416111", "01/50", "715", "a"),
    new TestCard("FİNANSBANK", cardTypes.masterCard, "5456165456165454", "12/26", "000", "a"),
    new TestCard("AKBANK", cardTypes.visa, "4256691944867646", "12/26", "000", "a"),
    new TestCard("AKBANK", cardTypes.visa, "4355084355084358", "12/26", "000", "a"),
    new TestCard("AKBANK", cardTypes.masterCard, "5571135571135575", "12/26", "000", "a"),
    new TestCard("İŞ BANKASI", cardTypes.visa, "4508034508034509", "12/26", "000", "a"),
    new TestCard("İŞ BANKASI", cardTypes.masterCard, "5406675406675403", "12/26", "000", "a"),
    new TestCard("İŞ BANKASI", cardTypes.masterCard, "5520961305582721", "11/26", "546", "a"),
    new TestCard("İŞ BANKASI", cardTypes.masterCard, "5520961792384607", "11/26", "512", "a"),
    new TestCard("HALK BANKASI", cardTypes.visa, "4531444531442283", "12/26", "001", "a"),
    new TestCard("HALK BANKASI", cardTypes.masterCard, "5818775818772285", "12/26", "001", "a"),
    new TestCard("DENİZBANK", cardTypes.visa, "4090700090840057", "12/22", "592", "123456"),
    new TestCard("DENİZBANK", cardTypes.visa, "4090700100360047", "12/26", "000", "123456"),
    new TestCard("DENİZBANK", cardTypes.visa, "4090700101174272", "12/22", "104", "123456"),
    new TestCard("DENİZBANK", cardTypes.masterCard, "5167400000496745", "12/26", "000", "123456"),
    new TestCard("DENİZBANK", cardTypes.masterCard, "5200190005138652", "12/26", "000", "123456"),
    new TestCard("DENİZBANK", cardTypes.masterCard, "5200190006338608", "01/30", "410", "123456"),
    new TestCard("DENİZBANK", cardTypes.masterCard, "5200190009721495", "01/30", "462", "123456"),
    new TestCard("DENİZBANK", cardTypes.masterCard, "5200190011811433", "12/26", "000", "123456"),
    new TestCard("DENİZBANK", cardTypes.masterCard, "5200190059838710", "12/26", "000", "123456"),
    new TestCard("YAPIKREDİ", cardTypes.visa, "4048095010857528", "05/28", "000", "34020"),
    new TestCard("YAPIKREDİ", cardTypes.visa, "4090700101174272", "12/25", "000", "123456"),
    new TestCard("YAPIKREDİ", cardTypes.visa, "4506344103118942", "01/24", "000", "34020"),
    new TestCard("YAPIKREDİ", cardTypes.visa, "4506344231869598", "01/24", "000", "34020"),
    new TestCard("YAPIKREDİ", cardTypes.visa, "4506347010299085", "09/26", "000", "34020"),
    new TestCard("YAPIKREDİ", cardTypes.visa, "4506347023253988", "12/25", "000", "34020"),
    new TestCard("YAPIKREDİ", cardTypes.visa, "4506347026523718", "12/25", "000", "34020"),
    new TestCard("YAPIKREDİ", cardTypes.visa, "4506347028991897", "12/25", "000", "34020"),
    new TestCard("YAPIKREDİ", cardTypes.masterCard, "5400617020092306", "12/25", "000", "34020"),
    new TestCard("YAPIKREDİ", cardTypes.masterCard, "5400617000004909", "09/26", "000", "34020"),
    new TestCard("YAPIKREDİ", cardTypes.masterCard, "5400617030400291", "12/25", "000", "34020"),
    new TestCard("ING BANK", cardTypes.masterCard, "5269737320050521", "12/26", "000", "123456"),
    new TestCard("FİNANS KATILIM", cardTypes.visa, "4284624140544525", "12/26", "000", "123456"),
    new TestCard("FİNANS KATILIM", cardTypes.visa, "4356292313685179", "12/26", "000", "123456"),
    new TestCard("FİNANS KATILIM", cardTypes.visa, "4799150896081734", "12/26", "000", "123456"),
    new TestCard("FİNANS KATILIM", cardTypes.masterCard, "5218487962459752", "12/26", "000", "123456"),
    new TestCard("FİNANS KATILIM", cardTypes.masterCard, "5377193762823307", "12/26", "000", "123456"),
    new TestCard("FİNANS KATILIM", cardTypes.masterCard, "6060432073705005", "12/26", "000", "123456"),
    new TestCard("FİNANS KATILIM", cardTypes.masterCard, "6060433087290190", "12/26", "000", "123456"),
    new TestCard("KUVEYT TÜRK", cardTypes.masterCard, "5188961939192544", "06/25", "929", "123456"),
    new TestCard("Yabancı Kart", cardTypes.visa, "4577270000134621", "12/26", "000", "a"),
    new TestCard("Yabancı Kart", cardTypes.visa, "4985170000702810", "12/26", "000", "a"),
    new TestCard("Yabancı Kart", cardTypes.masterCard, "5163103002982563", "12/26", "000", "a"),
    new TestCard("Yabancı Kart", cardTypes.masterCard, "5486742060635314", "12/26", "000", "a")
];
function loadTestCards() {
    const container = document.querySelector(".testcards-container");
    testCards.forEach((card, i) => {
        container.innerHTML += `
        <div class="testcard mt-2" onclick="selectRadioButton(event)">
            <strong>${card.bankName}</strong><br />
            <strong>Kart Tipi: </strong>${card.getTypeName()}<br />
            <strong>Kart Numarası: </strong>${card.cardNo}<br />
            <strong>Son Kullanma Tarihi:  </strong>${card.expirationDate}<br />
            <strong>Güvenlik Numarası: </strong>${card.cardSecurityCode}<br />
            <strong>Kart 3D Secure Şifresi: </strong>${card.card3DSecurePassword}<br />
            <input type="radio" name="selected-card" onchange="testCardSelectedEvent(event)" card-index="${i}">
        </div>
        `;
    });
}
function selectRadioButton(event) {
    let container = event.target;
    while (!container.classList.contains("testcard"))
        container = container.parentElement;
    const radioButton = container.querySelector('input[name="selected-card"]');
    radioButton.checked = true;
    radioButton.dispatchEvent(new Event("change"));
}
function testCardSelectedEvent(event) {
    const testCard = testCards[event.target.getAttribute("card-index")];
    const cardNo = document.querySelector("input[auto-fill-card-no]");
    if (cardNo)
        cardNo.value = testCard.cardNo;
    const cardExpirationMonth = document.querySelector("input[auto-fill-card-expirationmonth]");
    if (cardExpirationMonth)
        cardExpirationMonth.value = testCard.expirationDate.split("/")[0];
    const cardExpirationYear = document.querySelector("input[auto-fill-card-expirationyear]");
    if (cardExpirationYear)
        cardExpirationYear.value = "20" + testCard.expirationDate.split("/")[1];
    const cardSecurityCode = document.querySelector("input[auto-fill-card-cvc]");
    if (cardSecurityCode)
        cardSecurityCode.value = testCard.cardSecurityCode;
}
loadTestCards();