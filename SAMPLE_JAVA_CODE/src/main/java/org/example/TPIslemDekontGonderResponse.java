
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
 *         &lt;element name="TP_Islem_Dekont_GonderResult" type="{https://turkpos.com.tr/}ST_Sonuc"/&gt;
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
    "tpIslemDekontGonderResult"
})
@XmlRootElement(name = "TP_Islem_Dekont_GonderResponse")
public class TPIslemDekontGonderResponse {

    @XmlElement(name = "TP_Islem_Dekont_GonderResult", required = true)
    protected STSonuc tpIslemDekontGonderResult;

    /**
     * Gets the value of the tpIslemDekontGonderResult property.
     * 
     * @return
     *     possible object is
     *     {@link STSonuc }
     *     
     */
    public STSonuc getTPIslemDekontGonderResult() {
        return tpIslemDekontGonderResult;
    }

    /**
     * Sets the value of the tpIslemDekontGonderResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STSonuc }
     *     
     */
    public void setTPIslemDekontGonderResult(STSonuc value) {
        this.tpIslemDekontGonderResult = value;
    }

}
