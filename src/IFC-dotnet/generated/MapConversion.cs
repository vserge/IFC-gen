/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmapconversion.htm
	/// </summary>
	internal  partial class MapConversion : CoordinateOperation 
	{
		public Double Eastings {get;set;}

		public Double Northings {get;set;}

		public Double OrthogonalHeight {get;set;}

		public Double XAxisAbscissa {get;set;}

		public Double XAxisOrdinate {get;set;}

		public Double Scale {get;set;}

		public MapConversion(Double eastings,
				Double northings,
				Double orthogonalHeight,
				Double xAxisAbscissa,
				Double xAxisOrdinate,
				Double scale,
				CoordinateReferenceSystem targetCRS) : base(targetCRS)
		{
			this.Eastings = eastings;
			this.Northings = northings;
			this.OrthogonalHeight = orthogonalHeight;
			this.XAxisAbscissa = xAxisAbscissa;
			this.XAxisOrdinate = xAxisOrdinate;
			this.Scale = scale;
		}
	}
}