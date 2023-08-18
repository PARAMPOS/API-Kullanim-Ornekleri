
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
 *         &lt;element name="Pazaryeri_TP_Iptal_IadeResult" type="{https://turkpos.com.tr/}STC_SonucII"/&gt;
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
    "pazaryeriTPIptalIadeResult"
})
@XmlRootElement(name = "Pazaryeri_TP_Iptal_IadeResponse")
public class PazaryeriTPIptalIadeResponse {

    @XmlElement(name = "Pazaryeri_TP_Iptal_IadeResult", required = true)
    protected STCSonucII pazaryeriTPIptalIadeResult;

    /**
     * Gets the value of the pazaryeriTPIptalIadeResult property.
     * 
     * @return
     *     possible object is
     *     {@link STCSonucII }
     *     
     */
    public STCSonucII getPazaryeriTPIptalIadeResult() {
        return pazaryeriTPIptalIadeResult;
    }

    /**
     * Sets the value of the pazaryeriTPIptalIadeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STCSonucII }
     *     
     */
    public void setPazaryeriTPIptalIadeResult(STCSonucII value) {
        this.pazaryeriTPIptalIadeResult = value;
    }

}
