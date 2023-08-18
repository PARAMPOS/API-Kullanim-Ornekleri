
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
 *         &lt;element name="TP_Ozel_Oran_ListeResult" type="{https://turkpos.com.tr/}ST_Genel_Sonuc"/&gt;
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
    "tpOzelOranListeResult"
})
@XmlRootElement(name = "TP_Ozel_Oran_ListeResponse")
public class TPOzelOranListeResponse {

    @XmlElement(name = "TP_Ozel_Oran_ListeResult", required = true)
    protected STGenelSonuc tpOzelOranListeResult;

    /**
     * Gets the value of the tpOzelOranListeResult property.
     * 
     * @return
     *     possible object is
     *     {@link STGenelSonuc }
     *     
     */
    public STGenelSonuc getTPOzelOranListeResult() {
        return tpOzelOranListeResult;
    }

    /**
     * Sets the value of the tpOzelOranListeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STGenelSonuc }
     *     
     */
    public void setTPOzelOranListeResult(STGenelSonuc value) {
        this.tpOzelOranListeResult = value;
    }

}
