
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ST_Sonuc4 complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ST_Sonuc4"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Sonuc" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Sonuc_Str" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Orjinal_Dekont_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Iade_Dekont_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Banka_Sonuc_Kod" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_AuthCode" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Trans_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Extra" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_HostRefNum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
@XmlType(name = "ST_Sonuc4", propOrder = {
    "sonuc",
    "sonucStr",
    "orjinalDekontID",
    "iadeDekontID",
    "bankaSonucKod",
    "bankAuthCode",
    "bankTransID",
    "bankExtra",
    "bankHostRefNum",
    "siparisID"
})
public class STSonuc4 {

    @XmlElement(name = "Sonuc")
    protected int sonuc;
    @XmlElement(name = "Sonuc_Str")
    protected String sonucStr;
    @XmlElement(name = "Orjinal_Dekont_ID")
    protected String orjinalDekontID;
    @XmlElement(name = "Iade_Dekont_ID")
    protected String iadeDekontID;
    @XmlElement(name = "Banka_Sonuc_Kod")
    protected String bankaSonucKod;
    @XmlElement(name = "Bank_AuthCode")
    protected String bankAuthCode;
    @XmlElement(name = "Bank_Trans_ID")
    protected String bankTransID;
    @XmlElement(name = "Bank_Extra")
    protected String bankExtra;
    @XmlElement(name = "Bank_HostRefNum")
    protected String bankHostRefNum;
    @XmlElement(name = "Siparis_ID")
    protected String siparisID;

    /**
     * Gets the value of the sonuc property.
     * 
     */
    public int getSonuc() {
        return sonuc;
    }

    /**
     * Sets the value of the sonuc property.
     * 
     */
    public void setSonuc(int value) {
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
     * Gets the value of the orjinalDekontID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getOrjinalDekontID() {
        return orjinalDekontID;
    }

    /**
     * Sets the value of the orjinalDekontID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setOrjinalDekontID(String value) {
        this.orjinalDekontID = value;
    }

    /**
     * Gets the value of the iadeDekontID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIadeDekontID() {
        return iadeDekontID;
    }

    /**
     * Sets the value of the iadeDekontID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIadeDekontID(String value) {
        this.iadeDekontID = value;
    }

    /**
     * Gets the value of the bankaSonucKod property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankaSonucKod() {
        return bankaSonucKod;
    }

    /**
     * Sets the value of the bankaSonucKod property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankaSonucKod(String value) {
        this.bankaSonucKod = value;
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
