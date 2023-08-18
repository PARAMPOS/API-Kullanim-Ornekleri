
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
 *         &lt;element name="Pazaryeri_TP_AltUyeIsyeri_ListeResult" type="{https://turkpos.com.tr/}Sonuc_Uyelik_Liste"/&gt;
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
    "pazaryeriTPAltUyeIsyeriListeResult"
})
@XmlRootElement(name = "Pazaryeri_TP_AltUyeIsyeri_ListeResponse")
public class PazaryeriTPAltUyeIsyeriListeResponse {

    @XmlElement(name = "Pazaryeri_TP_AltUyeIsyeri_ListeResult", required = true)
    protected SonucUyelikListe pazaryeriTPAltUyeIsyeriListeResult;

    /**
     * Gets the value of the pazaryeriTPAltUyeIsyeriListeResult property.
     * 
     * @return
     *     possible object is
     *     {@link SonucUyelikListe }
     *     
     */
    public SonucUyelikListe getPazaryeriTPAltUyeIsyeriListeResult() {
        return pazaryeriTPAltUyeIsyeriListeResult;
    }

    /**
     * Sets the value of the pazaryeriTPAltUyeIsyeriListeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link SonucUyelikListe }
     *     
     */
    public void setPazaryeriTPAltUyeIsyeriListeResult(SonucUyelikListe value) {
        this.pazaryeriTPAltUyeIsyeriListeResult = value;
    }

}
