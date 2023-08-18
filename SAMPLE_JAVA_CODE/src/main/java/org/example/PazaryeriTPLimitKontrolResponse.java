
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
 *         &lt;element name="Pazaryeri_TP_Limit_KontrolResult" type="{https://turkpos.com.tr/}Sonuc_Limit2"/&gt;
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
    "pazaryeriTPLimitKontrolResult"
})
@XmlRootElement(name = "Pazaryeri_TP_Limit_KontrolResponse")
public class PazaryeriTPLimitKontrolResponse {

    @XmlElement(name = "Pazaryeri_TP_Limit_KontrolResult", required = true)
    protected SonucLimit2 pazaryeriTPLimitKontrolResult;

    /**
     * Gets the value of the pazaryeriTPLimitKontrolResult property.
     * 
     * @return
     *     possible object is
     *     {@link SonucLimit2 }
     *     
     */
    public SonucLimit2 getPazaryeriTPLimitKontrolResult() {
        return pazaryeriTPLimitKontrolResult;
    }

    /**
     * Sets the value of the pazaryeriTPLimitKontrolResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link SonucLimit2 }
     *     
     */
    public void setPazaryeriTPLimitKontrolResult(SonucLimit2 value) {
        this.pazaryeriTPLimitKontrolResult = value;
    }

}
