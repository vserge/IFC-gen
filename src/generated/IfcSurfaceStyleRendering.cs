/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSurfaceStyleRendering : IfcSurfaceStyleShading 
	{
		public IfcSurfaceStyleRendering(IfcSurfaceStyleRenderingDiffuseColour diffuseColour,
				IfcSurfaceStyleRenderingTransmissionColour transmissionColour,
				IfcSurfaceStyleRenderingDiffuseTransmissionColour diffuseTransmissionColour,
				IfcSurfaceStyleRenderingReflectionColour reflectionColour,
				IfcSurfaceStyleRenderingSpecularColour specularColour,
				IfcSurfaceStyleRenderingSpecularHighlight specularHighlight,
				IfcReflectanceMethodEnum reflectanceMethod,
				Boolean reflectanceMethodSpecified,
				IfcColourRgb surfaceColour,
				Double transparency,
				Boolean transparencySpecified,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(surfaceColour,
				transparency,
				transparencySpecified,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.diffuseColourField = diffuseColour;
			this.transmissionColourField = transmissionColour;
			this.diffuseTransmissionColourField = diffuseTransmissionColour;
			this.reflectionColourField = reflectionColour;
			this.specularColourField = specularColour;
			this.specularHighlightField = specularHighlight;
			this.reflectanceMethodField = reflectanceMethod;
			this.reflectanceMethodSpecifiedField = reflectanceMethodSpecified;
		}
	}
}