
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
 *         &lt;element name="ETS_GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Domain_Adres" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Yazilim_Bilgisi" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Yazilim_Surum_Bilgisi" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "etsguid",
    "domainAdres",
    "yazilimBilgisi",
    "yazilimSurumBilgisi"
})
@XmlRootElement(name = "Pos_Plugin_Bildirim")
public class PosPluginBildirim {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "ETS_GUID")
    protected String etsguid;
    @XmlElement(name = "Domain_Adres")
    protected String domainAdres;
    @XmlElement(name = "Yazilim_Bilgisi")
    protected String yazilimBilgisi;
    @XmlElement(name = "Yazilim_Surum_Bilgisi")
    protected String yazilimSurumBilgisi;

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
     * Gets the value of the etsguid property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getETSGUID() {
        return etsguid;
    }

    /**
     * Sets the value of the etsguid property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setETSGUID(String value) {
        this.etsguid = value;
    }

    /**
     * Gets the value of the domainAdres property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getDomainAdres() {
        return domainAdres;
    }

    /**
     * Sets the value of the domainAdres property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setDomainAdres(String value) {
        this.domainAdres = value;
    }

    /**
     * Gets the value of the yazilimBilgisi property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getYazilimBilgisi() {
        return yazilimBilgisi;
    }

    /**
     * Sets the value of the yazilimBilgisi property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setYazilimBilgisi(String value) {
        this.yazilimBilgisi = value;
    }

    /**
     * Gets the value of the yazilimSurumBilgisi property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getYazilimSurumBilgisi() {
        return yazilimSurumBilgisi;
    }

    /**
     * Sets the value of the yazilimSurumBilgisi property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setYazilimSurumBilgisi(String value) {
        this.yazilimSurumBilgisi = value;
    }

}
