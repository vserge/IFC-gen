/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcCurveStyle : IfcPresentationStyle 
	{
		public IfcCurveStyle(IfcCurveStyleCurveFont curveFont,
				IfcCurveStyleCurveWidth curveWidth,
				IfcCurveStyleCurveColour curveColour,
				Boolean modelOrDraughting,
				Boolean modelOrDraughtingSpecified,
				String name,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(name,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.curveFontField = curveFont;
			this.curveWidthField = curveWidth;
			this.curveColourField = curveColour;
			this.modelOrDraughtingField = modelOrDraughting;
			this.modelOrDraughtingSpecifiedField = modelOrDraughtingSpecified;
		}
	}
}