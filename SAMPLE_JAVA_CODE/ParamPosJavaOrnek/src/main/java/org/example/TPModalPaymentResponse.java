
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
 *         &lt;element name="TP_Modal_PaymentResult" type="{https://turkpos.com.tr/}CL_Res_Odeme" minOccurs="0"/&gt;
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
    "tpModalPaymentResult"
})
@XmlRootElement(name = "TP_Modal_PaymentResponse")
public class TPModalPaymentResponse {

    @XmlElement(name = "TP_Modal_PaymentResult")
    protected CLResOdeme tpModalPaymentResult;

    /**
     * Gets the value of the tpModalPaymentResult property.
     * 
     * @return
     *     possible object is
     *     {@link CLResOdeme }
     *     
     */
    public CLResOdeme getTPModalPaymentResult() {
        return tpModalPaymentResult;
    }

    /**
     * Sets the value of the tpModalPaymentResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLResOdeme }
     *     
     */
    public void setTPModalPaymentResult(CLResOdeme value) {
        this.tpModalPaymentResult = value;
    }

}
