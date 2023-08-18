
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
 *         &lt;element name="TP_Islem_Odeme_OnProv_KapaResult" type="{https://turkpos.com.tr/}ST_TP_Islem_Odeme_OnProvKapa"/&gt;
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
    "tpIslemOdemeOnProvKapaResult"
})
@XmlRootElement(name = "TP_Islem_Odeme_OnProv_KapaResponse")
public class TPIslemOdemeOnProvKapaResponse {

    @XmlElement(name = "TP_Islem_Odeme_OnProv_KapaResult", required = true)
    protected STTPIslemOdemeOnProvKapa tpIslemOdemeOnProvKapaResult;

    /**
     * Gets the value of the tpIslemOdemeOnProvKapaResult property.
     * 
     * @return
     *     possible object is
     *     {@link STTPIslemOdemeOnProvKapa }
     *     
     */
    public STTPIslemOdemeOnProvKapa getTPIslemOdemeOnProvKapaResult() {
        return tpIslemOdemeOnProvKapaResult;
    }

    /**
     * Sets the value of the tpIslemOdemeOnProvKapaResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STTPIslemOdemeOnProvKapa }
     *     
     */
    public void setTPIslemOdemeOnProvKapaResult(STTPIslemOdemeOnProvKapa value) {
        this.tpIslemOdemeOnProvKapaResult = value;
    }

}
