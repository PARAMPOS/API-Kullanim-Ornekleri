
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
 *         &lt;element name="Pos_OdemeResult" type="{https://turkpos.com.tr/}ST_TP_Islem_Odeme"/&gt;
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
    "posOdemeResult"
})
@XmlRootElement(name = "Pos_OdemeResponse")
public class PosOdemeResponse {

    @XmlElement(name = "Pos_OdemeResult", required = true)
    protected STTPIslemOdeme posOdemeResult;

    /**
     * Gets the value of the posOdemeResult property.
     * 
     * @return
     *     possible object is
     *     {@link STTPIslemOdeme }
     *     
     */
    public STTPIslemOdeme getPosOdemeResult() {
        return posOdemeResult;
    }

    /**
     * Sets the value of the posOdemeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STTPIslemOdeme }
     *     
     */
    public void setPosOdemeResult(STTPIslemOdeme value) {
        this.posOdemeResult = value;
    }

}
