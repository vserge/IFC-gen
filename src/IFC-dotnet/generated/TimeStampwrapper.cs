/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctimestampwrapper.htm
	/// </summary>
	internal  partial class TimeStampwrapper 
	{
		public String id {get;set;}

		public String path {get;set;}

		public String[] pos {get;set;}

		public Int64 Value {get;set;}

		public TimeStampwrapper(String id,
				String path,
				String[] pos,
				Int64 value)
		{
			this.id = id;
			this.path = path;
			this.pos = pos;
			this.Value = value;
		}
	}
}