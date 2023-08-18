
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
 *         &lt;element name="TP_Islem_Sorgulama6Result" type="{https://turkpos.com.tr/}ST_WMD_UCD"/&gt;
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
    "tpIslemSorgulama6Result"
})
@XmlRootElement(name = "TP_Islem_Sorgulama6Response")
public class TPIslemSorgulama6Response {

    @XmlElement(name = "TP_Islem_Sorgulama6Result", required = true)
    protected STWMDUCD tpIslemSorgulama6Result;

    /**
     * Gets the value of the tpIslemSorgulama6Result property.
     * 
     * @return
     *     possible object is
     *     {@link STWMDUCD }
     *     
     */
    public STWMDUCD getTPIslemSorgulama6Result() {
        return tpIslemSorgulama6Result;
    }

    /**
     * Sets the value of the tpIslemSorgulama6Result property.
     * 
     * @param value
     *     allowed object is
     *     {@link STWMDUCD }
     *     
     */
    public void setTPIslemSorgulama6Result(STWMDUCD value) {
        this.tpIslemSorgulama6Result = value;
    }

}
