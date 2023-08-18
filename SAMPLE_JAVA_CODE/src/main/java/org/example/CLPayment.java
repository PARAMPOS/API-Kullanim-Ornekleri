
package org.example;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for CL_Payment complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="CL_Payment"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="G" type="{https://turkpos.com.tr/}ST_WS_Guvenlik"/&gt;
 *         &lt;element name="GUID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Batch_ID" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="Webhook_URL" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="List_Info" type="{https://turkpos.com.tr/}ArrayOfList" minOccurs="0"/&gt;
 *         &lt;element name="File_Info" type="{https://turkpos.com.tr/}CL_File_Info" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "CL_Payment", propOrder = {
    "g",
    "guid",
    "batchID",
    "webhookURL",
    "listInfo",
    "fileInfo"
})
public class CLPayment {

    @XmlElement(name = "G", required = true)
    protected STWSGuvenlik g;
    @XmlElement(name = "GUID")
    protected String guid;
    @XmlElement(name = "Batch_ID")
    protected String batchID;
    @XmlElement(name = "Webhook_URL")
    protected String webhookURL;
    @XmlElement(name = "List_Info")
    protected ArrayOfList listInfo;
    @XmlElement(name = "File_Info")
    protected CLFileInfo fileInfo;

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
     * Gets the value of the guid property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getGUID() {
        return guid;
    }

    /**
     * Sets the value of the guid property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setGUID(String value) {
        this.guid = value;
    }

    /**
     * Gets the value of the batchID property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBatchID() {
        return batchID;
    }

    /**
     * Sets the value of the batchID property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBatchID(String value) {
        this.batchID = value;
    }

    /**
     * Gets the value of the webhookURL property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getWebhookURL() {
        return webhookURL;
    }

    /**
     * Sets the value of the webhookURL property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setWebhookURL(String value) {
        this.webhookURL = value;
    }

    /**
     * Gets the value of the listInfo property.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfList }
     *     
     */
    public ArrayOfList getListInfo() {
        return listInfo;
    }

    /**
     * Sets the value of the listInfo property.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfList }
     *     
     */
    public void setListInfo(ArrayOfList value) {
        this.listInfo = value;
    }

    /**
     * Gets the value of the fileInfo property.
     * 
     * @return
     *     possible object is
     *     {@link CLFileInfo }
     *     
     */
    public CLFileInfo getFileInfo() {
        return fileInfo;
    }

    /**
     * Sets the value of the fileInfo property.
     * 
     * @param value
     *     allowed object is
     *     {@link CLFileInfo }
     *     
     */
    public void setFileInfo(CLFileInfo value) {
        this.fileInfo = value;
    }

}
