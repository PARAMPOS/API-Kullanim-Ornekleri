
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
 *         &lt;element name="KK_Sakli_ListeResult" type="{https://turkpos.com.tr/}ST_Genel_Sonuc"/&gt;
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
    "kkSakliListeResult"
})
@XmlRootElement(name = "KK_Sakli_ListeResponse")
public class KKSakliListeResponse {

    @XmlElement(name = "KK_Sakli_ListeResult", required = true)
    protected STGenelSonuc kkSakliListeResult;

    /**
     * Gets the value of the kkSakliListeResult property.
     * 
     * @return
     *     possible object is
     *     {@link STGenelSonuc }
     *     
     */
    public STGenelSonuc getKKSakliListeResult() {
        return kkSakliListeResult;
    }

    /**
     * Sets the value of the kkSakliListeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STGenelSonuc }
     *     
     */
    public void setKKSakliListeResult(STGenelSonuc value) {
        this.kkSakliListeResult = value;
    }

}
