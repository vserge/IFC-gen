/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcCurveStyleFontPattern : IfcPresentationItem 
	{
		public IfcCurveStyleFontPattern(Double visibleSegmentLength,
				Boolean visibleSegmentLengthSpecified,
				Double invisibleSegmentLength,
				Boolean invisibleSegmentLengthSpecified,
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
			this.visibleSegmentLengthField = visibleSegmentLength;
			this.visibleSegmentLengthSpecifiedField = visibleSegmentLengthSpecified;
			this.invisibleSegmentLengthField = invisibleSegmentLength;
			this.invisibleSegmentLengthSpecifiedField = invisibleSegmentLengthSpecified;
		}
	}
}