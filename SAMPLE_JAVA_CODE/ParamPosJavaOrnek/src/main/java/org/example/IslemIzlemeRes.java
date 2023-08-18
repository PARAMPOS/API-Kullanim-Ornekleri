
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlAnyElement;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;
import org.w3c.dom.Element;


/**
 * <p>Java class for IslemIzlemeRes complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="IslemIzlemeRes"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Sonuc" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Sonuc_Str" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="DT_Bilgi" minOccurs="0"&gt;
 *           &lt;complexType&gt;
 *             &lt;complexContent&gt;
 *               &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *                 &lt;sequence&gt;
 *                   &lt;any processContents='lax' namespace='urn:schemas-microsoft-com:xml-diffgram-v1'/&gt;
 *                 &lt;/sequence&gt;
 *               &lt;/restriction&gt;
 *             &lt;/complexContent&gt;
 *           &lt;/complexType&gt;
 *         &lt;/element&gt;
 *         &lt;element name="Durum_Onay" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SanalPOS_Banka" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SanalPOS_Islem_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Odeme_Yapan_Bilgisi" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="ODEME_TUTAR" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Komisyon_Odeyen_Aciklama" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="islem_durumu" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="tutar_urun" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="AltUye_Isyeri_Ad_Soyad" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="uye_isyeri_odeme_tutar\u0131" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="param_komisyon_orani" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="param_komisyon_ucreti" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="alt_uye_is_yeri_odeme_tutar\u0131" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Val�r" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "IslemIzlemeRes", propOrder = {
    "sonuc",
    "sonucStr",
    "dtBilgi",
    "durumOnay",
    "sanalPOSBanka",
    "sanalPOSIslemID",
    "odemeYapanBilgisi",
    "odemetutar",
    "komisyonOdeyenAciklama",
    "islemDurumu",
    "tutarUrun",
    "altUyeIsyeriAdSoyad",
    "uyeIsyeriOdemeTutarı",
    "paramKomisyonOrani",
    "paramKomisyonUcreti",
    "altUyeIsYeriOdemeTutarı",
    "valör"
})
public class IslemIzlemeRes {

    @XmlElement(name = "Sonuc")
    protected String sonuc;
    @XmlElement(name = "Sonuc_Str")
    protected String sonucStr;
    @XmlElement(name = "DT_Bilgi")
    protected IslemIzlemeRes.DTBilgi dtBilgi;
    @XmlElement(name = "Durum_Onay")
    protected String durumOnay;
    @XmlElement(name = "SanalPOS_Banka")
    protected String sanalPOSBanka;
    @XmlElement(name = "SanalPOS_Islem_ID")
    protected String sanalPOSIslemID;
    @XmlElement(name = "Odeme_Yapan_Bilgisi")
    protected String odemeYapanBilgisi;
    @XmlElement(name = "ODEME_TUTAR")
    protected String odemetutar;
    @XmlElement(name = "Komisyon_Odeyen_Aciklama")
    protected String komisyonOdeyenAciklama;
    @XmlElement(name = "islem_durumu")
    protected String islemDurumu;
    @XmlElement(name = "tutar_urun")
    protected String tutarUrun;
    @XmlElement(name = "AltUye_Isyeri_Ad_Soyad")
    protected String altUyeIsyeriAdSoyad;
    @XmlElement(name = "uye_isyeri_odeme_tutar\u0131")
    protected String uyeIsyeriOdemeTutarı;
    @XmlElement(name = "param_komisyon_orani")
    protected String paramKomisyonOrani;
    @XmlElement(name = "param_komisyon_ucreti")
    protected String paramKomisyonUcreti;
    @XmlElement(name = "alt_uye_is_yeri_odeme_tutarı")
    protected String altUyeIsYeriOdemeTutarı;
    @XmlElement(name = "Valör")
    protected String valör;

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
     * Gets the value of the dtBilgi property.
     * 
     * @return
     *     possible object is
     *     {@link IslemIzlemeRes.DTBilgi }
     *     
     */
    public IslemIzlemeRes.DTBilgi getDTBilgi() {
        return dtBilgi;
    }

    /**
     * Sets the value of the dtBilgi property.
     * 
     * @param value
     *     allowed object is
     *     {@link IslemIzlemeRes.DTBilgi }
     *     
     */
    public void setDTBilgi(IslemIzlemeRes.DTBilgi value) {
        this.dtBilgi = value;
    }

    /**
     * Gets the value of the durumOnay property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getDurumOnay() {
        return durumOnay;
    }

    /**
     * Sets the value of the durumOnay property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setDurumOnay(String value) {
        this.durumOnay = value;
    }

    /**
     * Gets the value of the sanalPOSBanka property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSanalPOSBanka() {
        return sanalPOSBanka;
    }

    /**
     * Sets the value of the sanalPOSBanka property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSanalPOSBanka(String value) {
        this.sanalPOSBanka = value;
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
     * Gets the value of the odemeYapanBilgisi property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getOdemeYapanBilgisi() {
        return odemeYapanBilgisi;
    }

    /**
     * Sets the value of the odemeYapanBilgisi property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setOdemeYapanBilgisi(String value) {
        this.odemeYapanBilgisi = value;
    }

    /**
     * Gets the value of the odemetutar property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getODEMETUTAR() {
        return odemetutar;
    }

    /**
     * Sets the value of the odemetutar property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setODEMETUTAR(String value) {
        this.odemetutar = value;
    }

    /**
     * Gets the value of the komisyonOdeyenAciklama property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKomisyonOdeyenAciklama() {
        return komisyonOdeyenAciklama;
    }

    /**
     * Sets the value of the komisyonOdeyenAciklama property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKomisyonOdeyenAciklama(String value) {
        this.komisyonOdeyenAciklama = value;
    }

    /**
     * Gets the value of the islemDurumu property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIslemDurumu() {
        return islemDurumu;
    }

    /**
     * Sets the value of the islemDurumu property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIslemDurumu(String value) {
        this.islemDurumu = value;
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
     * Gets the value of the altUyeIsyeriAdSoyad property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getAltUyeIsyeriAdSoyad() {
        return altUyeIsyeriAdSoyad;
    }

    /**
     * Sets the value of the altUyeIsyeriAdSoyad property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setAltUyeIsyeriAdSoyad(String value) {
        this.altUyeIsyeriAdSoyad = value;
    }

    /**
     * Gets the value of the uyeIsyeriOdemeTutar\u0131 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getUyeIsyeriOdemeTutarı() {
        return uyeIsyeriOdemeTutarı;
    }

    /**
     * Sets the value of the uyeIsyeriOdemeTutar\u0131 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setUyeIsyeriOdemeTutarı (String value) {
        this.uyeIsyeriOdemeTutarı = value;
    }

    /**
     * Gets the value of the paramKomisyonOrani property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getParamKomisyonOrani() {
        return paramKomisyonOrani;
    }

    /**
     * Sets the value of the paramKomisyonOrani property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setParamKomisyonOrani(String value) {
        this.paramKomisyonOrani = value;
    }

    /**
     * Gets the value of the paramKomisyonUcreti property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getParamKomisyonUcreti() {
        return paramKomisyonUcreti;
    }

    /**
     * Sets the value of the paramKomisyonUcreti property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setParamKomisyonUcreti(String value) {
        this.paramKomisyonUcreti = value;
    }

    /**
     * Gets the value of the altUyeIsYeriOdemeTutarı property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getAltUyeIsYeriOdemeTutarı() {
        return altUyeIsYeriOdemeTutarı;
    }

    /**
     * Sets the value of the altUyeIsYeriOdemeTutarı property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setAltUyeIsYeriOdemeTutarı(String value) {
        this.altUyeIsYeriOdemeTutarı = value;
    }

    /**
     * Gets the value of the val�r property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getValör() {
        return valör;
    }

    /**
     * Sets the value of the val�r property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setValör(String value) {
        this.valör = value;
    }


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
     *         &lt;any processContents='lax' namespace='urn:schemas-microsoft-com:xml-diffgram-v1'/&gt;
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
        "any"
    })
    public static class DTBilgi {

        @XmlAnyElement(lax = true)
        protected Object any;

        /**
         * Gets the value of the any property.
         * 
         * @return
         *     possible object is
         *     {@link Element }
         *     {@link Object }
         *     
         */
        public Object getAny() {
            return any;
        }

        /**
         * Sets the value of the any property.
         * 
         * @param value
         *     allowed object is
         *     {@link Element }
         *     {@link Object }
         *     
         */
        public void setAny(Object value) {
            this.any = value;
        }

    }

}
