/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcWorkControlCreators : Object 
	{
		public IfcWorkControlCreators(IfcPerson[] ifcPerson,
				String[] itemType,
				aggregateType[] cType,
				String[] arraySize) : base()
		{
			this.ifcPersonField = ifcPerson;
			this.itemTypeField = itemType;
			this.cTypeField = cType;
			this.arraySizeField = arraySize;
		}
	}
}