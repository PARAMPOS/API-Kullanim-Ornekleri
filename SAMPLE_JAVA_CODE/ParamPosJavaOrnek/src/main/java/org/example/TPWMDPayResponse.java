
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
 *         &lt;element name="TP_WMD_PayResult" type="{https://turkpos.com.tr/}ST_WMD_Pay"/&gt;
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
    "tpwmdPayResult"
})
@XmlRootElement(name = "TP_WMD_PayResponse")
public class TPWMDPayResponse {

    @XmlElement(name = "TP_WMD_PayResult", required = true)
    protected STWMDPay tpwmdPayResult;

    /**
     * Gets the value of the tpwmdPayResult property.
     * 
     * @return
     *     possible object is
     *     {@link STWMDPay }
     *     
     */
    public STWMDPay getTPWMDPayResult() {
        return tpwmdPayResult;
    }

    /**
     * Sets the value of the tpwmdPayResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STWMDPay }
     *     
     */
    public void setTPWMDPayResult(STWMDPay value) {
        this.tpwmdPayResult = value;
    }

}
