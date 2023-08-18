
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
 *         &lt;element name="GUID_AltUyeIsyeri" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="PYSiparis_GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SanalPOS_Islem_ID" type="{http://www.w3.org/2001/XMLSchema}long"/&gt;
 *         &lt;element name="Tarih_Bas" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tarih_Bit" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "guidAltUyeIsyeri",
    "pySiparisGUID",
    "sanalPOSIslemID",
    "tarihBas",
    "tarihBit"
})
@XmlRootElement(name = "Pazaryeri_TP_Islem_Sorgulama")
public class PazaryeriTPIslemSorgulama {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "ETS_GUID")
    protected String etsguid;
    @XmlElement(name = "GUID_AltUyeIsyeri")
    protected String guidAltUyeIsyeri;
    @XmlElement(name = "PYSiparis_GUID")
    protected String pySiparisGUID;
    @XmlElement(name = "SanalPOS_Islem_ID")
    protected long sanalPOSIslemID;
    @XmlElement(name = "Tarih_Bas")
    protected String tarihBas;
    @XmlElement(name = "Tarih_Bit")
    protected String tarihBit;

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
     * Gets the value of the sanalPOSIslemID property.
     * 
     */
    public long getSanalPOSIslemID() {
        return sanalPOSIslemID;
    }

    /**
     * Sets the value of the sanalPOSIslemID property.
     * 
     */
    public void setSanalPOSIslemID(long value) {
        this.sanalPOSIslemID = value;
    }

    /**
     * Gets the value of the tarihBas property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTarihBas() {
        return tarihBas;
    }

    /**
     * Sets the value of the tarihBas property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTarihBas(String value) {
        this.tarihBas = value;
    }

    /**
     * Gets the value of the tarihBit property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTarihBit() {
        return tarihBit;
    }

    /**
     * Sets the value of the tarihBit property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTarihBit(String value) {
        this.tarihBit = value;
    }

}
