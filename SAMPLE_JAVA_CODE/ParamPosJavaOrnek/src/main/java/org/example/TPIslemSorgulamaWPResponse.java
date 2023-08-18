
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
 *         &lt;element name="TP_Islem_Sorgulama_WPResult" type="{https://turkpos.com.tr/}ST_Islem_Sorgulama_WP"/&gt;
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
    "tpIslemSorgulamaWPResult"
})
@XmlRootElement(name = "TP_Islem_Sorgulama_WPResponse")
public class TPIslemSorgulamaWPResponse {

    @XmlElement(name = "TP_Islem_Sorgulama_WPResult", required = true)
    protected STIslemSorgulamaWP tpIslemSorgulamaWPResult;

    /**
     * Gets the value of the tpIslemSorgulamaWPResult property.
     * 
     * @return
     *     possible object is
     *     {@link STIslemSorgulamaWP }
     *     
     */
    public STIslemSorgulamaWP getTPIslemSorgulamaWPResult() {
        return tpIslemSorgulamaWPResult;
    }

    /**
     * Sets the value of the tpIslemSorgulamaWPResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STIslemSorgulamaWP }
     *     
     */
    public void setTPIslemSorgulamaWPResult(STIslemSorgulamaWP value) {
        this.tpIslemSorgulamaWPResult = value;
    }

}
