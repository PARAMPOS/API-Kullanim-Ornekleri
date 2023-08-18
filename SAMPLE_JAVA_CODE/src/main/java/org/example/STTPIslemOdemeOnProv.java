
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ST_TP_Islem_Odeme_OnProv complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ST_TP_Islem_Odeme_OnProv"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Sonuc" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Sonuc_Str" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Islem_ID" type="{http://www.w3.org/2001/XMLSchema}long"/&gt;
 *         &lt;element name="UCD_URL" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Islem_GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Banka_Sonuc_Kod" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Siparis_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ST_TP_Islem_Odeme_OnProv", propOrder = {
    "sonuc",
    "sonucStr",
    "islemID",
    "ucdurl",
    "islemGUID",
    "bankaSonucKod",
    "siparisID"
})
public class STTPIslemOdemeOnProv {

    @XmlElement(name = "Sonuc")
    protected String sonuc;
    @XmlElement(name = "Sonuc_Str")
    protected String sonucStr;
    @XmlElement(name = "Islem_ID")
    protected long islemID;
    @XmlElement(name = "UCD_URL")
    protected String ucdurl;
    @XmlElement(name = "Islem_GUID")
    protected String islemGUID;
    @XmlElement(name = "Banka_Sonuc_Kod")
    protected int bankaSonucKod;
    @XmlElement(name = "Siparis_ID")
    protected String siparisID;

    /**
     * Gets the value of the sonuc property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSonuc() {
        return sonuc;
    }

    /**
     * Sets the value of the sonuc property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSonuc(String value) {
        this.sonuc = value;
    }

    /**
     * Gets the value of the sonucStr property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSonucStr() {
        return sonucStr;
    }

    /**
     * Sets the value of the sonucStr property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSonucStr(String value) {
        this.sonucStr = value;
    }

    /**
     * Gets the value of the islemID property.
     * 
     */
    public long getIslemID() {
        return islemID;
    }

    /**
     * Sets the value of the islemID property.
     * 
     */
    public void setIslemID(long value) {
        this.islemID = value;
    }

    /**
     * Gets the value of the ucdurl property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getUCDURL() {
        return ucdurl;
    }

    /**
     * Sets the value of the ucdurl property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setUCDURL(String value) {
        this.ucdurl = value;
    }

    /**
     * Gets the value of the islemGUID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIslemGUID() {
        return islemGUID;
    }

    /**
     * Sets the value of the islemGUID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIslemGUID(String value) {
        this.islemGUID = value;
    }

    /**
     * Gets the value of the bankaSonucKod property.
     * 
     */
    public int getBankaSonucKod() {
        return bankaSonucKod;
    }

    /**
     * Sets the value of the bankaSonucKod property.
     * 
     */
    public void setBankaSonucKod(int value) {
        this.bankaSonucKod = value;
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

}
