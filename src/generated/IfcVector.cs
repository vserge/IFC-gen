/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcVector : IfcGeometricRepresentationItem 
	{
		public IfcVector(IfcDirection orientation,
				Double magnitude,
				Boolean magnitudeSpecified,
				IfcStyledItem styledByItem,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(styledByItem,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.orientationField = orientation;
			this.magnitudeField = magnitude;
			this.magnitudeSpecifiedField = magnitudeSpecified;
		}
	}
}