
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
 *         &lt;element name="Pazaryeri_TP_AltUyeIsyeri_GuncellemeResult" type="{https://turkpos.com.tr/}Sonuc_Uyelik"/&gt;
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
    "pazaryeriTPAltUyeIsyeriGuncellemeResult"
})
@XmlRootElement(name = "Pazaryeri_TP_AltUyeIsyeri_GuncellemeResponse")
public class PazaryeriTPAltUyeIsyeriGuncellemeResponse {

    @XmlElement(name = "Pazaryeri_TP_AltUyeIsyeri_GuncellemeResult", required = true)
    protected SonucUyelik pazaryeriTPAltUyeIsyeriGuncellemeResult;

    /**
     * Gets the value of the pazaryeriTPAltUyeIsyeriGuncellemeResult property.
     * 
     * @return
     *     possible object is
     *     {@link SonucUyelik }
     *     
     */
    public SonucUyelik getPazaryeriTPAltUyeIsyeriGuncellemeResult() {
        return pazaryeriTPAltUyeIsyeriGuncellemeResult;
    }

    /**
     * Sets the value of the pazaryeriTPAltUyeIsyeriGuncellemeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link SonucUyelik }
     *     
     */
    public void setPazaryeriTPAltUyeIsyeriGuncellemeResult(SonucUyelik value) {
        this.pazaryeriTPAltUyeIsyeriGuncellemeResult = value;
    }

}
