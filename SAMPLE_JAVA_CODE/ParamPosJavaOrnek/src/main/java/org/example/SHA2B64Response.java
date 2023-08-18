
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
 *         &lt;element name="SHA2B64Result" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "sha2B64Result"
})
@XmlRootElement(name = "SHA2B64Response")
public class SHA2B64Response {

    @XmlElement(name = "SHA2B64Result")
    protected String sha2B64Result;

    /**
     * Gets the value of the sha2B64Result property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getSHA2B64Result() {
        return sha2B64Result;
    }

    /**
     * Sets the value of the sha2B64Result property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setSHA2B64Result(String value) {
        this.sha2B64Result = value;
    }

}
