/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcConnectionPointEccentricity : IfcConnectionPointGeometry 
	{
		public IfcConnectionPointEccentricity(Double eccentricityInX,
				Boolean eccentricityInXSpecified,
				Double eccentricityInY,
				Boolean eccentricityInYSpecified,
				Double eccentricityInZ,
				Boolean eccentricityInZSpecified,
				IfcConnectionPointGeometryPointOnRelatingElement pointOnRelatingElement,
				IfcConnectionPointGeometryPointOnRelatedElement pointOnRelatedElement,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(pointOnRelatingElement,
				pointOnRelatedElement,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.eccentricityInXField = eccentricityInX;
			this.eccentricityInXSpecifiedField = eccentricityInXSpecified;
			this.eccentricityInYField = eccentricityInY;
			this.eccentricityInYSpecifiedField = eccentricityInYSpecified;
			this.eccentricityInZField = eccentricityInZ;
			this.eccentricityInZSpecifiedField = eccentricityInZSpecified;
		}
	}
}