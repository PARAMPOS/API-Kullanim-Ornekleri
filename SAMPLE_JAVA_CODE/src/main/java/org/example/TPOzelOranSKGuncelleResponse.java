
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
 *         &lt;element name="TP_Ozel_Oran_SK_GuncelleResult" type="{https://turkpos.com.tr/}ST_Sonuc"/&gt;
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
    "tpOzelOranSKGuncelleResult"
})
@XmlRootElement(name = "TP_Ozel_Oran_SK_GuncelleResponse")
public class TPOzelOranSKGuncelleResponse {

    @XmlElement(name = "TP_Ozel_Oran_SK_GuncelleResult", required = true)
    protected STSonuc tpOzelOranSKGuncelleResult;

    /**
     * Gets the value of the tpOzelOranSKGuncelleResult property.
     * 
     * @return
     *     possible object is
     *     {@link STSonuc }
     *     
     */
    public STSonuc getTPOzelOranSKGuncelleResult() {
        return tpOzelOranSKGuncelleResult;
    }

    /**
     * Sets the value of the tpOzelOranSKGuncelleResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonuc }
     *     
     */
    public void setTPOzelOranSKGuncelleResult(STSonuc value) {
        this.tpOzelOranSKGuncelleResult = value;
    }

}
