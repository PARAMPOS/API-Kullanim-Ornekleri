
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
 *         &lt;element name="CLIENT_CODE" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="IPAdr" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_BIN" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tutar" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "clientcode",
    "guid",
    "ipAdr",
    "kkbin",
    "tutar"
})
@XmlRootElement(name = "TP_Islem_Checkout_SK")
public class TPIslemCheckoutSK {

    @XmlElement(name = "CLIENT_CODE")
    protected String clientcode;
    @XmlElement(name = "GUID")
    protected String guid;
    @XmlElement(name = "IPAdr")
    protected String ipAdr;
    @XmlElement(name = "KK_BIN")
    protected String kkbin;
    @XmlElement(name = "Tutar")
    protected String tutar;

    /**
     * Gets the value of the clientcode property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getCLIENTCODE() {
        return clientcode;
    }

    /**
     * Sets the value of the clientcode property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setCLIENTCODE(String value) {
        this.clientcode = value;
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
     * Gets the value of the kkbin property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKBIN() {
        return kkbin;
    }

    /**
     * Sets the value of the kkbin property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKBIN(String value) {
        this.kkbin = value;
    }

    /**
     * Gets the value of the tutar property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTutar() {
        return tutar;
    }

    /**
     * Sets the value of the tutar property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTutar(String value) {
        this.tutar = value;
    }

}
