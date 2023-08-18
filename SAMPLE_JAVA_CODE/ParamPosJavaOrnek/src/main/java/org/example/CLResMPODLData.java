
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for CL_Res_MP_ODL_Data complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="CL_Res_MP_ODL_Data"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="OrderDetailGuid" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="ProductAmount" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="PayableAmount" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="OtherPayableAmount" type="{http://www.w3.org/2001/XMLSchema}double"/&gt;
 *         &lt;element name="OrderId" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="SubSellerId" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "CL_Res_MP_ODL_Data", propOrder = {
    "orderDetailGuid",
    "productAmount",
    "payableAmount",
    "otherPayableAmount",
    "orderId",
    "subSellerId"
})
public class CLResMPODLData {

    @XmlElement(name = "OrderDetailGuid")
    protected String orderDetailGuid;
    @XmlElement(name = "ProductAmount")
    protected double productAmount;
    @XmlElement(name = "PayableAmount")
    protected double payableAmount;
    @XmlElement(name = "OtherPayableAmount")
    protected double otherPayableAmount;
    @XmlElement(name = "OrderId")
    protected String orderId;
    @XmlElement(name = "SubSellerId")
    protected String subSellerId;

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
     * Gets the value of the orderId property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getOrderId() {
        return orderId;
    }

    /**
     * Sets the value of the orderId property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setOrderId(String value) {
        this.orderId = value;
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

}
