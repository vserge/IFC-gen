/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcMaterialConstituent : IfcMaterialDefinition 
	{
		public IfcMaterialConstituent(IfcMaterial material,
				String name,
				String description,
				Double fraction,
				Boolean fractionSpecified,
				String category,
				IfcMaterialDefinitionHasProperties hasProperties,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(hasProperties,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.materialField = material;
			this.nameField = name;
			this.descriptionField = description;
			this.fractionField = fraction;
			this.fractionSpecifiedField = fractionSpecified;
			this.categoryField = category;
		}
	}
}