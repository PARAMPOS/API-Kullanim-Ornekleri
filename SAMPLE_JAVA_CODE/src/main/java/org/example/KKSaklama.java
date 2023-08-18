
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
 *         &lt;element name="Kart_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_Sahibi" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_SK_Ay" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_SK_Yil" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_CVV" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data1" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data2" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data3" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "kartNo",
    "kkSahibi",
    "kkNo",
    "kkskAy",
    "kkskYil",
    "kkcvv",
    "data1",
    "data2",
    "data3"
})
@XmlRootElement(name = "KK_Saklama")
public class KKSaklama {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "Kart_No")
    protected String kartNo;
    @XmlElement(name = "KK_Sahibi")
    protected String kkSahibi;
    @XmlElement(name = "KK_No")
    protected String kkNo;
    @XmlElement(name = "KK_SK_Ay")
    protected String kkskAy;
    @XmlElement(name = "KK_SK_Yil")
    protected String kkskYil;
    @XmlElement(name = "KK_CVV")
    protected String kkcvv;
    @XmlElement(name = "Data1")
    protected String data1;
    @XmlElement(name = "Data2")
    protected String data2;
    @XmlElement(name = "Data3")
    protected String data3;

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
     * Gets the value of the kartNo property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKartNo() {
        return kartNo;
    }

    /**
     * Sets the value of the kartNo property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKartNo(String value) {
        this.kartNo = value;
    }

    /**
     * Gets the value of the kkSahibi property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKSahibi() {
        return kkSahibi;
    }

    /**
     * Sets the value of the kkSahibi property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKSahibi(String value) {
        this.kkSahibi = value;
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
     * Gets the value of the kkskAy property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKSKAy() {
        return kkskAy;
    }

    /**
     * Sets the value of the kkskAy property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKSKAy(String value) {
        this.kkskAy = value;
    }

    /**
     * Gets the value of the kkskYil property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKSKYil() {
        return kkskYil;
    }

    /**
     * Sets the value of the kkskYil property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKSKYil(String value) {
        this.kkskYil = value;
    }

    /**
     * Gets the value of the kkcvv property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKCVV() {
        return kkcvv;
    }

    /**
     * Sets the value of the kkcvv property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKCVV(String value) {
        this.kkcvv = value;
    }

    /**
     * Gets the value of the data1 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData1() {
        return data1;
    }

    /**
     * Sets the value of the data1 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData1(String value) {
        this.data1 = value;
    }

    /**
     * Gets the value of the data2 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData2() {
        return data2;
    }

    /**
     * Sets the value of the data2 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData2(String value) {
        this.data2 = value;
    }

    /**
     * Gets the value of the data3 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData3() {
        return data3;
    }

    /**
     * Sets the value of the data3 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData3(String value) {
        this.data3 = value;
    }

}
