/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcLShapeProfileDef : IfcParameterizedProfileDef 
	{
		public IfcLShapeProfileDef(Double depth,
				Boolean depthSpecified,
				Double width,
				Boolean widthSpecified,
				Double thickness,
				Boolean thicknessSpecified,
				Double filletRadius,
				Boolean filletRadiusSpecified,
				Double edgeRadius,
				Boolean edgeRadiusSpecified,
				Double legSlope,
				Boolean legSlopeSpecified,
				IfcAxis2Placement2D position,
				IfcProfileDefHasProperties hasProperties,
				IfcProfileTypeEnum profileType,
				Boolean profileTypeSpecified,
				String profileName,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(position,
				hasProperties,
				profileType,
				profileTypeSpecified,
				profileName,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.depthField = depth;
			this.depthSpecifiedField = depthSpecified;
			this.widthField = width;
			this.widthSpecifiedField = widthSpecified;
			this.thicknessField = thickness;
			this.thicknessSpecifiedField = thicknessSpecified;
			this.filletRadiusField = filletRadius;
			this.filletRadiusSpecifiedField = filletRadiusSpecified;
			this.edgeRadiusField = edgeRadius;
			this.edgeRadiusSpecifiedField = edgeRadiusSpecified;
			this.legSlopeField = legSlope;
			this.legSlopeSpecifiedField = legSlopeSpecified;
		}
	}
}