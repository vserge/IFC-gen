/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcStructuralSurfaceMember : IfcStructuralMember 
	{
		public IfcStructuralSurfaceMember(IfcStructuralSurfaceMemberTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				Double thickness,
				Boolean thicknessSpecified,
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
				String[] pos) : base(objectPlacement,
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
			this.predefinedTypeField = predefinedType;
			this.predefinedTypeSpecifiedField = predefinedTypeSpecified;
			this.thicknessField = thickness;
			this.thicknessSpecifiedField = thicknessSpecified;
		}
	}
}