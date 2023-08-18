
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
 *         &lt;element name="TP_Multiple_PaymentResult" type="{https://turkpos.com.tr/}CL_Multiple_Payment" minOccurs="0"/&gt;
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
    "tpMultiplePaymentResult"
})
@XmlRootElement(name = "TP_Multiple_PaymentResponse")
public class TPMultiplePaymentResponse {

    @XmlElement(name = "TP_Multiple_PaymentResult")
    protected CLMultiplePayment tpMultiplePaymentResult;

    /**
     * Gets the value of the tpMultiplePaymentResult property.
     * 
     * @return
     *     possible object is
     *     {@link CLMultiplePayment }
     *     
     */
    public CLMultiplePayment getTPMultiplePaymentResult() {
        return tpMultiplePaymentResult;
    }

    /**
     * Sets the value of the tpMultiplePaymentResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLMultiplePayment }
     *     
     */
    public void setTPMultiplePaymentResult(CLMultiplePayment value) {
        this.tpMultiplePaymentResult = value;
    }

}
