
package org.example;

import java.util.ArrayList;
import java.util.List;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for ArrayOfCL_Res_MP_ODL_Data complex type.
 * 
 * <p>The following schema fragment specifies the expected         content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="ArrayOfCL_Res_MP_ODL_Data"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="CL_Res_MP_ODL_Data" type="{https://turkpos.com.tr/}CL_Res_MP_ODL_Data" maxOccurs="unbounded" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "ArrayOfCL_Res_MP_ODL_Data", propOrder = {
    "clResMPODLData"
})
public class ArrayOfCLResMPODLData {

    @XmlElement(name = "CL_Res_MP_ODL_Data", nillable = true)
    protected List<CLResMPODLData> clResMPODLData;

    /**
     * Gets the value of the clResMPODLData property.
     * 
     * <p>
     * This accessor method returns a reference to the live list,
     * not a snapshot. Therefore any modification you make to the
     * returned list will be present inside the JAXB object.
     * This is why there is not a <CODE>set</CODE> method for the clResMPODLData property.
     * 
     * <p>
     * For example, to add a new item, do as follows:
     * <pre>
     *    getCLResMPODLData().add(newItem);
     * </pre>
     * 
     * 
     * <p>
     * Objects of the following type(s) are allowed in the list
     * {@link CLResMPODLData }
     * 
     * 
     */
    public List<CLResMPODLData> getCLResMPODLData() {
        if (clResMPODLData == null) {
            clResMPODLData = new ArrayList<CLResMPODLData>();
        }
        return this.clResMPODLData;
    }

}
