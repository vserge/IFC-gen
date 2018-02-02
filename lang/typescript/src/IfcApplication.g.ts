
import {BaseIfc} from "./BaseIfc"
import {IfcOrganization} from "./IfcOrganization.g"
import {IfcLabel} from "./IfcLabel.g"
import {IfcIdentifier} from "./IfcIdentifier.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcapplication.htm
 */
export class IfcApplication extends BaseIfc {
	ApplicationDeveloper : IfcOrganization
	Version : IfcLabel
	ApplicationFullName : IfcLabel
	ApplicationIdentifier : IfcIdentifier

    constructor(applicationDeveloper : IfcOrganization, version : IfcLabel, applicationFullName : IfcLabel, applicationIdentifier : IfcIdentifier) {
        super()

		this.ApplicationDeveloper = applicationDeveloper
		this.Version = version
		this.ApplicationFullName = applicationFullName
		this.ApplicationIdentifier = applicationIdentifier

    }
    getStepParameters() : string {
        var parameters = new Array<string>();
		parameters.push(this.ApplicationDeveloper != null ? BaseIfc.toStepValue(this.ApplicationDeveloper) : "$");
		parameters.push(this.Version != null ? BaseIfc.toStepValue(this.Version) : "$");
		parameters.push(this.ApplicationFullName != null ? BaseIfc.toStepValue(this.ApplicationFullName) : "$");
		parameters.push(this.ApplicationIdentifier != null ? BaseIfc.toStepValue(this.ApplicationIdentifier) : "$");

        return parameters.join();
    }
}