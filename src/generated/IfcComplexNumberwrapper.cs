/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcComplexNumberwrapper : IfcComplexNumber 
	{
		public IfcComplexNumberwrapper(String id,
				String path,
				String[] pos,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize,
				Double[] text) : base(itemType,
				cType,
				arraySize,
				text)
		{
			this.idField = id;
			this.pathField = path;
			this.posField = pos;
		}
	}
}