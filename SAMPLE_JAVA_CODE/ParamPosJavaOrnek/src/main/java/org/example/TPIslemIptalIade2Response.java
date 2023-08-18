
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
 *         &lt;element name="TP_Islem_Iptal_Iade2Result" type="{https://turkpos.com.tr/}ST_Sonuc_II"/&gt;
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
    "tpIslemIptalIade2Result"
})
@XmlRootElement(name = "TP_Islem_Iptal_Iade2Response")
public class TPIslemIptalIade2Response {

    @XmlElement(name = "TP_Islem_Iptal_Iade2Result", required = true)
    protected STSonucII tpIslemIptalIade2Result;

    /**
     * Gets the value of the tpIslemIptalIade2Result property.
     * 
     * @return
     *     possible object is
     *     {@link STSonucII }
     *     
     */
    public STSonucII getTPIslemIptalIade2Result() {
        return tpIslemIptalIade2Result;
    }

    /**
     * Sets the value of the tpIslemIptalIade2Result property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonucII }
     *     
     */
    public void setTPIslemIptalIade2Result(STSonucII value) {
        this.tpIslemIptalIade2Result = value;
    }

}
