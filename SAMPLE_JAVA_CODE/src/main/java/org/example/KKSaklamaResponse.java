
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
 *         &lt;element name="KK_SaklamaResult" type="{https://turkpos.com.tr/}ST_KK_Saklama"/&gt;
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
    "kkSaklamaResult"
})
@XmlRootElement(name = "KK_SaklamaResponse")
public class KKSaklamaResponse {

    @XmlElement(name = "KK_SaklamaResult", required = true)
    protected STKKSaklama kkSaklamaResult;

    /**
     * Gets the value of the kkSaklamaResult property.
     * 
     * @return
     *     possible object is
     *     {@link STKKSaklama }
     *     
     */
    public STKKSaklama getKKSaklamaResult() {
        return kkSaklamaResult;
    }

    /**
     * Sets the value of the kkSaklamaResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STKKSaklama }
     *     
     */
    public void setKKSaklamaResult(STKKSaklama value) {
        this.kkSaklamaResult = value;
    }

}
