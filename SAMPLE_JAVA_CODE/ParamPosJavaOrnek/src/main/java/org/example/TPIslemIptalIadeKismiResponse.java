
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
 *         &lt;element name="TP_Islem_Iptal_Iade_KismiResult" type="{https://turkpos.com.tr/}ST_Sonuc"/&gt;
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
    "tpIslemIptalIadeKismiResult"
})
@XmlRootElement(name = "TP_Islem_Iptal_Iade_KismiResponse")
public class TPIslemIptalIadeKismiResponse {

    @XmlElement(name = "TP_Islem_Iptal_Iade_KismiResult", required = true)
    protected STSonuc tpIslemIptalIadeKismiResult;

    /**
     * Gets the value of the tpIslemIptalIadeKismiResult property.
     * 
     * @return
     *     possible object is
     *     {@link STSonuc }
     *     
     */
    public STSonuc getTPIslemIptalIadeKismiResult() {
        return tpIslemIptalIadeKismiResult;
    }

    /**
     * Sets the value of the tpIslemIptalIadeKismiResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonuc }
     *     
     */
    public void setTPIslemIptalIadeKismiResult(STSonuc value) {
        this.tpIslemIptalIadeKismiResult = value;
    }

}
