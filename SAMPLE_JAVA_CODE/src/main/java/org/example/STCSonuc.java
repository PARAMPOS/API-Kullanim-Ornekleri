
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for STC_Sonuc complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="STC_Sonuc"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="POS_Islem_Id" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="GUID_AltUyeIsyeri" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tutar_Urun" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tutar_Odenecek" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Durum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Durum_Str" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Sonuc" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Sonuc_Str" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "STC_Sonuc", propOrder = {
    "posIslemId",
    "guidAltUyeIsyeri",
    "tutarUrun",
    "tutarOdenecek",
    "durum",
    "durumStr",
    "sonuc",
    "sonucStr"
})
public class STCSonuc {

    @XmlElement(name = "POS_Islem_Id")
    protected String posIslemId;
    @XmlElement(name = "GUID_AltUyeIsyeri")
    protected String guidAltUyeIsyeri;
    @XmlElement(name = "Tutar_Urun")
    protected String tutarUrun;
    @XmlElement(name = "Tutar_Odenecek")
    protected String tutarOdenecek;
    @XmlElement(name = "Durum")
    protected String durum;
    @XmlElement(name = "Durum_Str")
    protected String durumStr;
    @XmlElement(name = "Sonuc")
    protected String sonuc;
    @XmlElement(name = "Sonuc_Str")
    protected String sonucStr;

    /**
     * Gets the value of the posIslemId property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getPOSIslemId() {
        return posIslemId;
    }

    /**
     * Sets the value of the posIslemId property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setPOSIslemId(String value) {
        this.posIslemId = value;
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
     * Gets the value of the durumStr property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getDurumStr() {
        return durumStr;
    }

    /**
     * Sets the value of the durumStr property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setDurumStr(String value) {
        this.durumStr = value;
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

}
