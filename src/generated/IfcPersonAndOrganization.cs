/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcPersonAndOrganization : Entity 
	{
		public IfcPersonAndOrganization(IfcPerson thePerson,
				IfcOrganization theOrganization,
				IfcPersonAndOrganizationRoles roles,
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
			this.thePersonField = thePerson;
			this.theOrganizationField = theOrganization;
			this.rolesField = roles;
		}
	}
}