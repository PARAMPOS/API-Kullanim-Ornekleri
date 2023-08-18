
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
 *         &lt;element name="G" type="{https://turkpos.com.tr/}ST_WS_Guvenlik"/&gt;
 *         &lt;element name="GUID_AltUyeIsyeri" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "g",
    "guidAltUyeIsyeri"
})
@XmlRootElement(name = "Pazaryeri_TP_AltUyeIsyeri_Silme")
public class PazaryeriTPAltUyeIsyeriSilme {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "GUID_AltUyeIsyeri")
    protected String guidAltUyeIsyeri;

    /**
     * Gets the value of the g property.
     * 
     * @return
     *     possible object is
     *     {@link STWSGuvenlik }
     *     
     */
    public STWSGuvenlik getG() {
        return g;
    }

    /**
     * Sets the value of the g property.
     * 
     * @param value
     *     allowed object is
     *     {@link STWSGuvenlik }
     *     
     */
    public void setG(STWSGuvenlik value) {
        this.g = value;
    }

    /**
     * Gets the value of the guidAltUyeIsyeri property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getGUIDAltUyeIsyeri() {
        return guidAltUyeIsyeri;
    }

    /**
     * Sets the value of the guidAltUyeIsyeri property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setGUIDAltUyeIsyeri(String value) {
        this.guidAltUyeIsyeri = value;
    }

}
