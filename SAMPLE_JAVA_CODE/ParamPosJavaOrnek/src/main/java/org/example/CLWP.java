
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for CL_WP complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="CL_WP"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Dekont_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Islem_Tip" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Durum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tarih" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tutar" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="Komisyon_Oran" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="Komisyon_Tutar" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="Iade_Tutar" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="Iade_Edilebilir_Tutar" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="Banka_Sonuc_Aciklama" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Taksit" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Ext_Data" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Extra" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_HostRefNum" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_Trans_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Bank_AuthCode" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "CL_WP", propOrder = {
    "dekontID",
    "islemTip",
    "durum",
    "tarih",
    "tutar",
    "komisyonOran",
    "komisyonTutar",
    "iadeTutar",
    "iadeEdilebilirTutar",
    "bankaSonucAciklama",
    "taksit",
    "extData",
    "kkNo",
    "bankExtra",
    "bankHostRefNum",
    "bankTransID",
    "bankAuthCode"
})
public class CLWP {

    @XmlElement(name = "Dekont_ID")
    protected String dekontID;
    @XmlElement(name = "Islem_Tip")
    protected String islemTip;
    @XmlElement(name = "Durum")
    protected String durum;
    @XmlElement(name = "Tarih")
    protected String tarih;
    @XmlElement(name = "Tutar")
    protected double tutar;
    @XmlElement(name = "Komisyon_Oran")
    protected double komisyonOran;
    @XmlElement(name = "Komisyon_Tutar")
    protected double komisyonTutar;
    @XmlElement(name = "Iade_Tutar")
    protected double iadeTutar;
    @XmlElement(name = "Iade_Edilebilir_Tutar")
    protected double iadeEdilebilirTutar;
    @XmlElement(name = "Banka_Sonuc_Aciklama")
    protected String bankaSonucAciklama;
    @XmlElement(name = "Taksit")
    protected int taksit;
    @XmlElement(name = "Ext_Data")
    protected String extData;
    @XmlElement(name = "KK_No")
    protected String kkNo;
    @XmlElement(name = "Bank_Extra")
    protected String bankExtra;
    @XmlElement(name = "Bank_HostRefNum")
    protected String bankHostRefNum;
    @XmlElement(name = "Bank_Trans_ID")
    protected String bankTransID;
    @XmlElement(name = "Bank_AuthCode")
    protected String bankAuthCode;

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
     * Gets the value of the tutar property.
     * 
     */
    public double getTutar() {
        return tutar;
    }

    /**
     * Sets the value of the tutar property.
     * 
     */
    public void setTutar(double value) {
        this.tutar = value;
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
     * Gets the value of the iadeTutar property.
     * 
     */
    public double getIadeTutar() {
        return iadeTutar;
    }

    /**
     * Sets the value of the iadeTutar property.
     * 
     */
    public void setIadeTutar(double value) {
        this.iadeTutar = value;
    }

    /**
     * Gets the value of the iadeEdilebilirTutar property.
     * 
     */
    public double getIadeEdilebilirTutar() {
        return iadeEdilebilirTutar;
    }

    /**
     * Sets the value of the iadeEdilebilirTutar property.
     * 
     */
    public void setIadeEdilebilirTutar(double value) {
        this.iadeEdilebilirTutar = value;
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

    /**
     * Gets the value of the bankTransID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankTransID() {
        return bankTransID;
    }

    /**
     * Sets the value of the bankTransID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankTransID(String value) {
        this.bankTransID = value;
    }

    /**
     * Gets the value of the bankAuthCode property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankAuthCode() {
        return bankAuthCode;
    }

    /**
     * Sets the value of the bankAuthCode property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankAuthCode(String value) {
        this.bankAuthCode = value;
    }

}
