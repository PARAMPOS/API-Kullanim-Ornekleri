
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
 *         &lt;element name="TP_Multiple_Payment_StatusResult" type="{https://turkpos.com.tr/}CL_Multiple_Payment_Status" minOccurs="0"/&gt;
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
    "tpMultiplePaymentStatusResult"
})
@XmlRootElement(name = "TP_Multiple_Payment_StatusResponse")
public class TPMultiplePaymentStatusResponse {

    @XmlElement(name = "TP_Multiple_Payment_StatusResult")
    protected CLMultiplePaymentStatus tpMultiplePaymentStatusResult;

    /**
     * Gets the value of the tpMultiplePaymentStatusResult property.
     * 
     * @return
     *     possible object is
     *     {@link CLMultiplePaymentStatus }
     *     
     */
    public CLMultiplePaymentStatus getTPMultiplePaymentStatusResult() {
        return tpMultiplePaymentStatusResult;
    }

    /**
     * Sets the value of the tpMultiplePaymentStatusResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLMultiplePaymentStatus }
     *     
     */
    public void setTPMultiplePaymentStatusResult(CLMultiplePaymentStatus value) {
        this.tpMultiplePaymentStatusResult = value;
    }

}
