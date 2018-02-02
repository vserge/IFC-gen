

using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using STEP;
	
namespace IFC
{
	/// <summary>
	/// <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcactionrequest.htm"/>
	/// </summary>
	public  partial class IfcActionRequest : IfcControl
	{
		public IfcActionRequestTypeEnum PredefinedType{get;set;} // optional
		public IfcLabel Status{get;set;} // optional
		public IfcText LongDescription{get;set;} // optional


		/// <summary>
		/// Construct a IfcActionRequest with all required attributes.
		/// </summary>
		public IfcActionRequest(IfcGloballyUniqueId globalId):base(globalId)
		{


		}
		/// <summary>
		/// Construct a IfcActionRequest with required and optional attributes.
		/// </summary>
		[JsonConstructor]
		public IfcActionRequest(IfcGloballyUniqueId globalId,IfcOwnerHistory ownerHistory,IfcLabel name,IfcText description,IfcLabel objectType,IfcIdentifier identification,IfcActionRequestTypeEnum predefinedType,IfcLabel status,IfcText longDescription):base(globalId,ownerHistory,name,description,objectType,identification)
		{

			PredefinedType = predefinedType;
			Status = status;
			LongDescription = longDescription;

		}
		public static new IfcActionRequest FromJSON(string json){ return JsonConvert.DeserializeObject<IfcActionRequest>(json); }

        public override string GetStepParameters()
        {
            var parameters = new List<string>();
			parameters.Add(GlobalId != null ? GlobalId.ToStepValue() : "$");
			parameters.Add(OwnerHistory != null ? OwnerHistory.ToStepValue() : "$");
			parameters.Add(Name != null ? Name.ToStepValue() : "$");
			parameters.Add(Description != null ? Description.ToStepValue() : "$");
			parameters.Add(ObjectType != null ? ObjectType.ToStepValue() : "$");
			parameters.Add(Identification != null ? Identification.ToStepValue() : "$");
			parameters.Add(PredefinedType.ToStepValue());
			parameters.Add(Status != null ? Status.ToStepValue() : "$");
			parameters.Add(LongDescription != null ? LongDescription.ToStepValue() : "$");

            return string.Join(", ", parameters.ToArray());
        }
	}
}
