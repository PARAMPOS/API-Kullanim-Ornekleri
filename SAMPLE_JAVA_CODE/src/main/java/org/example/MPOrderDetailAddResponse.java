
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
 *         &lt;element name="MP_OrderDetailAddResult" type="{https://turkpos.com.tr/}CL_Res_MP_ODA" minOccurs="0"/&gt;
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
    "mpOrderDetailAddResult"
})
@XmlRootElement(name = "MP_OrderDetailAddResponse")
public class MPOrderDetailAddResponse {

    @XmlElement(name = "MP_OrderDetailAddResult")
    protected CLResMPODA mpOrderDetailAddResult;

    /**
     * Gets the value of the mpOrderDetailAddResult property.
     * 
     * @return
     *     possible object is
     *     {@link CLResMPODA }
     *     
     */
    public CLResMPODA getMPOrderDetailAddResult() {
        return mpOrderDetailAddResult;
    }

    /**
     * Sets the value of the mpOrderDetailAddResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLResMPODA }
     *     
     */
    public void setMPOrderDetailAddResult(CLResMPODA value) {
        this.mpOrderDetailAddResult = value;
    }

}
