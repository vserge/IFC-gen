/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcPropertyEnumeration : IfcPropertyAbstraction 
	{
		public IfcPropertyEnumeration(IfcPropertyEnumerationEnumerationValues enumerationValues,
				IfcPropertyEnumerationUnit unit,
				String name,
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
			this.enumerationValuesField = enumerationValues;
			this.unitField = unit;
			this.nameField = name;
		}
	}
}