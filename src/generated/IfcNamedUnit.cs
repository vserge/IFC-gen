/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcNamedUnit : Entity 
	{
		public IfcNamedUnit(IfcDimensionalExponents dimensions,
				IfcUnitEnum unitType,
				Boolean unitTypeSpecified,
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
			this.dimensionsField = dimensions;
			this.unitTypeField = unitType;
			this.unitTypeSpecifiedField = unitTypeSpecified;
		}
	}
}