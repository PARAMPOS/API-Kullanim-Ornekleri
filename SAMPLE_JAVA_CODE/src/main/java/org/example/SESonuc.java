
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for SE_Sonuc complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="SE_Sonuc"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Sonuc" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Sonuc_Str" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="GUID_AltUyeIsyeri" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tutar_Urun" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tutar_Odenecek" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="PYSiparis_GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SanalPOS_Islem_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Toplam_Tahsilat_Tutari" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Pazaryeri_Limit" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Yeni_Odenecek_Tutar" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "SE_Sonuc", propOrder = {
    "sonuc",
    "sonucStr",
    "guidAltUyeIsyeri",
    "tutarUrun",
    "tutarOdenecek",
    "pySiparisGUID",
    "sanalPOSIslemID",
    "toplamTahsilatTutari",
    "pazaryeriLimit",
    "yeniOdenecekTutar"
})
public class SESonuc {

    @XmlElement(name = "Sonuc")
    protected String sonuc;
    @XmlElement(name = "Sonuc_Str")
    protected String sonucStr;
    @XmlElement(name = "GUID_AltUyeIsyeri")
    protected String guidAltUyeIsyeri;
    @XmlElement(name = "Tutar_Urun")
    protected String tutarUrun;
    @XmlElement(name = "Tutar_Odenecek")
    protected String tutarOdenecek;
    @XmlElement(name = "PYSiparis_GUID")
    protected String pySiparisGUID;
    @XmlElement(name = "SanalPOS_Islem_ID")
    protected String sanalPOSIslemID;
    @XmlElement(name = "Toplam_Tahsilat_Tutari")
    protected String toplamTahsilatTutari;
    @XmlElement(name = "Pazaryeri_Limit")
    protected int pazaryeriLimit;
    @XmlElement(name = "Yeni_Odenecek_Tutar")
    protected int yeniOdenecekTutar;

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
     * Gets the value of the toplamTahsilatTutari property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getToplamTahsilatTutari() {
        return toplamTahsilatTutari;
    }

    /**
     * Sets the value of the toplamTahsilatTutari property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setToplamTahsilatTutari(String value) {
        this.toplamTahsilatTutari = value;
    }

    /**
     * Gets the value of the pazaryeriLimit property.
     * 
     */
    public int getPazaryeriLimit() {
        return pazaryeriLimit;
    }

    /**
     * Sets the value of the pazaryeriLimit property.
     * 
     */
    public void setPazaryeriLimit(int value) {
        this.pazaryeriLimit = value;
    }

    /**
     * Gets the value of the yeniOdenecekTutar property.
     * 
     */
    public int getYeniOdenecekTutar() {
        return yeniOdenecekTutar;
    }

    /**
     * Sets the value of the yeniOdenecekTutar property.
     * 
     */
    public void setYeniOdenecekTutar(int value) {
        this.yeniOdenecekTutar = value;
    }

}
