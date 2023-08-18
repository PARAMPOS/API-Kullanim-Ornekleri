
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for CL_L_Res_MP_OCR complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="CL_L_Res_MP_OCR"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="BankResultCode" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="BankResultMessage" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "CL_L_Res_MP_OCR", propOrder = {
    "bankResultCode",
    "bankResultMessage"
})
public class CLLResMPOCR {

    @XmlElement(name = "BankResultCode")
    protected String bankResultCode;
    @XmlElement(name = "BankResultMessage")
    protected String bankResultMessage;

    /**
     * Gets the value of the bankResultCode property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankResultCode() {
        return bankResultCode;
    }

    /**
     * Sets the value of the bankResultCode property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankResultCode(String value) {
        this.bankResultCode = value;
    }

    /**
     * Gets the value of the bankResultMessage property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankResultMessage() {
        return bankResultMessage;
    }

    /**
     * Sets the value of the bankResultMessage property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankResultMessage(String value) {
        this.bankResultMessage = value;
    }

}
