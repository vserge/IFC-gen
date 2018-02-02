
import {BaseIfc} from "./BaseIfc"
import {IfcLabel} from "./IfcLabel.g"
import {IfcText} from "./IfcText.g"
import {IfcExternalReferenceRelationship} from "./IfcExternalReferenceRelationship.g"
import {IfcPhysicalComplexQuantity} from "./IfcPhysicalComplexQuantity.g"
import {IfcNamedUnit} from "./IfcNamedUnit.g"
import {IfcVolumeMeasure} from "./IfcVolumeMeasure.g"
import {IfcPhysicalSimpleQuantity} from "./IfcPhysicalSimpleQuantity.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcquantityvolume.htm
 */
export class IfcQuantityVolume extends IfcPhysicalSimpleQuantity {
	VolumeValue : IfcVolumeMeasure
	Formula : IfcLabel // optional

    constructor(name : IfcLabel, volumeValue : IfcVolumeMeasure) {
        super(name)

		this.VolumeValue = volumeValue

    }
    getStepParameters() : string {
        var parameters = new Array<string>();
		parameters.push(this.Name != null ? BaseIfc.toStepValue(this.Name) : "$");
		parameters.push(this.Description != null ? BaseIfc.toStepValue(this.Description) : "$");
		parameters.push(this.Unit != null ? BaseIfc.toStepValue(this.Unit) : "$");
		parameters.push(this.VolumeValue != null ? BaseIfc.toStepValue(this.VolumeValue) : "$");
		parameters.push(this.Formula != null ? BaseIfc.toStepValue(this.Formula) : "$");

        return parameters.join();
    }
}