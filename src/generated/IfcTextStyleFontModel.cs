/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcTextStyleFontModel : IfcPreDefinedTextFont 
	{
		public IfcTextStyleFontModel(IfcTextStyleFontModelFontFamily fontFamily,
				IfcTextStyleFontModelFontSize fontSize,
				String fontStyle,
				String fontVariant,
				String fontWeight,
				String name,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(name,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.fontFamilyField = fontFamily;
			this.fontSizeField = fontSize;
			this.fontStyleField = fontStyle;
			this.fontVariantField = fontVariant;
			this.fontWeightField = fontWeight;
		}
	}
}