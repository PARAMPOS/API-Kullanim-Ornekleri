
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
 *         &lt;element name="TP_Islem_Iptal_Iade_Kismi2Result" type="{https://turkpos.com.tr/}ST_Sonuc_II"/&gt;
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
    "tpIslemIptalIadeKismi2Result"
})
@XmlRootElement(name = "TP_Islem_Iptal_Iade_Kismi2Response")
public class TPIslemIptalIadeKismi2Response {

    @XmlElement(name = "TP_Islem_Iptal_Iade_Kismi2Result", required = true)
    protected STSonucII tpIslemIptalIadeKismi2Result;

    /**
     * Gets the value of the tpIslemIptalIadeKismi2Result property.
     * 
     * @return
     *     possible object is
     *     {@link STSonucII }
     *     
     */
    public STSonucII getTPIslemIptalIadeKismi2Result() {
        return tpIslemIptalIadeKismi2Result;
    }

    /**
     * Sets the value of the tpIslemIptalIadeKismi2Result property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonucII }
     *     
     */
    public void setTPIslemIptalIadeKismi2Result(STSonucII value) {
        this.tpIslemIptalIadeKismi2Result = value;
    }

}
