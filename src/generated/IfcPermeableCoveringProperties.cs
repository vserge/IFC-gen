/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcPermeableCoveringProperties : IfcPreDefinedPropertySet 
	{
		public IfcPermeableCoveringProperties(IfcShapeAspect shapeAspectStyle,
				IfcPermeableCoveringOperationEnum operationType,
				Boolean operationTypeSpecified,
				IfcWindowPanelPositionEnum panelPosition,
				Boolean panelPositionSpecified,
				Double frameDepth,
				Boolean frameDepthSpecified,
				Double frameThickness,
				Boolean frameThicknessSpecified,
				IfcOwnerHistory ownerHistory,
				String globalId,
				String name,
				String description,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(ownerHistory,
				globalId,
				name,
				description,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.shapeAspectStyleField = shapeAspectStyle;
			this.operationTypeField = operationType;
			this.operationTypeSpecifiedField = operationTypeSpecified;
			this.panelPositionField = panelPosition;
			this.panelPositionSpecifiedField = panelPositionSpecified;
			this.frameDepthField = frameDepth;
			this.frameDepthSpecifiedField = frameDepthSpecified;
			this.frameThicknessField = frameThickness;
			this.frameThicknessSpecifiedField = frameThicknessSpecified;
		}
	}
}