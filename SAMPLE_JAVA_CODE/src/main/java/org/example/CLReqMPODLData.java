
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for CL_Req_MP_ODL_Data complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="CL_Req_MP_ODL_Data"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="PaymentGuid" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="OrderStatus" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "CL_Req_MP_ODL_Data", propOrder = {
    "paymentGuid",
    "orderStatus"
})
public class CLReqMPODLData {

    @XmlElement(name = "PaymentGuid")
    protected String paymentGuid;
    @XmlElement(name = "OrderStatus")
    protected int orderStatus;

    /**
     * Gets the value of the paymentGuid property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getPaymentGuid() {
        return paymentGuid;
    }

    /**
     * Sets the value of the paymentGuid property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setPaymentGuid(String value) {
        this.paymentGuid = value;
    }

    /**
     * Gets the value of the orderStatus property.
     * 
     */
    public int getOrderStatus() {
        return orderStatus;
    }

    /**
     * Sets the value of the orderStatus property.
     * 
     */
    public void setOrderStatus(int value) {
        this.orderStatus = value;
    }

}
