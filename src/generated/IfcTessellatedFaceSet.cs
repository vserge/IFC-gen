/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcTessellatedFaceSet : IfcTessellatedItem 
	{
		public IfcTessellatedFaceSet(IfcCartesianPointList3D coordinates,
				IfcIndexedColourMap hasColours,
				IfcTessellatedFaceSetHasTextures hasTextures,
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
			this.coordinatesField = coordinates;
			this.hasColoursField = hasColours;
			this.hasTexturesField = hasTextures;
		}
	}
}