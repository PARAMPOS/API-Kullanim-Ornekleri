
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
 *         &lt;element name="Kart_No" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="KS_KK_Kisi_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
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
    "kartNo",
    "kskkKisiID"
})
@XmlRootElement(name = "KK_Sakli_Liste")
public class KKSakliListe {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "Kart_No")
    protected String kartNo;
    @XmlElement(name = "KS_KK_Kisi_ID")
    protected String kskkKisiID;

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
     * Gets the value of the kartNo property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKartNo() {
        return kartNo;
    }

    /**
     * Sets the value of the kartNo property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKartNo(String value) {
        this.kartNo = value;
    }

    /**
     * Gets the value of the kskkKisiID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getKSKKKisiID() {
        return kskkKisiID;
    }

    /**
     * Sets the value of the kskkKisiID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setKSKKKisiID(String value) {
        this.kskkKisiID = value;
    }

}
