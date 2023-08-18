
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
 *         &lt;element name="TP_Islem_Odeme_OnProvResult" type="{https://turkpos.com.tr/}ST_TP_Islem_Odeme_OnProv"/&gt;
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
    "tpIslemOdemeOnProvResult"
})
@XmlRootElement(name = "TP_Islem_Odeme_OnProvResponse")
public class TPIslemOdemeOnProvResponse {

    @XmlElement(name = "TP_Islem_Odeme_OnProvResult", required = true)
    protected STTPIslemOdemeOnProv tpIslemOdemeOnProvResult;

    /**
     * Gets the value of the tpIslemOdemeOnProvResult property.
     * 
     * @return
     *     possible object is
     *     {@link STTPIslemOdemeOnProv }
     *     
     */
    public STTPIslemOdemeOnProv getTPIslemOdemeOnProvResult() {
        return tpIslemOdemeOnProvResult;
    }

    /**
     * Sets the value of the tpIslemOdemeOnProvResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STTPIslemOdemeOnProv }
     *     
     */
    public void setTPIslemOdemeOnProvResult(STTPIslemOdemeOnProv value) {
        this.tpIslemOdemeOnProvResult = value;
    }

}
