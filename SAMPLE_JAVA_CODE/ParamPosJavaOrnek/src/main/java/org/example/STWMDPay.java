
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ST_WMD_Pay complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ST_WMD_Pay"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Sonuc" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Sonuc_Ack" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Dekont_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Siparis_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="UCD_MD" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Trans_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_AuthCode" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_HostMsg" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Extra" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Sonuc_Kod" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Bank_HostRefNum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Komisyon_Oran" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ST_WMD_Pay", propOrder = {
    "sonuc",
    "sonucAck",
    "dekontID",
    "siparisID",
    "ucdmd",
    "bankTransID",
    "bankAuthCode",
    "bankHostMsg",
    "bankExtra",
    "bankSonucKod",
    "bankHostRefNum",
    "komisyonOran"
})
public class STWMDPay {

    @XmlElement(name = "Sonuc")
    protected int sonuc;
    @XmlElement(name = "Sonuc_Ack")
    protected String sonucAck;
    @XmlElement(name = "Dekont_ID")
    protected String dekontID;
    @XmlElement(name = "Siparis_ID")
    protected String siparisID;
    @XmlElement(name = "UCD_MD")
    protected String ucdmd;
    @XmlElement(name = "Bank_Trans_ID")
    protected String bankTransID;
    @XmlElement(name = "Bank_AuthCode")
    protected String bankAuthCode;
    @XmlElement(name = "Bank_HostMsg")
    protected String bankHostMsg;
    @XmlElement(name = "Bank_Extra")
    protected String bankExtra;
    @XmlElement(name = "Bank_Sonuc_Kod")
    protected int bankSonucKod;
    @XmlElement(name = "Bank_HostRefNum")
    protected String bankHostRefNum;
    @XmlElement(name = "Komisyon_Oran")
    protected double komisyonOran;

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
     * Gets the value of the sonucAck property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSonucAck() {
        return sonucAck;
    }

    /**
     * Sets the value of the sonucAck property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSonucAck(String value) {
        this.sonucAck = value;
    }

    /**
     * Gets the value of the dekontID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getDekontID() {
        return dekontID;
    }

    /**
     * Sets the value of the dekontID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setDekontID(String value) {
        this.dekontID = value;
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
     * Gets the value of the bankSonucKod property.
     * 
     */
    public int getBankSonucKod() {
        return bankSonucKod;
    }

    /**
     * Sets the value of the bankSonucKod property.
     * 
     */
    public void setBankSonucKod(int value) {
        this.bankSonucKod = value;
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
     * Gets the value of the komisyonOran property.
     * 
     */
    public double getKomisyonOran() {
        return komisyonOran;
    }

    /**
     * Sets the value of the komisyonOran property.
     * 
     */
    public void setKomisyonOran(double value) {
        this.komisyonOran = value;
    }

}
