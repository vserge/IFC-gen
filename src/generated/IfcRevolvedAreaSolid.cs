/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRevolvedAreaSolid : IfcSweptAreaSolid 
	{
		public IfcRevolvedAreaSolid(IfcAxis1Placement axis,
				Double angle,
				Boolean angleSpecified,
				IfcProfileDef sweptArea,
				IfcAxis2Placement3D position,
				IfcStyledItem styledByItem,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(sweptArea,
				position,
				styledByItem,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.axisField = axis;
			this.angleField = angle;
			this.angleSpecifiedField = angleSpecified;
		}
	}
}