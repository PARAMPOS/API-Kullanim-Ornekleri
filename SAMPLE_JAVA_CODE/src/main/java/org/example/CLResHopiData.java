
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for CL_Res_Hopi_Data complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="CL_Res_Hopi_Data"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="ReceiptId" type="{http://www.w3.org/2001/XMLSchema}long"/&gt;
 *         &lt;element name="OrderId" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data1" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data2" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data3" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data4" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Data5" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "CL_Res_Hopi_Data", propOrder = {
    "receiptId",
    "orderId",
    "data1",
    "data2",
    "data3",
    "data4",
    "data5"
})
public class CLResHopiData {

    @XmlElement(name = "ReceiptId")
    protected long receiptId;
    @XmlElement(name = "OrderId")
    protected String orderId;
    @XmlElement(name = "Data1")
    protected String data1;
    @XmlElement(name = "Data2")
    protected String data2;
    @XmlElement(name = "Data3")
    protected String data3;
    @XmlElement(name = "Data4")
    protected String data4;
    @XmlElement(name = "Data5")
    protected String data5;

    /**
     * Gets the value of the receiptId property.
     * 
     */
    public long getReceiptId() {
        return receiptId;
    }

    /**
     * Sets the value of the receiptId property.
     * 
     */
    public void setReceiptId(long value) {
        this.receiptId = value;
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
     * Gets the value of the data1 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData1() {
        return data1;
    }

    /**
     * Sets the value of the data1 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData1(String value) {
        this.data1 = value;
    }

    /**
     * Gets the value of the data2 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData2() {
        return data2;
    }

    /**
     * Sets the value of the data2 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData2(String value) {
        this.data2 = value;
    }

    /**
     * Gets the value of the data3 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData3() {
        return data3;
    }

    /**
     * Sets the value of the data3 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData3(String value) {
        this.data3 = value;
    }

    /**
     * Gets the value of the data4 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData4() {
        return data4;
    }

    /**
     * Sets the value of the data4 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData4(String value) {
        this.data4 = value;
    }

    /**
     * Gets the value of the data5 property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getData5() {
        return data5;
    }

    /**
     * Sets the value of the data5 property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setData5(String value) {
        this.data5 = value;
    }

}
