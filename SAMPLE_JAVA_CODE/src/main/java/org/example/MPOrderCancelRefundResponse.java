
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
 *         &lt;element name="MP_OrderCancelRefundResult" type="{https://turkpos.com.tr/}CL_Res_MP_OCR" minOccurs="0"/&gt;
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
    "mpOrderCancelRefundResult"
})
@XmlRootElement(name = "MP_OrderCancelRefundResponse")
public class MPOrderCancelRefundResponse {

    @XmlElement(name = "MP_OrderCancelRefundResult")
    protected CLResMPOCR mpOrderCancelRefundResult;

    /**
     * Gets the value of the mpOrderCancelRefundResult property.
     * 
     * @return
     *     possible object is
     *     {@link CLResMPOCR }
     *     
     */
    public CLResMPOCR getMPOrderCancelRefundResult() {
        return mpOrderCancelRefundResult;
    }

    /**
     * Sets the value of the mpOrderCancelRefundResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLResMPOCR }
     *     
     */
    public void setMPOrderCancelRefundResult(CLResMPOCR value) {
        this.mpOrderCancelRefundResult = value;
    }

}
