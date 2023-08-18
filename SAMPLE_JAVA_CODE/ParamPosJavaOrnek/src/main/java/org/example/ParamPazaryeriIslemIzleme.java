
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
 *         &lt;element name="G" type="{https://turkpos.com.tr/}ST_WS_Guvenlik"/&gt;
 *         &lt;element name="islemIzlemeReq" type="{https://turkpos.com.tr/}IslemIzlemeReq" minOccurs="0"/&gt;
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
    "g",
    "islemIzlemeReq"
})
@XmlRootElement(name = "Param_Pazaryeri_Islem_Izleme")
public class ParamPazaryeriIslemIzleme {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    protected IslemIzlemeReq islemIzlemeReq;

    /**
     * Gets the value of the g property.
     * 
     * @return
     *     possible object is
     *     {@link STWSGuvenlik }
     *     
     */
    public STWSGuvenlik getG() {
        return g;
    }

    /**
     * Sets the value of the g property.
     * 
     * @param value
     *     allowed object is
     *     {@link STWSGuvenlik }
     *     
     */
    public void setG(STWSGuvenlik value) {
        this.g = value;
    }

    /**
     * Gets the value of the islemIzlemeReq property.
     * 
     * @return
     *     possible object is
     *     {@link IslemIzlemeReq }
     *     
     */
    public IslemIzlemeReq getIslemIzlemeReq() {
        return islemIzlemeReq;
    }

    /**
     * Sets the value of the islemIzlemeReq property.
     * 
     * @param value
     *     allowed object is
     *     {@link IslemIzlemeReq }
     *     
     */
    public void setIslemIzlemeReq(IslemIzlemeReq value) {
        this.islemIzlemeReq = value;
    }

}
