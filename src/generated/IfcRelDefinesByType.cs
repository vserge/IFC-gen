/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcRelDefinesByType : IfcRelDefines 
	{
		public IfcRelDefinesByType(IfcTypeObject relatingType,
				IfcOwnerHistory ownerHistory,
				String globalId,
				String name,
				String description,
				String href,
				String reference,
				String id,
				String path,
				String[] pos) : base(ownerHistory,
				globalId,
				name,
				description,
				href,
				reference,
				id,
				path,
				pos)
		{
			this.relatingTypeField = relatingType;
		}
	}
}