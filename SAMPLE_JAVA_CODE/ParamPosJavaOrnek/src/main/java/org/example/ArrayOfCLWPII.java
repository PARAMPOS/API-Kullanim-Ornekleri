
package org.example;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ArrayOfCL_WP_II complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ArrayOfCL_WP_II"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="CL_WP_II" type="{https://turkpos.com.tr/}CL_WP_II" maxOccurs="unbounded" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ArrayOfCL_WP_II", propOrder = {
    "clwpii"
})
public class ArrayOfCLWPII {

    @XmlElement(name = "CL_WP_II", nillable = true)
    protected List<CLWPII> clwpii;

    /**
     * Gets the value of the clwpii property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the clwpii property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getCLWPII().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link CLWPII }
     * 
     * 
     */
    public List<CLWPII> getCLWPII() {
        if (clwpii == null) {
            clwpii = new ArrayList<CLWPII>();
        }
        return this.clwpii;
    }

}
