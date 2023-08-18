
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
 *         &lt;element name="MP_OrderDetailStatusResult" type="{https://turkpos.com.tr/}CL_Res_MP_ODS" minOccurs="0"/&gt;
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
    "mpOrderDetailStatusResult"
})
@XmlRootElement(name = "MP_OrderDetailStatusResponse")
public class MPOrderDetailStatusResponse {

    @XmlElement(name = "MP_OrderDetailStatusResult")
    protected CLResMPODS mpOrderDetailStatusResult;

    /**
     * Gets the value of the mpOrderDetailStatusResult property.
     * 
     * @return
     *     possible object is
     *     {@link CLResMPODS }
     *     
     */
    public CLResMPODS getMPOrderDetailStatusResult() {
        return mpOrderDetailStatusResult;
    }

    /**
     * Sets the value of the mpOrderDetailStatusResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLResMPODS }
     *     
     */
    public void setMPOrderDetailStatusResult(CLResMPODS value) {
        this.mpOrderDetailStatusResult = value;
    }

}
