/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcHeatExchangerType : IfcEnergyConversionDeviceType 
	{
		public IfcHeatExchangerType(IfcHeatExchangerTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				String elementType,
				IfcTypeProductRepresentationMaps representationMaps,
				String tag,
				IfcTypeObjectHasPropertySets hasPropertySets,
				String applicableOccurrence,
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
				String[] pos) : base(elementType,
				representationMaps,
				tag,
				hasPropertySets,
				applicableOccurrence,
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
			this.predefinedTypeField = predefinedType;
			this.predefinedTypeSpecifiedField = predefinedTypeSpecified;
		}
	}
}