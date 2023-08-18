
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
 *         &lt;element name="MP_OrderDetailQueryResult" type="{https://turkpos.com.tr/}CL_Res_MP_ODQ" minOccurs="0"/&gt;
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
    "mpOrderDetailQueryResult"
})
@XmlRootElement(name = "MP_OrderDetailQueryResponse")
public class MPOrderDetailQueryResponse {

    @XmlElement(name = "MP_OrderDetailQueryResult")
    protected CLResMPODQ mpOrderDetailQueryResult;

    /**
     * Gets the value of the mpOrderDetailQueryResult property.
     * 
     * @return
     *     possible object is
     *     {@link CLResMPODQ }
     *     
     */
    public CLResMPODQ getMPOrderDetailQueryResult() {
        return mpOrderDetailQueryResult;
    }

    /**
     * Sets the value of the mpOrderDetailQueryResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLResMPODQ }
     *     
     */
    public void setMPOrderDetailQueryResult(CLResMPODQ value) {
        this.mpOrderDetailQueryResult = value;
    }

}
