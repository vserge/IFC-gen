/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcIndexedTriangleTextureMap : IfcIndexedTextureMap 
	{
		public IfcIndexedTriangleTextureMap(Int64[] texCoordIndex,
				IfcTextureVertexList texCoords,
				IfcTextureCoordinateMaps maps,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(texCoords,
				maps,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.texCoordIndexField = texCoordIndex;
		}
	}
}