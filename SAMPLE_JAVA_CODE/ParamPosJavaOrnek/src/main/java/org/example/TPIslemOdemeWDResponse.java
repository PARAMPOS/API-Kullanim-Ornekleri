
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
 *         &lt;element name="TP_Islem_Odeme_WDResult" type="{https://turkpos.com.tr/}ST_TP_Islem_Odeme"/&gt;
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
    "tpIslemOdemeWDResult"
})
@XmlRootElement(name = "TP_Islem_Odeme_WDResponse")
public class TPIslemOdemeWDResponse {

    @XmlElement(name = "TP_Islem_Odeme_WDResult", required = true)
    protected STTPIslemOdeme tpIslemOdemeWDResult;

    /**
     * Gets the value of the tpIslemOdemeWDResult property.
     * 
     * @return
     *     possible object is
     *     {@link STTPIslemOdeme }
     *     
     */
    public STTPIslemOdeme getTPIslemOdemeWDResult() {
        return tpIslemOdemeWDResult;
    }

    /**
     * Sets the value of the tpIslemOdemeWDResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STTPIslemOdeme }
     *     
     */
    public void setTPIslemOdemeWDResult(STTPIslemOdeme value) {
        this.tpIslemOdemeWDResult = value;
    }

}
