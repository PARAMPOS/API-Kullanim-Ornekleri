
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for IslemIzlemeReq complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="IslemIzlemeReq"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Kart_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tarih_Bas" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Tarih_Bit" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="GUID_AltUyeIsyeri" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "IslemIzlemeReq", propOrder = {
    "kartNo",
    "tarihBas",
    "tarihBit",
    "guidAltUyeIsyeri"
})
public class IslemIzlemeReq {

    @XmlElement(name = "Kart_No")
    protected String kartNo;
    @XmlElement(name = "Tarih_Bas")
    protected String tarihBas;
    @XmlElement(name = "Tarih_Bit")
    protected String tarihBit;
    @XmlElement(name = "GUID_AltUyeIsyeri")
    protected String guidAltUyeIsyeri;

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
     * Gets the value of the tarihBas property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTarihBas() {
        return tarihBas;
    }

    /**
     * Sets the value of the tarihBas property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTarihBas(String value) {
        this.tarihBas = value;
    }

    /**
     * Gets the value of the tarihBit property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getTarihBit() {
        return tarihBit;
    }

    /**
     * Sets the value of the tarihBit property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setTarihBit(String value) {
        this.tarihBit = value;
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

}
