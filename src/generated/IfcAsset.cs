/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcAsset : IfcGroup 
	{
		public IfcAsset(IfcCostValue originalValue,
				IfcCostValue currentValue,
				IfcCostValue totalReplacementCost,
				IfcAssetOwner owner,
				IfcAssetUser user,
				IfcPerson responsiblePerson,
				IfcCostValue depreciatedValue,
				String identification,
				String incorporationDate,
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
				String[] pos) : base(isDeclaredBy,
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
			this.originalValueField = originalValue;
			this.currentValueField = currentValue;
			this.totalReplacementCostField = totalReplacementCost;
			this.ownerField = owner;
			this.userField = user;
			this.responsiblePersonField = responsiblePerson;
			this.depreciatedValueField = depreciatedValue;
			this.identificationField = identification;
			this.incorporationDateField = incorporationDate;
		}
	}
}