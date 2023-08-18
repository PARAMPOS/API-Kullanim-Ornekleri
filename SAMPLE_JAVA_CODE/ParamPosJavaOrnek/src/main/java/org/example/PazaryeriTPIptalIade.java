
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
 *         &lt;element name="PYSiparis_GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Durum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Siparis_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SiparisTutar" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="OdenecekTutar" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
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
    "pySiparisGUID",
    "guid",
    "durum",
    "siparisID",
    "siparisTutar",
    "odenecekTutar"
})
@XmlRootElement(name = "Pazaryeri_TP_Iptal_Iade")
public class PazaryeriTPIptalIade {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "PYSiparis_GUID")
    protected String pySiparisGUID;
    @XmlElement(name = "GUID")
    protected String guid;
    @XmlElement(name = "Durum")
    protected String durum;
    @XmlElement(name = "Siparis_ID")
    protected String siparisID;
    @XmlElement(name = "SiparisTutar")
    protected double siparisTutar;
    @XmlElement(name = "OdenecekTutar")
    protected double odenecekTutar;

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
     * Gets the value of the pySiparisGUID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getPYSiparisGUID() {
        return pySiparisGUID;
    }

    /**
     * Sets the value of the pySiparisGUID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setPYSiparisGUID(String value) {
        this.pySiparisGUID = value;
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
     * Gets the value of the durum property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getDurum() {
        return durum;
    }

    /**
     * Sets the value of the durum property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setDurum(String value) {
        this.durum = value;
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
     * Gets the value of the siparisTutar property.
     * 
     */
    public double getSiparisTutar() {
        return siparisTutar;
    }

    /**
     * Sets the value of the siparisTutar property.
     * 
     */
    public void setSiparisTutar(double value) {
        this.siparisTutar = value;
    }

    /**
     * Gets the value of the odenecekTutar property.
     * 
     */
    public double getOdenecekTutar() {
        return odenecekTutar;
    }

    /**
     * Sets the value of the odenecekTutar property.
     * 
     */
    public void setOdenecekTutar(double value) {
        this.odenecekTutar = value;
    }

}
