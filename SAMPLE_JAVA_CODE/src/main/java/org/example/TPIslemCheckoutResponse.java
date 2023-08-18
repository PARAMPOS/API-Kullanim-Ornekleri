
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
 *         &lt;element name="TP_Islem_CheckoutResult" type="{https://turkpos.com.tr/}ST_Sonuc"/&gt;
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
    "tpIslemCheckoutResult"
})
@XmlRootElement(name = "TP_Islem_CheckoutResponse")
public class TPIslemCheckoutResponse {

    @XmlElement(name = "TP_Islem_CheckoutResult", required = true)
    protected STSonuc tpIslemCheckoutResult;

    /**
     * Gets the value of the tpIslemCheckoutResult property.
     * 
     * @return
     *     possible object is
     *     {@link STSonuc }
     *     
     */
    public STSonuc getTPIslemCheckoutResult() {
        return tpIslemCheckoutResult;
    }

    /**
     * Sets the value of the tpIslemCheckoutResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonuc }
     *     
     */
    public void setTPIslemCheckoutResult(STSonuc value) {
        this.tpIslemCheckoutResult = value;
    }

}
