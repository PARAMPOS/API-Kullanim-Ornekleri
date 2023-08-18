
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
 *         &lt;element name="Pazaryeri_TP_Siparis_Detay_EkleResult" type="{https://turkpos.com.tr/}SE_Sonuc"/&gt;
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
    "pazaryeriTPSiparisDetayEkleResult"
})
@XmlRootElement(name = "Pazaryeri_TP_Siparis_Detay_EkleResponse")
public class PazaryeriTPSiparisDetayEkleResponse {

    @XmlElement(name = "Pazaryeri_TP_Siparis_Detay_EkleResult", required = true)
    protected SESonuc pazaryeriTPSiparisDetayEkleResult;

    /**
     * Gets the value of the pazaryeriTPSiparisDetayEkleResult property.
     * 
     * @return
     *     possible object is
     *     {@link SESonuc }
     *     
     */
    public SESonuc getPazaryeriTPSiparisDetayEkleResult() {
        return pazaryeriTPSiparisDetayEkleResult;
    }

    /**
     * Sets the value of the pazaryeriTPSiparisDetayEkleResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link SESonuc }
     *     
     */
    public void setPazaryeriTPSiparisDetayEkleResult(SESonuc value) {
        this.pazaryeriTPSiparisDetayEkleResult = value;
    }

}
