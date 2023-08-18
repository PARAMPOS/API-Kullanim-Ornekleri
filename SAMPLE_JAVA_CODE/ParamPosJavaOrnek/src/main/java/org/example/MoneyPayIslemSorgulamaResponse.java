
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
 *         &lt;element name="MoneyPay_Islem_SorgulamaResult" type="{https://turkpos.com.tr/}ST_Genel_Sonuc"/&gt;
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
    "moneyPayIslemSorgulamaResult"
})
@XmlRootElement(name = "MoneyPay_Islem_SorgulamaResponse")
public class MoneyPayIslemSorgulamaResponse {

    @XmlElement(name = "MoneyPay_Islem_SorgulamaResult", required = true)
    protected STGenelSonuc moneyPayIslemSorgulamaResult;

    /**
     * Gets the value of the moneyPayIslemSorgulamaResult property.
     * 
     * @return
     *     possible object is
     *     {@link STGenelSonuc }
     *     
     */
    public STGenelSonuc getMoneyPayIslemSorgulamaResult() {
        return moneyPayIslemSorgulamaResult;
    }

    /**
     * Sets the value of the moneyPayIslemSorgulamaResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link STGenelSonuc }
     *     
     */
    public void setMoneyPayIslemSorgulamaResult(STGenelSonuc value) {
        this.moneyPayIslemSorgulamaResult = value;
    }

}
