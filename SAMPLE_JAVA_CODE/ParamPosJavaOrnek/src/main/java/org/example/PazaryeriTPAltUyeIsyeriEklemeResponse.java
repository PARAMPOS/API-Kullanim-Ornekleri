
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
 *         &lt;element name="Pazaryeri_TP_AltUyeIsyeri_EklemeResult" type="{https://turkpos.com.tr/}Sonuc_Uyelik"/&gt;
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
    "pazaryeriTPAltUyeIsyeriEklemeResult"
})
@XmlRootElement(name = "Pazaryeri_TP_AltUyeIsyeri_EklemeResponse")
public class PazaryeriTPAltUyeIsyeriEklemeResponse {

    @XmlElement(name = "Pazaryeri_TP_AltUyeIsyeri_EklemeResult", required = true)
    protected SonucUyelik pazaryeriTPAltUyeIsyeriEklemeResult;

    /**
     * Gets the value of the pazaryeriTPAltUyeIsyeriEklemeResult property.
     * 
     * @return
     *     possible object is
     *     {@link SonucUyelik }
     *     
     */
    public SonucUyelik getPazaryeriTPAltUyeIsyeriEklemeResult() {
        return pazaryeriTPAltUyeIsyeriEklemeResult;
    }

    /**
     * Sets the value of the pazaryeriTPAltUyeIsyeriEklemeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link SonucUyelik }
     *     
     */
    public void setPazaryeriTPAltUyeIsyeriEklemeResult(SonucUyelik value) {
        this.pazaryeriTPAltUyeIsyeriEklemeResult = value;
    }

}
