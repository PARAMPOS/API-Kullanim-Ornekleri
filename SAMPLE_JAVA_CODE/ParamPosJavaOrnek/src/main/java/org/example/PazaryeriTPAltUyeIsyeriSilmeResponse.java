
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
 *         &lt;element name="Pazaryeri_TP_AltUyeIsyeri_SilmeResult" type="{http://www.w3.org/2001/XMLSchema}anyType" minOccurs="0"/&gt;
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
    "pazaryeriTPAltUyeIsyeriSilmeResult"
})
@XmlRootElement(name = "Pazaryeri_TP_AltUyeIsyeri_SilmeResponse")
public class PazaryeriTPAltUyeIsyeriSilmeResponse {

    @XmlElement(name = "Pazaryeri_TP_AltUyeIsyeri_SilmeResult")
    protected Object pazaryeriTPAltUyeIsyeriSilmeResult;

    /**
     * Gets the value of the pazaryeriTPAltUyeIsyeriSilmeResult property.
     * 
     * @return
     *     possible object is
     *     {@link Object }
     *     
     */
    public Object getPazaryeriTPAltUyeIsyeriSilmeResult() {
        return pazaryeriTPAltUyeIsyeriSilmeResult;
    }

    /**
     * Sets the value of the pazaryeriTPAltUyeIsyeriSilmeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link Object }
     *     
     */
    public void setPazaryeriTPAltUyeIsyeriSilmeResult(Object value) {
        this.pazaryeriTPAltUyeIsyeriSilmeResult = value;
    }

}
