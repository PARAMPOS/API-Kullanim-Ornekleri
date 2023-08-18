
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
 *         &lt;element name="Tarih_Bas" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tarih_Bit" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Islem_Tip" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Islem_Durum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "tarihBas",
    "tarihBit",
    "islemTip",
    "islemDurum"
})
@XmlRootElement(name = "TP_Islem_Izleme")
public class TPIslemIzleme {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "GUID")
    protected String guid;
    @XmlElement(name = "Tarih_Bas")
    protected String tarihBas;
    @XmlElement(name = "Tarih_Bit")
    protected String tarihBit;
    @XmlElement(name = "Islem_Tip")
    protected String islemTip;
    @XmlElement(name = "Islem_Durum")
    protected String islemDurum;

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

    /**
     * Gets the value of the islemTip property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIslemTip() {
        return islemTip;
    }

    /**
     * Sets the value of the islemTip property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIslemTip(String value) {
        this.islemTip = value;
    }

    /**
     * Gets the value of the islemDurum property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIslemDurum() {
        return islemDurum;
    }

    /**
     * Sets the value of the islemDurum property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIslemDurum(String value) {
        this.islemDurum = value;
    }

}
