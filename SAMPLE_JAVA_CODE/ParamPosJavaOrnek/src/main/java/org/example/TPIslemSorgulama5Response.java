
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
 *         &lt;element name="TP_Islem_Sorgulama5Result" type="{https://turkpos.com.tr/}ST_Genel_Sonuc3"/&gt;
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
    "tpIslemSorgulama5Result"
})
@XmlRootElement(name = "TP_Islem_Sorgulama5Response")
public class TPIslemSorgulama5Response {

    @XmlElement(name = "TP_Islem_Sorgulama5Result", required = true)
    protected STGenelSonuc3 tpIslemSorgulama5Result;

    /**
     * Gets the value of the tpIslemSorgulama5Result property.
     * 
     * @return
     *     possible object is
     *     {@link STGenelSonuc3 }
     *     
     */
    public STGenelSonuc3 getTPIslemSorgulama5Result() {
        return tpIslemSorgulama5Result;
    }

    /**
     * Sets the value of the tpIslemSorgulama5Result property.
     * 
     * @param value
     *     allowed object is
     *     {@link STGenelSonuc3 }
     *     
     */
    public void setTPIslemSorgulama5Result(STGenelSonuc3 value) {
        this.tpIslemSorgulama5Result = value;
    }

}
