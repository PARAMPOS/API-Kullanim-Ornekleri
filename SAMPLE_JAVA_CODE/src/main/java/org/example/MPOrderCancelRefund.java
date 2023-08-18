
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
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
 *         &lt;element name="d" type="{https://turkpos.com.tr/}CL_Req_MP_OCR" minOccurs="0"/&gt;
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
    "d"
})
@XmlRootElement(name = "MP_OrderCancelRefund")
public class MPOrderCancelRefund {

    protected CLReqMPOCR d;

    /**
     * Gets the value of the d property.
     * 
     * @return
     *     possible object is
     *     {@link CLReqMPOCR }
     *     
     */
    public CLReqMPOCR getD() {
        return d;
    }

    /**
     * Sets the value of the d property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLReqMPOCR }
     *     
     */
    public void setD(CLReqMPOCR value) {
        this.d = value;
    }

}
