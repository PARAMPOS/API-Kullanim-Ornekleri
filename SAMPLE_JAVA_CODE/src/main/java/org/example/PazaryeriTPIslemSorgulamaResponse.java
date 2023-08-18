
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
 *         &lt;element name="Pazaryeri_TP_Islem_SorgulamaResult" type="{https://turkpos.com.tr/}ST_Genel_Sonuc"/&gt;
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
    "pazaryeriTPIslemSorgulamaResult"
})
@XmlRootElement(name = "Pazaryeri_TP_Islem_SorgulamaResponse")
public class PazaryeriTPIslemSorgulamaResponse {

    @XmlElement(name = "Pazaryeri_TP_Islem_SorgulamaResult", required = true)
    protected STGenelSonuc pazaryeriTPIslemSorgulamaResult;

    /**
     * Gets the value of the pazaryeriTPIslemSorgulamaResult property.
     * 
     * @return
     *     possible object is
     *     {@link STGenelSonuc }
     *     
     */
    public STGenelSonuc getPazaryeriTPIslemSorgulamaResult() {
        return pazaryeriTPIslemSorgulamaResult;
    }

    /**
     * Sets the value of the pazaryeriTPIslemSorgulamaResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STGenelSonuc }
     *     
     */
    public void setPazaryeriTPIslemSorgulamaResult(STGenelSonuc value) {
        this.pazaryeriTPIslemSorgulamaResult = value;
    }

}
