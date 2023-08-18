
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
 *         &lt;element name="TP_WMD_UCD_WPResult" type="{https://turkpos.com.tr/}ST_WMD_UCD"/&gt;
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
    "tpwmducdwpResult"
})
@XmlRootElement(name = "TP_WMD_UCD_WPResponse")
public class TPWMDUCDWPResponse {

    @XmlElement(name = "TP_WMD_UCD_WPResult", required = true)
    protected STWMDUCD tpwmducdwpResult;

    /**
     * Gets the value of the tpwmducdwpResult property.
     * 
     * @return
     *     possible object is
     *     {@link STWMDUCD }
     *     
     */
    public STWMDUCD getTPWMDUCDWPResult() {
        return tpwmducdwpResult;
    }

    /**
     * Sets the value of the tpwmducdwpResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STWMDUCD }
     *     
     */
    public void setTPWMDUCDWPResult(STWMDUCD value) {
        this.tpwmducdwpResult = value;
    }

}
