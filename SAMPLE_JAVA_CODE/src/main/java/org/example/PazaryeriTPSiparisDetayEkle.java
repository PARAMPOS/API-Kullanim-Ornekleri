
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
 *         &lt;element name="Tutar_Urun" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tutar_Odenecek" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SanalPOS_Islem_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="GUID_AltUyeIsyeri" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "tutarUrun",
    "tutarOdenecek",
    "sanalPOSIslemID",
    "guidAltUyeIsyeri"
})
@XmlRootElement(name = "Pazaryeri_TP_Siparis_Detay_Ekle")
public class PazaryeriTPSiparisDetayEkle {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "ETS_GUID")
    protected String etsguid;
    @XmlElement(name = "Tutar_Urun")
    protected String tutarUrun;
    @XmlElement(name = "Tutar_Odenecek")
    protected String tutarOdenecek;
    @XmlElement(name = "SanalPOS_Islem_ID")
    protected String sanalPOSIslemID;
    @XmlElement(name = "GUID_AltUyeIsyeri")
    protected String guidAltUyeIsyeri;

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
     * Gets the value of the tutarUrun property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTutarUrun() {
        return tutarUrun;
    }

    /**
     * Sets the value of the tutarUrun property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTutarUrun(String value) {
        this.tutarUrun = value;
    }

    /**
     * Gets the value of the tutarOdenecek property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTutarOdenecek() {
        return tutarOdenecek;
    }

    /**
     * Sets the value of the tutarOdenecek property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTutarOdenecek(String value) {
        this.tutarOdenecek = value;
    }

    /**
     * Gets the value of the sanalPOSIslemID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSanalPOSIslemID() {
        return sanalPOSIslemID;
    }

    /**
     * Sets the value of the sanalPOSIslemID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSanalPOSIslemID(String value) {
        this.sanalPOSIslemID = value;
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

}
