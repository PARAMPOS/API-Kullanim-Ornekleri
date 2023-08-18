
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
 *         &lt;element name="TP_Islem_Odeme_BKMResult" type="{https://turkpos.com.tr/}ST_TP_Islem_Odeme_BKM"/&gt;
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
    "tpIslemOdemeBKMResult"
})
@XmlRootElement(name = "TP_Islem_Odeme_BKMResponse")
public class TPIslemOdemeBKMResponse {

    @XmlElement(name = "TP_Islem_Odeme_BKMResult", required = true)
    protected STTPIslemOdemeBKM tpIslemOdemeBKMResult;

    /**
     * Gets the value of the tpIslemOdemeBKMResult property.
     * 
     * @return
     *     possible object is
     *     {@link STTPIslemOdemeBKM }
     *     
     */
    public STTPIslemOdemeBKM getTPIslemOdemeBKMResult() {
        return tpIslemOdemeBKMResult;
    }

    /**
     * Sets the value of the tpIslemOdemeBKMResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STTPIslemOdemeBKM }
     *     
     */
    public void setTPIslemOdemeBKMResult(STTPIslemOdemeBKM value) {
        this.tpIslemOdemeBKMResult = value;
    }

}
