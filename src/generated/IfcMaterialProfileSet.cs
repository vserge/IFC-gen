/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcMaterialProfileSet : IfcMaterialDefinition 
	{
		public IfcMaterialProfileSet(IfcMaterialProfileSetMaterialProfiles materialProfiles,
				IfcCompositeProfileDef compositeProfile,
				String name,
				String description,
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
			this.materialProfilesField = materialProfiles;
			this.compositeProfileField = compositeProfile;
			this.nameField = name;
			this.descriptionField = description;
		}
	}
}