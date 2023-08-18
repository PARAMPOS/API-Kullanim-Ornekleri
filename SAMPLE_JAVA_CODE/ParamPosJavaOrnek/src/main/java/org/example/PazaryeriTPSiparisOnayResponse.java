
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
 *         &lt;element name="Pazaryeri_TP_Siparis_OnayResult" type="{https://turkpos.com.tr/}STC_Sonuc"/&gt;
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
    "pazaryeriTPSiparisOnayResult"
})
@XmlRootElement(name = "Pazaryeri_TP_Siparis_OnayResponse")
public class PazaryeriTPSiparisOnayResponse {

    @XmlElement(name = "Pazaryeri_TP_Siparis_OnayResult", required = true)
    protected STCSonuc pazaryeriTPSiparisOnayResult;

    /**
     * Gets the value of the pazaryeriTPSiparisOnayResult property.
     * 
     * @return
     *     possible object is
     *     {@link STCSonuc }
     *     
     */
    public STCSonuc getPazaryeriTPSiparisOnayResult() {
        return pazaryeriTPSiparisOnayResult;
    }

    /**
     * Sets the value of the pazaryeriTPSiparisOnayResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STCSonuc }
     *     
     */
    public void setPazaryeriTPSiparisOnayResult(STCSonuc value) {
        this.pazaryeriTPSiparisOnayResult = value;
    }

}
