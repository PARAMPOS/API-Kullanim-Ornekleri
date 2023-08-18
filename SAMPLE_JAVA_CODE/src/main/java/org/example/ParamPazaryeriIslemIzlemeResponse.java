
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
 *         &lt;element name="Param_Pazaryeri_Islem_IzlemeResult" type="{https://turkpos.com.tr/}IslemIzlemeRes" minOccurs="0"/&gt;
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
    "paramPazaryeriIslemIzlemeResult"
})
@XmlRootElement(name = "Param_Pazaryeri_Islem_IzlemeResponse")
public class ParamPazaryeriIslemIzlemeResponse {

    @XmlElement(name = "Param_Pazaryeri_Islem_IzlemeResult")
    protected IslemIzlemeRes paramPazaryeriIslemIzlemeResult;

    /**
     * Gets the value of the paramPazaryeriIslemIzlemeResult property.
     * 
     * @return
     *     possible object is
     *     {@link IslemIzlemeRes }
     *     
     */
    public IslemIzlemeRes getParamPazaryeriIslemIzlemeResult() {
        return paramPazaryeriIslemIzlemeResult;
    }

    /**
     * Sets the value of the paramPazaryeriIslemIzlemeResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link IslemIzlemeRes }
     *     
     */
    public void setParamPazaryeriIslemIzlemeResult(IslemIzlemeRes value) {
        this.paramPazaryeriIslemIzlemeResult = value;
    }

}
