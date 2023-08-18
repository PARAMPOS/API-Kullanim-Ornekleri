
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="G" type="{https://turkpos.com.tr/}ST_WS_Guvenlik"/&gt;
 *         &lt;element name="GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_Sahibi" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_SK_Ay" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_SK_Yil" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_CVC" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_Sahibi_GSM" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Hata_URL" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Basarili_URL" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Siparis_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Siparis_Aciklama" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Taksit" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Islem_Tutar" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Toplam_Tutar" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Islem_Hash" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Islem_Guvenlik_Tip" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Islem_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="IPAdr" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Ref_URL" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data1" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data2" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data3" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data4" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data5" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "g",
    "guid",
    "kkSahibi",
    "kkNo",
    "kkskAy",
    "kkskYil",
    "kkcvc",
    "kkSahibiGSM",
    "hataURL",
    "basariliURL",
    "siparisID",
    "siparisAciklama",
    "taksit",
    "islemTutar",
    "toplamTutar",
    "islemHash",
    "islemGuvenlikTip",
    "islemID",
    "ipAdr",
    "refURL",
    "data1",
    "data2",
    "data3",
    "data4",
    "data5"
})
@XmlRootElement(name = "TP_WMD_UCD_v2")
public class TPWMDUCDV2 {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "GUID")
    protected String guid;
    @XmlElement(name = "KK_Sahibi")
    protected String kkSahibi;
    @XmlElement(name = "KK_No")
    protected String kkNo;
    @XmlElement(name = "KK_SK_Ay")
    protected String kkskAy;
    @XmlElement(name = "KK_SK_Yil")
    protected String kkskYil;
    @XmlElement(name = "KK_CVC")
    protected String kkcvc;
    @XmlElement(name = "KK_Sahibi_GSM")
    protected String kkSahibiGSM;
    @XmlElement(name = "Hata_URL")
    protected String hataURL;
    @XmlElement(name = "Basarili_URL")
    protected String basariliURL;
    @XmlElement(name = "Siparis_ID")
    protected String siparisID;
    @XmlElement(name = "Siparis_Aciklama")
    protected String siparisAciklama;
    @XmlElement(name = "Taksit")
    protected int taksit;
    @XmlElement(name = "Islem_Tutar")
    protected String islemTutar;
    @XmlElement(name = "Toplam_Tutar")
    protected String toplamTutar;
    @XmlElement(name = "Islem_Hash")
    protected String islemHash;
    @XmlElement(name = "Islem_Guvenlik_Tip")
    protected String islemGuvenlikTip;
    @XmlElement(name = "Islem_ID")
    protected String islemID;
    @XmlElement(name = "IPAdr")
    protected String ipAdr;
    @XmlElement(name = "Ref_URL")
    protected String refURL;
    @XmlElement(name = "Data1")
    protected String data1;
    @XmlElement(name = "Data2")
    protected String data2;
    @XmlElement(name = "Data3")
    protected String data3;
    @XmlElement(name = "Data4")
    protected String data4;
    @XmlElement(name = "Data5")
    protected String data5;

    /**
     * Gets the value of the g property.
     * 
     * @return
     *     possible object is
     *     {@link STWSGuvenlik }
     *     
     */
    public STWSGuvenlik getG() {
        return g;
    }

    /**
     * Sets the value of the g property.
     * 
     * @param value
     *     allowed object is
     *     {@link STWSGuvenlik }
     *     
     */
    public void setG(STWSGuvenlik value) {
        this.g = value;
    }

    /**
     * Gets the value of the guid property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getGUID() {
        return guid;
    }

    /**
     * Sets the value of the guid property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setGUID(String value) {
        this.guid = value;
    }

    /**
     * Gets the value of the kkSahibi property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKSahibi() {
        return kkSahibi;
    }

    /**
     * Sets the value of the kkSahibi property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKSahibi(String value) {
        this.kkSahibi = value;
    }

    /**
     * Gets the value of the kkNo property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKNo() {
        return kkNo;
    }

    /**
     * Sets the value of the kkNo property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKNo(String value) {
        this.kkNo = value;
    }

    /**
     * Gets the value of the kkskAy property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKSKAy() {
        return kkskAy;
    }

    /**
     * Sets the value of the kkskAy property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKSKAy(String value) {
        this.kkskAy = value;
    }

    /**
     * Gets the value of the kkskYil property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKSKYil() {
        return kkskYil;
    }

    /**
     * Sets the value of the kkskYil property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKSKYil(String value) {
        this.kkskYil = value;
    }

    /**
     * Gets the value of the kkcvc property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKCVC() {
        return kkcvc;
    }

    /**
     * Sets the value of the kkcvc property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKCVC(String value) {
        this.kkcvc = value;
    }

    /**
     * Gets the value of the kkSahibiGSM property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKSahibiGSM() {
        return kkSahibiGSM;
    }

    /**
     * Sets the value of the kkSahibiGSM property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKSahibiGSM(String value) {
        this.kkSahibiGSM = value;
    }

    /**
     * Gets the value of the hataURL property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getHataURL() {
        return hataURL;
    }

    /**
     * Sets the value of the hataURL property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setHataURL(String value) {
        this.hataURL = value;
    }

    /**
     * Gets the value of the basariliURL property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBasariliURL() {
        return basariliURL;
    }

    /**
     * Sets the value of the basariliURL property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBasariliURL(String value) {
        this.basariliURL = value;
    }

    /**
     * Gets the value of the siparisID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSiparisID() {
        return siparisID;
    }

    /**
     * Sets the value of the siparisID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSiparisID(String value) {
        this.siparisID = value;
    }

    /**
     * Gets the value of the siparisAciklama property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSiparisAciklama() {
        return siparisAciklama;
    }

    /**
     * Sets the value of the siparisAciklama property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSiparisAciklama(String value) {
        this.siparisAciklama = value;
    }

    /**
     * Gets the value of the taksit property.
     * 
     */
    public int getTaksit() {
        return taksit;
    }

    /**
     * Sets the value of the taksit property.
     * 
     */
    public void setTaksit(int value) {
        this.taksit = value;
    }

    /**
     * Gets the value of the islemTutar property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIslemTutar() {
        return islemTutar;
    }

    /**
     * Sets the value of the islemTutar property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIslemTutar(String value) {
        this.islemTutar = value;
    }

    /**
     * Gets the value of the toplamTutar property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getToplamTutar() {
        return toplamTutar;
    }

    /**
     * Sets the value of the toplamTutar property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setToplamTutar(String value) {
        this.toplamTutar = value;
    }

    /**
     * Gets the value of the islemHash property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIslemHash() {
        return islemHash;
    }

    /**
     * Sets the value of the islemHash property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIslemHash(String value) {
        this.islemHash = value;
    }

    /**
     * Gets the value of the islemGuvenlikTip property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIslemGuvenlikTip() {
        return islemGuvenlikTip;
    }

    /**
     * Sets the value of the islemGuvenlikTip property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIslemGuvenlikTip(String value) {
        this.islemGuvenlikTip = value;
    }

    /**
     * Gets the value of the islemID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIslemID() {
        return islemID;
    }

    /**
     * Sets the value of the islemID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIslemID(String value) {
        this.islemID = value;
    }

    /**
     * Gets the value of the ipAdr property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIPAdr() {
        return ipAdr;
    }

    /**
     * Sets the value of the ipAdr property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIPAdr(String value) {
        this.ipAdr = value;
    }

    /**
     * Gets the value of the refURL property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getRefURL() {
        return refURL;
    }

    /**
     * Sets the value of the refURL property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setRefURL(String value) {
        this.refURL = value;
    }

    /**
     * Gets the value of the data1 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData1() {
        return data1;
    }

    /**
     * Sets the value of the data1 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData1(String value) {
        this.data1 = value;
    }

    /**
     * Gets the value of the data2 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData2() {
        return data2;
    }

    /**
     * Sets the value of the data2 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData2(String value) {
        this.data2 = value;
    }

    /**
     * Gets the value of the data3 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData3() {
        return data3;
    }

    /**
     * Sets the value of the data3 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData3(String value) {
        this.data3 = value;
    }

    /**
     * Gets the value of the data4 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData4() {
        return data4;
    }

    /**
     * Sets the value of the data4 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData4(String value) {
        this.data4 = value;
    }

    /**
     * Gets the value of the data5 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData5() {
        return data5;
    }

    /**
     * Sets the value of the data5 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData5(String value) {
        this.data5 = value;
    }

}
