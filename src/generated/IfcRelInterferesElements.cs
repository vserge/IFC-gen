/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRelInterferesElements : IfcRelConnects 
	{
		public IfcRelInterferesElements(IfcElement relatingElement,
				IfcElement relatedElement,
				IfcConnectionGeometry interferenceGeometry,
				String interferenceType,
				IfcLogical impliedOrder,
				Boolean impliedOrderSpecified,
				IfcOwnerHistory ownerHistory,
				String globalId,
				String name,
				String description,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(ownerHistory,
				globalId,
				name,
				description,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.relatingElementField = relatingElement;
			this.relatedElementField = relatedElement;
			this.interferenceGeometryField = interferenceGeometry;
			this.interferenceTypeField = interferenceType;
			this.impliedOrderField = impliedOrder;
			this.impliedOrderSpecifiedField = impliedOrderSpecified;
		}
	}
}