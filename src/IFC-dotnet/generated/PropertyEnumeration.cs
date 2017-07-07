/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertyenumeration.htm
	/// </summary>
	internal  partial class PropertyEnumeration : PropertyAbstraction 
	{
		public PropertyEnumerationEnumerationValues EnumerationValues {get;set;}

		public PropertyEnumerationUnit Unit {get;set;}

		public String Name {get;set;}

		public PropertyEnumeration(PropertyEnumerationEnumerationValues enumerationValues,
				PropertyEnumerationUnit unit,
				String name) : base()
		{
			this.EnumerationValues = enumerationValues;
			this.Unit = unit;
			this.Name = name;
		}
	}
}