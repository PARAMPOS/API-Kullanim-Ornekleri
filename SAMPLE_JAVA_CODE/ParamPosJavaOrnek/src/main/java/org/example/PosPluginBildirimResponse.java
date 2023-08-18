
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
 *         &lt;element name="Pos_Plugin_BildirimResult" type="{https://turkpos.com.tr/}ST_Genel_Sonuc"/&gt;
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
    "posPluginBildirimResult"
})
@XmlRootElement(name = "Pos_Plugin_BildirimResponse")
public class PosPluginBildirimResponse {

    @XmlElement(name = "Pos_Plugin_BildirimResult", required = true)
    protected STGenelSonuc posPluginBildirimResult;

    /**
     * Gets the value of the posPluginBildirimResult property.
     * 
     * @return
     *     possible object is
     *     {@link STGenelSonuc }
     *     
     */
    public STGenelSonuc getPosPluginBildirimResult() {
        return posPluginBildirimResult;
    }

    /**
     * Sets the value of the posPluginBildirimResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STGenelSonuc }
     *     
     */
    public void setPosPluginBildirimResult(STGenelSonuc value) {
        this.posPluginBildirimResult = value;
    }

}
