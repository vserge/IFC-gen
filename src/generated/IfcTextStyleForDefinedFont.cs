/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcTextStyleForDefinedFont : IfcPresentationItem 
	{
		public IfcTextStyleForDefinedFont(IfcTextStyleForDefinedFontColour colour,
				IfcTextStyleForDefinedFontBackgroundColour backgroundColour,
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
			this.colourField = colour;
			this.backgroundColourField = backgroundColour;
		}
	}
}