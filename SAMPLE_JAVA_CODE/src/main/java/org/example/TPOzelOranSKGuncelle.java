
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
 *         &lt;element name="Ozel_Oran_SK_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_1" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_2" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_3" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_4" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_5" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_6" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_7" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_8" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_9" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_10" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_11" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="MO_12" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "ozelOranSKID",
    "mo1",
    "mo2",
    "mo3",
    "mo4",
    "mo5",
    "mo6",
    "mo7",
    "mo8",
    "mo9",
    "mo10",
    "mo11",
    "mo12"
})
@XmlRootElement(name = "TP_Ozel_Oran_SK_Guncelle")
public class TPOzelOranSKGuncelle {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "GUID")
    protected String guid;
    @XmlElement(name = "Ozel_Oran_SK_ID")
    protected String ozelOranSKID;
    @XmlElement(name = "MO_1")
    protected String mo1;
    @XmlElement(name = "MO_2")
    protected String mo2;
    @XmlElement(name = "MO_3")
    protected String mo3;
    @XmlElement(name = "MO_4")
    protected String mo4;
    @XmlElement(name = "MO_5")
    protected String mo5;
    @XmlElement(name = "MO_6")
    protected String mo6;
    @XmlElement(name = "MO_7")
    protected String mo7;
    @XmlElement(name = "MO_8")
    protected String mo8;
    @XmlElement(name = "MO_9")
    protected String mo9;
    @XmlElement(name = "MO_10")
    protected String mo10;
    @XmlElement(name = "MO_11")
    protected String mo11;
    @XmlElement(name = "MO_12")
    protected String mo12;

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
     * Gets the value of the ozelOranSKID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getOzelOranSKID() {
        return ozelOranSKID;
    }

    /**
     * Sets the value of the ozelOranSKID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setOzelOranSKID(String value) {
        this.ozelOranSKID = value;
    }

    /**
     * Gets the value of the mo1 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO1() {
        return mo1;
    }

    /**
     * Sets the value of the mo1 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO1(String value) {
        this.mo1 = value;
    }

    /**
     * Gets the value of the mo2 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO2() {
        return mo2;
    }

    /**
     * Sets the value of the mo2 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO2(String value) {
        this.mo2 = value;
    }

    /**
     * Gets the value of the mo3 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO3() {
        return mo3;
    }

    /**
     * Sets the value of the mo3 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO3(String value) {
        this.mo3 = value;
    }

    /**
     * Gets the value of the mo4 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO4() {
        return mo4;
    }

    /**
     * Sets the value of the mo4 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO4(String value) {
        this.mo4 = value;
    }

    /**
     * Gets the value of the mo5 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO5() {
        return mo5;
    }

    /**
     * Sets the value of the mo5 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO5(String value) {
        this.mo5 = value;
    }

    /**
     * Gets the value of the mo6 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO6() {
        return mo6;
    }

    /**
     * Sets the value of the mo6 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO6(String value) {
        this.mo6 = value;
    }

    /**
     * Gets the value of the mo7 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO7() {
        return mo7;
    }

    /**
     * Sets the value of the mo7 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO7(String value) {
        this.mo7 = value;
    }

    /**
     * Gets the value of the mo8 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO8() {
        return mo8;
    }

    /**
     * Sets the value of the mo8 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO8(String value) {
        this.mo8 = value;
    }

    /**
     * Gets the value of the mo9 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO9() {
        return mo9;
    }

    /**
     * Sets the value of the mo9 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO9(String value) {
        this.mo9 = value;
    }

    /**
     * Gets the value of the mo10 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO10() {
        return mo10;
    }

    /**
     * Sets the value of the mo10 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO10(String value) {
        this.mo10 = value;
    }

    /**
     * Gets the value of the mo11 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO11() {
        return mo11;
    }

    /**
     * Sets the value of the mo11 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO11(String value) {
        this.mo11 = value;
    }

    /**
     * Gets the value of the mo12 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getMO12() {
        return mo12;
    }

    /**
     * Sets the value of the mo12 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setMO12(String value) {
        this.mo12 = value;
    }

}
