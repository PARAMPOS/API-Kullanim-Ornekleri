
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for CL_Req_MP_ODU_Data complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="CL_Req_MP_ODU_Data"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="PaymentGuid" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="OrderDetailGuid" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SubSellerId" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="ProductAmount" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="PayableAmount" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="OtherPayableAmount" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="CurrentReceiptId" type="{http://www.w3.org/2001/XMLSchema}long"/&gt;
 *         &lt;element name="NewOtherPayableAmount" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "CL_Req_MP_ODU_Data", propOrder = {
    "paymentGuid",
    "orderDetailGuid",
    "subSellerId",
    "productAmount",
    "payableAmount",
    "otherPayableAmount",
    "currentReceiptId",
    "newOtherPayableAmount"
})
public class CLReqMPODUData {

    @XmlElement(name = "PaymentGuid")
    protected String paymentGuid;
    @XmlElement(name = "OrderDetailGuid")
    protected String orderDetailGuid;
    @XmlElement(name = "SubSellerId")
    protected String subSellerId;
    @XmlElement(name = "ProductAmount")
    protected double productAmount;
    @XmlElement(name = "PayableAmount")
    protected double payableAmount;
    @XmlElement(name = "OtherPayableAmount")
    protected double otherPayableAmount;
    @XmlElement(name = "CurrentReceiptId")
    protected long currentReceiptId;
    @XmlElement(name = "NewOtherPayableAmount")
    protected double newOtherPayableAmount;

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
     * Gets the value of the orderDetailGuid property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getOrderDetailGuid() {
        return orderDetailGuid;
    }

    /**
     * Sets the value of the orderDetailGuid property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setOrderDetailGuid(String value) {
        this.orderDetailGuid = value;
    }

    /**
     * Gets the value of the subSellerId property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSubSellerId() {
        return subSellerId;
    }

    /**
     * Sets the value of the subSellerId property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSubSellerId(String value) {
        this.subSellerId = value;
    }

    /**
     * Gets the value of the productAmount property.
     * 
     */
    public double getProductAmount() {
        return productAmount;
    }

    /**
     * Sets the value of the productAmount property.
     * 
     */
    public void setProductAmount(double value) {
        this.productAmount = value;
    }

    /**
     * Gets the value of the payableAmount property.
     * 
     */
    public double getPayableAmount() {
        return payableAmount;
    }

    /**
     * Sets the value of the payableAmount property.
     * 
     */
    public void setPayableAmount(double value) {
        this.payableAmount = value;
    }

    /**
     * Gets the value of the otherPayableAmount property.
     * 
     */
    public double getOtherPayableAmount() {
        return otherPayableAmount;
    }

    /**
     * Sets the value of the otherPayableAmount property.
     * 
     */
    public void setOtherPayableAmount(double value) {
        this.otherPayableAmount = value;
    }

    /**
     * Gets the value of the currentReceiptId property.
     * 
     */
    public long getCurrentReceiptId() {
        return currentReceiptId;
    }

    /**
     * Sets the value of the currentReceiptId property.
     * 
     */
    public void setCurrentReceiptId(long value) {
        this.currentReceiptId = value;
    }

    /**
     * Gets the value of the newOtherPayableAmount property.
     * 
     */
    public double getNewOtherPayableAmount() {
        return newOtherPayableAmount;
    }

    /**
     * Sets the value of the newOtherPayableAmount property.
     * 
     */
    public void setNewOtherPayableAmount(double value) {
        this.newOtherPayableAmount = value;
    }

}
