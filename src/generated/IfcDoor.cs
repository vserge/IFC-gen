/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcDoor : IfcBuildingElement 
	{
		public IfcDoor(Double overallHeight,
				Boolean overallHeightSpecified,
				Double overallWidth,
				Boolean overallWidthSpecified,
				IfcDoorTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				IfcDoorTypeOperationEnum operationType,
				Boolean operationTypeSpecified,
				String userDefinedOperationType,
				IfcRelProjectsElement hasProjections,
				IfcRelVoidsElement hasOpenings,
				String tag,
				IfcObjectPlacement objectPlacement,
				IfcProductRepresentation representation,
				IfcRelDefinesByObject isDeclaredBy,
				IfcRelDefinesByType isTypedBy,
				IfcObjectIsDefinedBy isDefinedBy,
				String objectType,
				IfcObjectDefinitionIsNestedBy isNestedBy,
				IfcObjectDefinitionIsDecomposedBy isDecomposedBy,
				IfcOwnerHistory ownerHistory,
				String globalId,
				String name,
				String description,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(hasProjections,
				hasOpenings,
				tag,
				objectPlacement,
				representation,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy,
				ownerHistory,
				globalId,
				name,
				description,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.overallHeightField = overallHeight;
			this.overallHeightSpecifiedField = overallHeightSpecified;
			this.overallWidthField = overallWidth;
			this.overallWidthSpecifiedField = overallWidthSpecified;
			this.predefinedTypeField = predefinedType;
			this.predefinedTypeSpecifiedField = predefinedTypeSpecified;
			this.operationTypeField = operationType;
			this.operationTypeSpecifiedField = operationTypeSpecified;
			this.userDefinedOperationTypeField = userDefinedOperationType;
		}
	}
}