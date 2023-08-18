
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for Sonuc_Limit2 complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="Sonuc_Limit2"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Sonuc" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Sonuc_Str" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="AltUyeIsyeri" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Odeme_Alma_Durumu" type="{http://www.w3.org/2001/XMLSchema}boolean"/&gt;
 *         &lt;element name="Toplam_Tahsilat_Tutari" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
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
@XmlType(name = "Sonuc_Limit2", propOrder = {
    "sonuc",
    "sonucStr",
    "altUyeIsyeri",
    "odemeAlmaDurumu",
    "toplamTahsilatTutari",
    "pazaryeriLimit",
    "yeniOdenecekTutar"
})
public class SonucLimit2 {

    @XmlElement(name = "Sonuc")
    protected String sonuc;
    @XmlElement(name = "Sonuc_Str")
    protected String sonucStr;
    @XmlElement(name = "AltUyeIsyeri")
    protected String altUyeIsyeri;
    @XmlElement(name = "Odeme_Alma_Durumu")
    protected boolean odemeAlmaDurumu;
    @XmlElement(name = "Toplam_Tahsilat_Tutari")
    protected int toplamTahsilatTutari;
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
     * Gets the value of the altUyeIsyeri property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getAltUyeIsyeri() {
        return altUyeIsyeri;
    }

    /**
     * Sets the value of the altUyeIsyeri property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setAltUyeIsyeri(String value) {
        this.altUyeIsyeri = value;
    }

    /**
     * Gets the value of the odemeAlmaDurumu property.
     * 
     */
    public boolean isOdemeAlmaDurumu() {
        return odemeAlmaDurumu;
    }

    /**
     * Sets the value of the odemeAlmaDurumu property.
     * 
     */
    public void setOdemeAlmaDurumu(boolean value) {
        this.odemeAlmaDurumu = value;
    }

    /**
     * Gets the value of the toplamTahsilatTutari property.
     * 
     */
    public int getToplamTahsilatTutari() {
        return toplamTahsilatTutari;
    }

    /**
     * Sets the value of the toplamTahsilatTutari property.
     * 
     */
    public void setToplamTahsilatTutari(int value) {
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
