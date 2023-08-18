
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
 *         &lt;element name="TP_Islem_Iptal_Iade_Kismi_WPResult" type="{https://turkpos.com.tr/}ST_Sonuc_WP"/&gt;
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
    "tpIslemIptalIadeKismiWPResult"
})
@XmlRootElement(name = "TP_Islem_Iptal_Iade_Kismi_WPResponse")
public class TPIslemIptalIadeKismiWPResponse {

    @XmlElement(name = "TP_Islem_Iptal_Iade_Kismi_WPResult", required = true)
    protected STSonucWP tpIslemIptalIadeKismiWPResult;

    /**
     * Gets the value of the tpIslemIptalIadeKismiWPResult property.
     * 
     * @return
     *     possible object is
     *     {@link STSonucWP }
     *     
     */
    public STSonucWP getTPIslemIptalIadeKismiWPResult() {
        return tpIslemIptalIadeKismiWPResult;
    }

    /**
     * Sets the value of the tpIslemIptalIadeKismiWPResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonucWP }
     *     
     */
    public void setTPIslemIptalIadeKismiWPResult(STSonucWP value) {
        this.tpIslemIptalIadeKismiWPResult = value;
    }

}
