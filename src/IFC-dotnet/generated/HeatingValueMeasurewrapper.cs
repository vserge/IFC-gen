/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcheatingvaluemeasurewrapper.htm
	/// </summary>
	internal  partial class HeatingValueMeasurewrapper 
	{
		public String id {get;set;}

		public String path {get;set;}

		public String[] pos {get;set;}

		public Double Value {get;set;}

		public HeatingValueMeasurewrapper(String id,
				String path,
				String[] pos,
				Double value)
		{
			this.id = id;
			this.path = path;
			this.pos = pos;
			this.Value = value;
		}
	}
}