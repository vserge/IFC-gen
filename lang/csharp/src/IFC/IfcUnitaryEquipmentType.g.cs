

using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using STEP;
	
namespace IFC
{
	/// <summary>
	/// <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcunitaryequipmenttype.htm"/>
	/// </summary>
	public  partial class IfcUnitaryEquipmentType : IfcEnergyConversionDeviceType
	{
		public IfcUnitaryEquipmentTypeEnum PredefinedType{get;set;} 


		/// <summary>
		/// Construct a IfcUnitaryEquipmentType with all required attributes.
		/// </summary>
		public IfcUnitaryEquipmentType(IfcGloballyUniqueId globalId,IfcUnitaryEquipmentTypeEnum predefinedType):base(globalId)
		{

			PredefinedType = predefinedType;

		}
		/// <summary>
		/// Construct a IfcUnitaryEquipmentType with required and optional attributes.
		/// </summary>
		[JsonConstructor]
		public IfcUnitaryEquipmentType(IfcGloballyUniqueId globalId,IfcOwnerHistory ownerHistory,IfcLabel name,IfcText description,IfcIdentifier applicableOccurrence,List<IfcPropertySetDefinition> hasPropertySets,List<IfcRepresentationMap> representationMaps,IfcLabel tag,IfcLabel elementType,IfcUnitaryEquipmentTypeEnum predefinedType):base(globalId,ownerHistory,name,description,applicableOccurrence,hasPropertySets,representationMaps,tag,elementType)
		{

			PredefinedType = predefinedType;

		}
		public static new IfcUnitaryEquipmentType FromJSON(string json){ return JsonConvert.DeserializeObject<IfcUnitaryEquipmentType>(json); }

        public override string GetStepParameters()
        {
            var parameters = new List<string>();
			parameters.Add(GlobalId != null ? GlobalId.ToStepValue() : "$");
			parameters.Add(OwnerHistory != null ? OwnerHistory.ToStepValue() : "$");
			parameters.Add(Name != null ? Name.ToStepValue() : "$");
			parameters.Add(Description != null ? Description.ToStepValue() : "$");
			parameters.Add(ApplicableOccurrence != null ? ApplicableOccurrence.ToStepValue() : "$");
			parameters.Add(HasPropertySets != null ? HasPropertySets.ToStepValue() : "$");
			parameters.Add(RepresentationMaps != null ? RepresentationMaps.ToStepValue() : "$");
			parameters.Add(Tag != null ? Tag.ToStepValue() : "$");
			parameters.Add(ElementType != null ? ElementType.ToStepValue() : "$");
			parameters.Add(PredefinedType.ToStepValue());

            return string.Join(", ", parameters.ToArray());
        }
	}
}
