
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for Status complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="Status"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Islem_ID" type="{http://www.w3.org/2001/XMLSchema}long"/&gt;
 *         &lt;element name="Islem_GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="UCD_HTML" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="UCD_MD" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Sonuc" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Sonuc_Str" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Trans_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_AuthCode" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_HostMsg" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Banka_Sonuc_Kod" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Bank_Extra" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Siparis_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
@XmlType(name = "Status", propOrder = {
    "islemID",
    "islemGUID",
    "ucdhtml",
    "ucdmd",
    "sonuc",
    "sonucStr",
    "bankTransID",
    "bankAuthCode",
    "bankHostMsg",
    "bankaSonucKod",
    "bankExtra",
    "siparisID",
    "bankHostRefNum"
})
public class Status {

    @XmlElement(name = "Islem_ID")
    protected long islemID;
    @XmlElement(name = "Islem_GUID")
    protected String islemGUID;
    @XmlElement(name = "UCD_HTML")
    protected String ucdhtml;
    @XmlElement(name = "UCD_MD")
    protected String ucdmd;
    @XmlElement(name = "Sonuc")
    protected String sonuc;
    @XmlElement(name = "Sonuc_Str")
    protected String sonucStr;
    @XmlElement(name = "Bank_Trans_ID")
    protected String bankTransID;
    @XmlElement(name = "Bank_AuthCode")
    protected String bankAuthCode;
    @XmlElement(name = "Bank_HostMsg")
    protected String bankHostMsg;
    @XmlElement(name = "Banka_Sonuc_Kod")
    protected int bankaSonucKod;
    @XmlElement(name = "Bank_Extra")
    protected String bankExtra;
    @XmlElement(name = "Siparis_ID")
    protected String siparisID;
    @XmlElement(name = "Bank_HostRefNum")
    protected String bankHostRefNum;

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
     * Gets the value of the ucdhtml property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getUCDHTML() {
        return ucdhtml;
    }

    /**
     * Sets the value of the ucdhtml property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setUCDHTML(String value) {
        this.ucdhtml = value;
    }

    /**
     * Gets the value of the ucdmd property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getUCDMD() {
        return ucdmd;
    }

    /**
     * Sets the value of the ucdmd property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setUCDMD(String value) {
        this.ucdmd = value;
    }

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
