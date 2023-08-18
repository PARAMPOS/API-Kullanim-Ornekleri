
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
 *         &lt;element name="TP_Islem_Sorgulama4Result" type="{https://turkpos.com.tr/}ST_Genel_Sonuc2"/&gt;
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
    "tpIslemSorgulama4Result"
})
@XmlRootElement(name = "TP_Islem_Sorgulama4Response")
public class TPIslemSorgulama4Response {

    @XmlElement(name = "TP_Islem_Sorgulama4Result", required = true)
    protected STGenelSonuc2 tpIslemSorgulama4Result;

    /**
     * Gets the value of the tpIslemSorgulama4Result property.
     * 
     * @return
     *     possible object is
     *     {@link STGenelSonuc2 }
     *     
     */
    public STGenelSonuc2 getTPIslemSorgulama4Result() {
        return tpIslemSorgulama4Result;
    }

    /**
     * Sets the value of the tpIslemSorgulama4Result property.
     * 
     * @param value
     *     allowed object is
     *     {@link STGenelSonuc2 }
     *     
     */
    public void setTPIslemSorgulama4Result(STGenelSonuc2 value) {
        this.tpIslemSorgulama4Result = value;
    }

}
