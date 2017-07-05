/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralLoadCase : IfcStructuralLoadGroup 
	{
		public IfcStructuralLoadCase(Double[] selfWeightCoefficients,
				IfcLoadGroupTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				IfcActionTypeEnum actionType,
				Boolean actionTypeSpecified,
				IfcActionSourceTypeEnum actionSource,
				Boolean actionSourceSpecified,
				Double coefficient,
				Boolean coefficientSpecified,
				String purpose,
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
				String[] pos) : base(predefinedType,
				predefinedTypeSpecified,
				actionType,
				actionTypeSpecified,
				actionSource,
				actionSourceSpecified,
				coefficient,
				coefficientSpecified,
				purpose,
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
			this.selfWeightCoefficientsField = selfWeightCoefficients;
		}
	}
}