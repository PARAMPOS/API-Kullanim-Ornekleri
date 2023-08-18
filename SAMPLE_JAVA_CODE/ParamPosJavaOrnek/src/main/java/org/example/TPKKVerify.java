
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
 *         &lt;element name="KK_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_SK_Ay" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_SK_Yil" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KK_CVC" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Return_URL" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data1" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data2" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data3" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data4" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data5" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "kkNo",
    "kkskAy",
    "kkskYil",
    "kkcvc",
    "returnURL",
    "data1",
    "data2",
    "data3",
    "data4",
    "data5"
})
@XmlRootElement(name = "TP_KK_Verify")
public class TPKKVerify {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "KK_No")
    protected String kkNo;
    @XmlElement(name = "KK_SK_Ay")
    protected String kkskAy;
    @XmlElement(name = "KK_SK_Yil")
    protected String kkskYil;
    @XmlElement(name = "KK_CVC")
    protected String kkcvc;
    @XmlElement(name = "Return_URL")
    protected String returnURL;
    @XmlElement(name = "Data1")
    protected String data1;
    @XmlElement(name = "Data2")
    protected String data2;
    @XmlElement(name = "Data3")
    protected String data3;
    @XmlElement(name = "Data4")
    protected String data4;
    @XmlElement(name = "Data5")
    protected String data5;

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
     * Gets the value of the kkcvc property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKKCVC() {
        return kkcvc;
    }

    /**
     * Sets the value of the kkcvc property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKKCVC(String value) {
        this.kkcvc = value;
    }

    /**
     * Gets the value of the returnURL property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getReturnURL() {
        return returnURL;
    }

    /**
     * Sets the value of the returnURL property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setReturnURL(String value) {
        this.returnURL = value;
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

    /**
     * Gets the value of the data4 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData4() {
        return data4;
    }

    /**
     * Sets the value of the data4 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData4(String value) {
        this.data4 = value;
    }

    /**
     * Gets the value of the data5 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData5() {
        return data5;
    }

    /**
     * Sets the value of the data5 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData5(String value) {
        this.data5 = value;
    }

}
