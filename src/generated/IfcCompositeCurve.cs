/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcCompositeCurve : IfcBoundedCurve 
	{
		public IfcCompositeCurve(IfcCompositeCurveSegments segments,
				IfcLogical selfIntersect,
				Boolean selfIntersectSpecified,
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
			this.segmentsField = segments;
			this.selfIntersectField = selfIntersect;
			this.selfIntersectSpecifiedField = selfIntersectSpecified;
		}
	}
}