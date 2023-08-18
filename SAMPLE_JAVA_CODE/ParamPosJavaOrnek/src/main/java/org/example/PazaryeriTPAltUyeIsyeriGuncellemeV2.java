
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
 *         &lt;element name="GUID_AltUyeIsyeri" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Ad_Soyad" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Unvan" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="GSM_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="IBAN_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="IBAN_Unvan" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Adres" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Il" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Ilce" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="EPosta" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Website" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MCC_Kod" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Vergi_Daire" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bagli_Olunan_Hesap" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SAPId" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MagentoId" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "guidAltUyeIsyeri",
    "adSoyad",
    "unvan",
    "gsmNo",
    "ibanNo",
    "ibanUnvan",
    "adres",
    "il",
    "ilce",
    "ePosta",
    "website",
    "mccKod",
    "vergiDaire",
    "bagliOlunanHesap",
    "sapId",
    "magentoId"
})
@XmlRootElement(name = "Pazaryeri_TP_AltUyeIsyeri_Guncelleme_v2")
public class PazaryeriTPAltUyeIsyeriGuncellemeV2 {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "GUID_AltUyeIsyeri")
    protected String guidAltUyeIsyeri;
    @XmlElement(name = "Ad_Soyad")
    protected String adSoyad;
    @XmlElement(name = "Unvan")
    protected String unvan;
    @XmlElement(name = "GSM_No")
    protected String gsmNo;
    @XmlElement(name = "IBAN_No")
    protected String ibanNo;
    @XmlElement(name = "IBAN_Unvan")
    protected String ibanUnvan;
    @XmlElement(name = "Adres")
    protected String adres;
    @XmlElement(name = "Il")
    protected String il;
    @XmlElement(name = "Ilce")
    protected String ilce;
    @XmlElement(name = "EPosta")
    protected String ePosta;
    @XmlElement(name = "Website")
    protected String website;
    @XmlElement(name = "MCC_Kod")
    protected String mccKod;
    @XmlElement(name = "Vergi_Daire")
    protected String vergiDaire;
    @XmlElement(name = "Bagli_Olunan_Hesap")
    protected String bagliOlunanHesap;
    @XmlElement(name = "SAPId")
    protected String sapId;
    @XmlElement(name = "MagentoId")
    protected String magentoId;

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
     * Gets the value of the guidAltUyeIsyeri property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getGUIDAltUyeIsyeri() {
        return guidAltUyeIsyeri;
    }

    /**
     * Sets the value of the guidAltUyeIsyeri property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setGUIDAltUyeIsyeri(String value) {
        this.guidAltUyeIsyeri = value;
    }

    /**
     * Gets the value of the adSoyad property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getAdSoyad() {
        return adSoyad;
    }

    /**
     * Sets the value of the adSoyad property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setAdSoyad(String value) {
        this.adSoyad = value;
    }

    /**
     * Gets the value of the unvan property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getUnvan() {
        return unvan;
    }

    /**
     * Sets the value of the unvan property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setUnvan(String value) {
        this.unvan = value;
    }

    /**
     * Gets the value of the gsmNo property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getGSMNo() {
        return gsmNo;
    }

    /**
     * Sets the value of the gsmNo property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setGSMNo(String value) {
        this.gsmNo = value;
    }

    /**
     * Gets the value of the ibanNo property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIBANNo() {
        return ibanNo;
    }

    /**
     * Sets the value of the ibanNo property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIBANNo(String value) {
        this.ibanNo = value;
    }

    /**
     * Gets the value of the ibanUnvan property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIBANUnvan() {
        return ibanUnvan;
    }

    /**
     * Sets the value of the ibanUnvan property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIBANUnvan(String value) {
        this.ibanUnvan = value;
    }

    /**
     * Gets the value of the adres property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getAdres() {
        return adres;
    }

    /**
     * Sets the value of the adres property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setAdres(String value) {
        this.adres = value;
    }

    /**
     * Gets the value of the il property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIl() {
        return il;
    }

    /**
     * Sets the value of the il property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIl(String value) {
        this.il = value;
    }

    /**
     * Gets the value of the ilce property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIlce() {
        return ilce;
    }

    /**
     * Sets the value of the ilce property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIlce(String value) {
        this.ilce = value;
    }

    /**
     * Gets the value of the ePosta property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getEPosta() {
        return ePosta;
    }

    /**
     * Sets the value of the ePosta property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setEPosta(String value) {
        this.ePosta = value;
    }

    /**
     * Gets the value of the website property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getWebsite() {
        return website;
    }

    /**
     * Sets the value of the website property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setWebsite(String value) {
        this.website = value;
    }

    /**
     * Gets the value of the mccKod property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMCCKod() {
        return mccKod;
    }

    /**
     * Sets the value of the mccKod property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMCCKod(String value) {
        this.mccKod = value;
    }

    /**
     * Gets the value of the vergiDaire property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getVergiDaire() {
        return vergiDaire;
    }

    /**
     * Sets the value of the vergiDaire property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setVergiDaire(String value) {
        this.vergiDaire = value;
    }

    /**
     * Gets the value of the bagliOlunanHesap property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBagliOlunanHesap() {
        return bagliOlunanHesap;
    }

    /**
     * Sets the value of the bagliOlunanHesap property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBagliOlunanHesap(String value) {
        this.bagliOlunanHesap = value;
    }

    /**
     * Gets the value of the sapId property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSAPId() {
        return sapId;
    }

    /**
     * Sets the value of the sapId property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSAPId(String value) {
        this.sapId = value;
    }

    /**
     * Gets the value of the magentoId property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMagentoId() {
        return magentoId;
    }

    /**
     * Sets the value of the magentoId property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMagentoId(String value) {
        this.magentoId = value;
    }

}
