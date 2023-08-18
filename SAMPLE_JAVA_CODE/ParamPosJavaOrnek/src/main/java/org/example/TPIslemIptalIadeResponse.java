
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
 *         &lt;element name="TP_Islem_Iptal_IadeResult" type="{https://turkpos.com.tr/}ST_Sonuc"/&gt;
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
    "tpIslemIptalIadeResult"
})
@XmlRootElement(name = "TP_Islem_Iptal_IadeResponse")
public class TPIslemIptalIadeResponse {

    @XmlElement(name = "TP_Islem_Iptal_IadeResult", required = true)
    protected STSonuc tpIslemIptalIadeResult;

    /**
     * Gets the value of the tpIslemIptalIadeResult property.
     * 
     * @return
     *     possible object is
     *     {@link STSonuc }
     *     
     */
    public STSonuc getTPIslemIptalIadeResult() {
        return tpIslemIptalIadeResult;
    }

    /**
     * Sets the value of the tpIslemIptalIadeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonuc }
     *     
     */
    public void setTPIslemIptalIadeResult(STSonuc value) {
        this.tpIslemIptalIadeResult = value;
    }

}
