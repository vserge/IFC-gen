
import {BaseIfc} from "./BaseIfc"
import {IfcLabel} from "./IfcLabel.g"
import {IfcText} from "./IfcText.g"
import {IfcRepresentation} from "./IfcRepresentation.g"
import {IfcMaterial} from "./IfcMaterial.g"
import {IfcProductRepresentation} from "./IfcProductRepresentation.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialdefinitionrepresentation.htm
 */
export class IfcMaterialDefinitionRepresentation extends IfcProductRepresentation {
	RepresentedMaterial : IfcMaterial

    constructor(representations : Array<IfcRepresentation>, representedMaterial : IfcMaterial) {
        super(representations)

		this.RepresentedMaterial = representedMaterial

    }
    getStepParameters() : string {
        var parameters = new Array<string>();
		parameters.push(this.Name != null ? BaseIfc.toStepValue(this.Name) : "$");
		parameters.push(this.Description != null ? BaseIfc.toStepValue(this.Description) : "$");
		parameters.push(this.Representations != null ? BaseIfc.toStepValue(this.Representations) : "$");
		parameters.push(this.RepresentedMaterial != null ? BaseIfc.toStepValue(this.RepresentedMaterial) : "$");

        return parameters.join();
    }
}