
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
 *         &lt;element name="TP_Islem_Iptal_Iade_Kismi4Result" type="{https://turkpos.com.tr/}ST_Sonuc4"/&gt;
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
    "tpIslemIptalIadeKismi4Result"
})
@XmlRootElement(name = "TP_Islem_Iptal_Iade_Kismi4Response")
public class TPIslemIptalIadeKismi4Response {

    @XmlElement(name = "TP_Islem_Iptal_Iade_Kismi4Result", required = true)
    protected STSonuc4 tpIslemIptalIadeKismi4Result;

    /**
     * Gets the value of the tpIslemIptalIadeKismi4Result property.
     * 
     * @return
     *     possible object is
     *     {@link STSonuc4 }
     *     
     */
    public STSonuc4 getTPIslemIptalIadeKismi4Result() {
        return tpIslemIptalIadeKismi4Result;
    }

    /**
     * Sets the value of the tpIslemIptalIadeKismi4Result property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonuc4 }
     *     
     */
    public void setTPIslemIptalIadeKismi4Result(STSonuc4 value) {
        this.tpIslemIptalIadeKismi4Result = value;
    }

}
