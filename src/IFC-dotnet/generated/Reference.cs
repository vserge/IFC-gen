/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreference.htm
	/// </summary>
	internal  partial class Reference : Entity 
	{
		public Reference InnerReference {get;set;}

		public String TypeIdentifier {get;set;}

		public String AttributeIdentifier {get;set;}

		public String InstanceName {get;set;}

		public Int64[] ListPositions {get;set;}

		public Reference(Reference innerReference,
				String typeIdentifier,
				String attributeIdentifier,
				String instanceName,
				Int64[] listPositions) : base()
		{
			this.InnerReference = innerReference;
			this.TypeIdentifier = typeIdentifier;
			this.AttributeIdentifier = attributeIdentifier;
			this.InstanceName = instanceName;
			this.ListPositions = listPositions;
		}
	}
}