
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ST_TP_Islem_Odeme_OnProvKapa complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ST_TP_Islem_Odeme_OnProvKapa"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Sonuc" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Sonuc_Str" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Prov_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Dekont_ID" type="{http://www.w3.org/2001/XMLSchema}long"/&gt;
 *         &lt;element name="Banka_Sonuc_Kod" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Siparis_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Trans_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_AuthCode" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_HostMsg" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Extra" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_HostRefNum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ST_TP_Islem_Odeme_OnProvKapa", propOrder = {
    "sonuc",
    "sonucStr",
    "provID",
    "dekontID",
    "bankaSonucKod",
    "siparisID",
    "bankTransID",
    "bankAuthCode",
    "bankHostMsg",
    "bankExtra",
    "bankHostRefNum"
})
public class STTPIslemOdemeOnProvKapa {

    @XmlElement(name = "Sonuc")
    protected String sonuc;
    @XmlElement(name = "Sonuc_Str")
    protected String sonucStr;
    @XmlElement(name = "Prov_ID")
    protected String provID;
    @XmlElement(name = "Dekont_ID")
    protected long dekontID;
    @XmlElement(name = "Banka_Sonuc_Kod")
    protected int bankaSonucKod;
    @XmlElement(name = "Siparis_ID")
    protected String siparisID;
    @XmlElement(name = "Bank_Trans_ID")
    protected String bankTransID;
    @XmlElement(name = "Bank_AuthCode")
    protected String bankAuthCode;
    @XmlElement(name = "Bank_HostMsg")
    protected String bankHostMsg;
    @XmlElement(name = "Bank_Extra")
    protected String bankExtra;
    @XmlElement(name = "Bank_HostRefNum")
    protected String bankHostRefNum;

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
     * Gets the value of the provID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getProvID() {
        return provID;
    }

    /**
     * Sets the value of the provID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setProvID(String value) {
        this.provID = value;
    }

    /**
     * Gets the value of the dekontID property.
     * 
     */
    public long getDekontID() {
        return dekontID;
    }

    /**
     * Sets the value of the dekontID property.
     * 
     */
    public void setDekontID(long value) {
        this.dekontID = value;
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

    /**
     * Gets the value of the bankTransID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankTransID() {
        return bankTransID;
    }

    /**
     * Sets the value of the bankTransID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankTransID(String value) {
        this.bankTransID = value;
    }

    /**
     * Gets the value of the bankAuthCode property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankAuthCode() {
        return bankAuthCode;
    }

    /**
     * Sets the value of the bankAuthCode property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankAuthCode(String value) {
        this.bankAuthCode = value;
    }

    /**
     * Gets the value of the bankHostMsg property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankHostMsg() {
        return bankHostMsg;
    }

    /**
     * Sets the value of the bankHostMsg property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankHostMsg(String value) {
        this.bankHostMsg = value;
    }

    /**
     * Gets the value of the bankExtra property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankExtra() {
        return bankExtra;
    }

    /**
     * Sets the value of the bankExtra property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankExtra(String value) {
        this.bankExtra = value;
    }

    /**
     * Gets the value of the bankHostRefNum property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankHostRefNum() {
        return bankHostRefNum;
    }

    /**
     * Sets the value of the bankHostRefNum property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankHostRefNum(String value) {
        this.bankHostRefNum = value;
    }

}
