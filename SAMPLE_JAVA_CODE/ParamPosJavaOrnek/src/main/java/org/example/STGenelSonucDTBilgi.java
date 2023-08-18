
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ST_Genel_SonucDT_Bilgi complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ST_Genel_SonucDT_Bilgi"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="BIN" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SanalPOS_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Kart_Banka" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="DKK" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Kart_Tip" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Kart_Org" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Banka_Kodu" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Kart_Ticari" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Kart_Marka" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ST_Genel_SonucDT_Bilgi", propOrder = {
    "bin",
    "sanalPOSID",
    "kartBanka",
    "dkk",
    "kartTip",
    "kartOrg",
    "bankaKodu",
    "kartTicari",
    "kartMarka"
})
public class STGenelSonucDTBilgi {

    @XmlElement(name = "BIN")
    protected String bin;
    @XmlElement(name = "SanalPOS_ID")
    protected String sanalPOSID;
    @XmlElement(name = "Kart_Banka")
    protected String kartBanka;
    @XmlElement(name = "DKK")
    protected String dkk;
    @XmlElement(name = "Kart_Tip")
    protected String kartTip;
    @XmlElement(name = "Kart_Org")
    protected String kartOrg;
    @XmlElement(name = "Banka_Kodu")
    protected String bankaKodu;
    @XmlElement(name = "Kart_Ticari")
    protected String kartTicari;
    @XmlElement(name = "Kart_Marka")
    protected String kartMarka;

    /**
     * Gets the value of the bin property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBIN() {
        return bin;
    }

    /**
     * Sets the value of the bin property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBIN(String value) {
        this.bin = value;
    }

    /**
     * Gets the value of the sanalPOSID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSanalPOSID() {
        return sanalPOSID;
    }

    /**
     * Sets the value of the sanalPOSID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSanalPOSID(String value) {
        this.sanalPOSID = value;
    }

    /**
     * Gets the value of the kartBanka property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKartBanka() {
        return kartBanka;
    }

    /**
     * Sets the value of the kartBanka property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKartBanka(String value) {
        this.kartBanka = value;
    }

    /**
     * Gets the value of the dkk property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getDKK() {
        return dkk;
    }

    /**
     * Sets the value of the dkk property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setDKK(String value) {
        this.dkk = value;
    }

    /**
     * Gets the value of the kartTip property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKartTip() {
        return kartTip;
    }

    /**
     * Sets the value of the kartTip property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKartTip(String value) {
        this.kartTip = value;
    }

    /**
     * Gets the value of the kartOrg property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKartOrg() {
        return kartOrg;
    }

    /**
     * Sets the value of the kartOrg property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKartOrg(String value) {
        this.kartOrg = value;
    }

    /**
     * Gets the value of the bankaKodu property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankaKodu() {
        return bankaKodu;
    }

    /**
     * Sets the value of the bankaKodu property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankaKodu(String value) {
        this.bankaKodu = value;
    }

    /**
     * Gets the value of the kartTicari property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKartTicari() {
        return kartTicari;
    }

    /**
     * Sets the value of the kartTicari property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKartTicari(String value) {
        this.kartTicari = value;
    }

    /**
     * Gets the value of the kartMarka property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKartMarka() {
        return kartMarka;
    }

    /**
     * Sets the value of the kartMarka property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKartMarka(String value) {
        this.kartMarka = value;
    }

}
