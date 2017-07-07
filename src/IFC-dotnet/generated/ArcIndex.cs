/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcarcindex.htm
	/// </summary>
	internal  partial class ArcIndex 
	{
		public String[] itemType {get;set;}

		public aggregateType[] cType {get;set;}

		public String[] arraySize {get;set;}

		public Int64[] Text {get;set;}

		public ArcIndex(String[] itemType,
				aggregateType[] cType,
				String[] arraySize,
				Int64[] text)
		{
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
			this.Text = text;
		}
	}
}