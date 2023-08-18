
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for CL_Multiple_Payment_Status complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="CL_Multiple_Payment_Status"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="Result_Code" type="{http://www.w3.org/2001/XMLSchema}int"/&gt;
 *         &lt;element name="Result_Message" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Batch_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="List_Info" type="{https://turkpos.com.tr/}ArrayOfStatus" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "CL_Multiple_Payment_Status", propOrder = {
    "resultCode",
    "resultMessage",
    "batchID",
    "listInfo"
})
public class CLMultiplePaymentStatus {

    @XmlElement(name = "Result_Code")
    protected int resultCode;
    @XmlElement(name = "Result_Message")
    protected String resultMessage;
    @XmlElement(name = "Batch_ID")
    protected String batchID;
    @XmlElement(name = "List_Info")
    protected ArrayOfStatus listInfo;

    /**
     * Gets the value of the resultCode property.
     * 
     */
    public int getResultCode() {
        return resultCode;
    }

    /**
     * Sets the value of the resultCode property.
     * 
     */
    public void setResultCode(int value) {
        this.resultCode = value;
    }

    /**
     * Gets the value of the resultMessage property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getResultMessage() {
        return resultMessage;
    }

    /**
     * Sets the value of the resultMessage property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setResultMessage(String value) {
        this.resultMessage = value;
    }

    /**
     * Gets the value of the batchID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBatchID() {
        return batchID;
    }

    /**
     * Sets the value of the batchID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBatchID(String value) {
        this.batchID = value;
    }

    /**
     * Gets the value of the listInfo property.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfStatus }
     *     
     */
    public ArrayOfStatus getListInfo() {
        return listInfo;
    }

    /**
     * Sets the value of the listInfo property.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfStatus }
     *     
     */
    public void setListInfo(ArrayOfStatus value) {
        this.listInfo = value;
    }

}
