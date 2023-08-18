
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
 *         &lt;element name="MP_OrderDetailListResult" type="{https://turkpos.com.tr/}CL_Res_MP_ODL" minOccurs="0"/&gt;
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
    "mpOrderDetailListResult"
})
@XmlRootElement(name = "MP_OrderDetailListResponse")
public class MPOrderDetailListResponse {

    @XmlElement(name = "MP_OrderDetailListResult")
    protected CLResMPODL mpOrderDetailListResult;

    /**
     * Gets the value of the mpOrderDetailListResult property.
     * 
     * @return
     *     possible object is
     *     {@link CLResMPODL }
     *     
     */
    public CLResMPODL getMPOrderDetailListResult() {
        return mpOrderDetailListResult;
    }

    /**
     * Sets the value of the mpOrderDetailListResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLResMPODL }
     *     
     */
    public void setMPOrderDetailListResult(CLResMPODL value) {
        this.mpOrderDetailListResult = value;
    }

}
