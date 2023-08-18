
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
 *         &lt;element name="Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2Result" type="{https://turkpos.com.tr/}Sonuc_Uyelik"/&gt;
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
    "pazaryeriTPAltUyeIsyeriEklemeV2Result"
})
@XmlRootElement(name = "Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2Response")
public class PazaryeriTPAltUyeIsyeriEklemeV2Response {

    @XmlElement(name = "Pazaryeri_TP_AltUyeIsyeri_Ekleme_v2Result", required = true)
    protected SonucUyelik pazaryeriTPAltUyeIsyeriEklemeV2Result;

    /**
     * Gets the value of the pazaryeriTPAltUyeIsyeriEklemeV2Result property.
     * 
     * @return
     *     possible object is
     *     {@link SonucUyelik }
     *     
     */
    public SonucUyelik getPazaryeriTPAltUyeIsyeriEklemeV2Result() {
        return pazaryeriTPAltUyeIsyeriEklemeV2Result;
    }

    /**
     * Sets the value of the pazaryeriTPAltUyeIsyeriEklemeV2Result property.
     * 
     * @param value
     *     allowed object is
     *     {@link SonucUyelik }
     *     
     */
    public void setPazaryeriTPAltUyeIsyeriEklemeV2Result(SonucUyelik value) {
        this.pazaryeriTPAltUyeIsyeriEklemeV2Result = value;
    }

}
