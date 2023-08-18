
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
 *         &lt;element name="TP_Islem_Checkout_Odeme_WNSResult" type="{https://turkpos.com.tr/}ST_TP_Islem_Odeme"/&gt;
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
    "tpIslemCheckoutOdemeWNSResult"
})
@XmlRootElement(name = "TP_Islem_Checkout_Odeme_WNSResponse")
public class TPIslemCheckoutOdemeWNSResponse {

    @XmlElement(name = "TP_Islem_Checkout_Odeme_WNSResult", required = true)
    protected STTPIslemOdeme tpIslemCheckoutOdemeWNSResult;

    /**
     * Gets the value of the tpIslemCheckoutOdemeWNSResult property.
     * 
     * @return
     *     possible object is
     *     {@link STTPIslemOdeme }
     *     
     */
    public STTPIslemOdeme getTPIslemCheckoutOdemeWNSResult() {
        return tpIslemCheckoutOdemeWNSResult;
    }

    /**
     * Sets the value of the tpIslemCheckoutOdemeWNSResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STTPIslemOdeme }
     *     
     */
    public void setTPIslemCheckoutOdemeWNSResult(STTPIslemOdeme value) {
        this.tpIslemCheckoutOdemeWNSResult = value;
    }

}
