/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcClassification : IfcExternalInformation 
	{
		public IfcClassification(IfcClassificationReferenceTokens referenceTokens,
				IfcClassificationHasReferences hasReferences,
				String source,
				String edition,
				String editionDate,
				String name,
				String description,
				String location,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(href,
				reference,
				id,
				path,
				pos)
		{
			this.referenceTokensField = referenceTokens;
			this.hasReferencesField = hasReferences;
			this.sourceField = source;
			this.editionField = edition;
			this.editionDateField = editionDate;
			this.nameField = name;
			this.descriptionField = description;
			this.locationField = location;
		}
	}
}