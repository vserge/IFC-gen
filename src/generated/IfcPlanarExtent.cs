/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcPlanarExtent : IfcGeometricRepresentationItem 
	{
		public IfcPlanarExtent(Double sizeInX,
				Boolean sizeInXSpecified,
				Double sizeInY,
				Boolean sizeInYSpecified,
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
			this.sizeInXField = sizeInX;
			this.sizeInXSpecifiedField = sizeInXSpecified;
			this.sizeInYField = sizeInY;
			this.sizeInYSpecifiedField = sizeInYSpecified;
		}
	}
}