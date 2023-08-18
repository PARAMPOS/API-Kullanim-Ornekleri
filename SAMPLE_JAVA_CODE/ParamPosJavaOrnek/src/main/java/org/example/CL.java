
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for CL complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="CL"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Odeme_Sonuc" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Odeme_Sonuc_Aciklama" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Dekont_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Siparis_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Islem_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Durum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tarih" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Toplam_Tutar" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="Komisyon_Oran" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="Komisyon_Tutar" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="Banka_Sonuc_Aciklama" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Taksit" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Ext_Data" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Toplam_Iade_Tutar" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="KK_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Extra" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_HostRefNum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "CL", propOrder = {
    "odemeSonuc",
    "odemeSonucAciklama",
    "dekontID",
    "siparisID",
    "islemID",
    "durum",
    "tarih",
    "toplamTutar",
    "komisyonOran",
    "komisyonTutar",
    "bankaSonucAciklama",
    "taksit",
    "extData",
    "toplamIadeTutar",
    "kkNo",
    "bankExtra",
    "bankHostRefNum"
})
public class CL {

    @XmlElement(name = "Odeme_Sonuc")
    protected int odemeSonuc;
    @XmlElement(name = "Odeme_Sonuc_Aciklama")
    protected String odemeSonucAciklama;
    @XmlElement(name = "Dekont_ID")
    protected String dekontID;
    @XmlElement(name = "Siparis_ID")
    protected String siparisID;
    @XmlElement(name = "Islem_ID")
    protected String islemID;
    @XmlElement(name = "Durum")
    protected String durum;
    @XmlElement(name = "Tarih")
    protected String tarih;
    @XmlElement(name = "Toplam_Tutar")
    protected double toplamTutar;
    @XmlElement(name = "Komisyon_Oran")
    protected double komisyonOran;
    @XmlElement(name = "Komisyon_Tutar")
    protected double komisyonTutar;
    @XmlElement(name = "Banka_Sonuc_Aciklama")
    protected String bankaSonucAciklama;
    @XmlElement(name = "Taksit")
    protected int taksit;
    @XmlElement(name = "Ext_Data")
    protected String extData;
    @XmlElement(name = "Toplam_Iade_Tutar")
    protected double toplamIadeTutar;
    @XmlElement(name = "KK_No")
    protected String kkNo;
    @XmlElement(name = "Bank_Extra")
    protected String bankExtra;
    @XmlElement(name = "Bank_HostRefNum")
    protected String bankHostRefNum;

    /**
     * Gets the value of the odemeSonuc property.
     * 
     */
    public int getOdemeSonuc() {
        return odemeSonuc;
    }

    /**
     * Sets the value of the odemeSonuc property.
     * 
     */
    public void setOdemeSonuc(int value) {
        this.odemeSonuc = value;
    }

    /**
     * Gets the value of the odemeSonucAciklama property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getOdemeSonucAciklama() {
        return odemeSonucAciklama;
    }

    /**
     * Sets the value of the odemeSonucAciklama property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setOdemeSonucAciklama(String value) {
        this.odemeSonucAciklama = value;
    }

    /**
     * Gets the value of the dekontID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getDekontID() {
        return dekontID;
    }

    /**
     * Sets the value of the dekontID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setDekontID(String value) {
        this.dekontID = value;
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
     * Gets the value of the islemID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getIslemID() {
        return islemID;
    }

    /**
     * Sets the value of the islemID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setIslemID(String value) {
        this.islemID = value;
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
     * Gets the value of the tarih property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTarih() {
        return tarih;
    }

    /**
     * Sets the value of the tarih property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTarih(String value) {
        this.tarih = value;
    }

    /**
     * Gets the value of the toplamTutar property.
     * 
     */
    public double getToplamTutar() {
        return toplamTutar;
    }

    /**
     * Sets the value of the toplamTutar property.
     * 
     */
    public void setToplamTutar(double value) {
        this.toplamTutar = value;
    }

    /**
     * Gets the value of the komisyonOran property.
     * 
     */
    public double getKomisyonOran() {
        return komisyonOran;
    }

    /**
     * Sets the value of the komisyonOran property.
     * 
     */
    public void setKomisyonOran(double value) {
        this.komisyonOran = value;
    }

    /**
     * Gets the value of the komisyonTutar property.
     * 
     */
    public double getKomisyonTutar() {
        return komisyonTutar;
    }

    /**
     * Sets the value of the komisyonTutar property.
     * 
     */
    public void setKomisyonTutar(double value) {
        this.komisyonTutar = value;
    }

    /**
     * Gets the value of the bankaSonucAciklama property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankaSonucAciklama() {
        return bankaSonucAciklama;
    }

    /**
     * Sets the value of the bankaSonucAciklama property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankaSonucAciklama(String value) {
        this.bankaSonucAciklama = value;
    }

    /**
     * Gets the value of the taksit property.
     * 
     */
    public int getTaksit() {
        return taksit;
    }

    /**
     * Sets the value of the taksit property.
     * 
     */
    public void setTaksit(int value) {
        this.taksit = value;
    }

    /**
     * Gets the value of the extData property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getExtData() {
        return extData;
    }

    /**
     * Sets the value of the extData property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setExtData(String value) {
        this.extData = value;
    }

    /**
     * Gets the value of the toplamIadeTutar property.
     * 
     */
    public double getToplamIadeTutar() {
        return toplamIadeTutar;
    }

    /**
     * Sets the value of the toplamIadeTutar property.
     * 
     */
    public void setToplamIadeTutar(double value) {
        this.toplamIadeTutar = value;
    }

    /**
     * Gets the value of the kkNo property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKNo() {
        return kkNo;
    }

    /**
     * Sets the value of the kkNo property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKNo(String value) {
        this.kkNo = value;
    }

    /**
     * Gets the value of the bankExtra property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankExtra() {
        return bankExtra;
    }

    /**
     * Sets the value of the bankExtra property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankExtra(String value) {
        this.bankExtra = value;
    }

    /**
     * Gets the value of the bankHostRefNum property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankHostRefNum() {
        return bankHostRefNum;
    }

    /**
     * Sets the value of the bankHostRefNum property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankHostRefNum(String value) {
        this.bankHostRefNum = value;
    }

}
