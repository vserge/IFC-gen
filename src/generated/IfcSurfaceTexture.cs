/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcSurfaceTexture : IfcPresentationItem 
	{
		public IfcSurfaceTexture(IfcCartesianTransformationOperator2D textureTransform,
				Boolean repeatS,
				Boolean repeatSSpecified,
				Boolean repeatT,
				Boolean repeatTSpecified,
				String mode,
				String[] parameter,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(href,
				reference,
				id,
				path,
				pos)
		{
			this.textureTransformField = textureTransform;
			this.repeatSField = repeatS;
			this.repeatSSpecifiedField = repeatSSpecified;
			this.repeatTField = repeatT;
			this.repeatTSpecifiedField = repeatTSpecified;
			this.modeField = mode;
			this.parameterField = parameter;
		}
	}
}