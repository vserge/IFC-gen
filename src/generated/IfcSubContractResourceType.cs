/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSubContractResourceType : IfcConstructionResourceType 
	{
		public IfcSubContractResourceType(IfcSubContractResourceTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				IfcConstructionResourceTypeBaseCosts baseCosts,
				IfcPhysicalQuantity baseQuantity,
				String identification,
				String longDescription,
				String resourceType,
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
				String[] pos) : base(baseCosts,
				baseQuantity,
				identification,
				longDescription,
				resourceType,
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