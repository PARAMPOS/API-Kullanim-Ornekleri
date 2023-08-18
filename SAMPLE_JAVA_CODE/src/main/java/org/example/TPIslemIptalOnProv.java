
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
 *         &lt;element name="Prov_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
@XmlType(name = "", propOrder = {
    "g",
    "guid",
    "provID",
    "siparisID"
})
@XmlRootElement(name = "TP_Islem_Iptal_OnProv")
public class TPIslemIptalOnProv {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "GUID")
    protected String guid;
    @XmlElement(name = "Prov_ID")
    protected String provID;
    @XmlElement(name = "Siparis_ID")
    protected String siparisID;

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
