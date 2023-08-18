
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
 *         &lt;element name="TP_WMD_UCD_v2Result" type="{https://turkpos.com.tr/}ST_WMD_UCD_v2"/&gt;
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
    "tpwmducdv2Result"
})
@XmlRootElement(name = "TP_WMD_UCD_v2Response")
public class TPWMDUCDV2Response {

    @XmlElement(name = "TP_WMD_UCD_v2Result", required = true)
    protected STWMDUCDV2 tpwmducdv2Result;

    /**
     * Gets the value of the tpwmducdv2Result property.
     * 
     * @return
     *     possible object is
     *     {@link STWMDUCDV2 }
     *     
     */
    public STWMDUCDV2 getTPWMDUCDV2Result() {
        return tpwmducdv2Result;
    }

    /**
     * Sets the value of the tpwmducdv2Result property.
     * 
     * @param value
     *     allowed object is
     *     {@link STWMDUCDV2 }
     *     
     */
    public void setTPWMDUCDV2Result(STWMDUCDV2 value) {
        this.tpwmducdv2Result = value;
    }

}
