
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
 *         &lt;element name="Payment_HopiResult" type="{https://turkpos.com.tr/}CL_Res_Payment_Hopi" minOccurs="0"/&gt;
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
    "paymentHopiResult"
})
@XmlRootElement(name = "Payment_HopiResponse")
public class PaymentHopiResponse {

    @XmlElement(name = "Payment_HopiResult")
    protected CLResPaymentHopi paymentHopiResult;

    /**
     * Gets the value of the paymentHopiResult property.
     * 
     * @return
     *     possible object is
     *     {@link CLResPaymentHopi }
     *     
     */
    public CLResPaymentHopi getPaymentHopiResult() {
        return paymentHopiResult;
    }

    /**
     * Sets the value of the paymentHopiResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLResPaymentHopi }
     *     
     */
    public void setPaymentHopiResult(CLResPaymentHopi value) {
        this.paymentHopiResult = value;
    }

}
