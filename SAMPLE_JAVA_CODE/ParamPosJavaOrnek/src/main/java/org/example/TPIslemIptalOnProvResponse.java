
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
 *         &lt;element name="TP_Islem_Iptal_OnProvResult" type="{https://turkpos.com.tr/}ST_Sonuc"/&gt;
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
    "tpIslemIptalOnProvResult"
})
@XmlRootElement(name = "TP_Islem_Iptal_OnProvResponse")
public class TPIslemIptalOnProvResponse {

    @XmlElement(name = "TP_Islem_Iptal_OnProvResult", required = true)
    protected STSonuc tpIslemIptalOnProvResult;

    /**
     * Gets the value of the tpIslemIptalOnProvResult property.
     * 
     * @return
     *     possible object is
     *     {@link STSonuc }
     *     
     */
    public STSonuc getTPIslemIptalOnProvResult() {
        return tpIslemIptalOnProvResult;
    }

    /**
     * Sets the value of the tpIslemIptalOnProvResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonuc }
     *     
     */
    public void setTPIslemIptalOnProvResult(STSonuc value) {
        this.tpIslemIptalOnProvResult = value;
    }

}
