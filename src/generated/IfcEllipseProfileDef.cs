/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcEllipseProfileDef : IfcParameterizedProfileDef 
	{
		public IfcEllipseProfileDef(Double semiAxis1,
				Boolean semiAxis1Specified,
				Double semiAxis2,
				Boolean semiAxis2Specified,
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
			this.semiAxis1Field = semiAxis1;
			this.semiAxis1SpecifiedField = semiAxis1Specified;
			this.semiAxis2Field = semiAxis2;
			this.semiAxis2SpecifiedField = semiAxis2Specified;
		}
	}
}