
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
 *         &lt;element name="TP_Islem_Odeme_OnProv_WKSResult" type="{https://turkpos.com.tr/}ST_TP_Islem_Odeme_OnProv"/&gt;
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
    "tpIslemOdemeOnProvWKSResult"
})
@XmlRootElement(name = "TP_Islem_Odeme_OnProv_WKSResponse")
public class TPIslemOdemeOnProvWKSResponse {

    @XmlElement(name = "TP_Islem_Odeme_OnProv_WKSResult", required = true)
    protected STTPIslemOdemeOnProv tpIslemOdemeOnProvWKSResult;

    /**
     * Gets the value of the tpIslemOdemeOnProvWKSResult property.
     * 
     * @return
     *     possible object is
     *     {@link STTPIslemOdemeOnProv }
     *     
     */
    public STTPIslemOdemeOnProv getTPIslemOdemeOnProvWKSResult() {
        return tpIslemOdemeOnProvWKSResult;
    }

    /**
     * Sets the value of the tpIslemOdemeOnProvWKSResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STTPIslemOdemeOnProv }
     *     
     */
    public void setTPIslemOdemeOnProvWKSResult(STTPIslemOdemeOnProv value) {
        this.tpIslemOdemeOnProvWKSResult = value;
    }

}
