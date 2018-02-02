
import {BaseIfc} from "./BaseIfc"
import {IfcGloballyUniqueId} from "./IfcGloballyUniqueId.g"
import {IfcOwnerHistory} from "./IfcOwnerHistory.g"
import {IfcLabel} from "./IfcLabel.g"
import {IfcText} from "./IfcText.g"
import {IfcPort} from "./IfcPort.g"
import {IfcDistributionElement} from "./IfcDistributionElement.g"
import {IfcRelConnects} from "./IfcRelConnects.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelconnectsporttoelement.htm
 */
export class IfcRelConnectsPortToElement extends IfcRelConnects {
	RelatingPort : IfcPort
	RelatedElement : IfcDistributionElement

    constructor(globalId : IfcGloballyUniqueId, relatingPort : IfcPort, relatedElement : IfcDistributionElement) {
        super(globalId)

		this.RelatingPort = relatingPort
		this.RelatedElement = relatedElement

    }
    getStepParameters() : string {
        var parameters = new Array<string>();
		parameters.push(this.GlobalId != null ? BaseIfc.toStepValue(this.GlobalId) : "$");
		parameters.push(this.OwnerHistory != null ? BaseIfc.toStepValue(this.OwnerHistory) : "$");
		parameters.push(this.Name != null ? BaseIfc.toStepValue(this.Name) : "$");
		parameters.push(this.Description != null ? BaseIfc.toStepValue(this.Description) : "$");
		parameters.push(this.RelatingPort != null ? BaseIfc.toStepValue(this.RelatingPort) : "$");
		parameters.push(this.RelatedElement != null ? BaseIfc.toStepValue(this.RelatedElement) : "$");

        return parameters.join();
    }
}