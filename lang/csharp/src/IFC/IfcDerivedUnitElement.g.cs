

using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using STEP;
	
namespace IFC
{
	/// <summary>
	/// <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcderivedunitelement.htm"/>
	/// </summary>
	public  partial class IfcDerivedUnitElement : BaseIfc
	{
		public IfcNamedUnit Unit{get;set;} 
		public int Exponent{get;set;} 


		/// <summary>
		/// Construct a IfcDerivedUnitElement with all required attributes.
		/// </summary>
		[JsonConstructor]
		public IfcDerivedUnitElement(IfcNamedUnit unit,int exponent):base()
		{

			Unit = unit;
			Exponent = exponent;

		}
		public static  IfcDerivedUnitElement FromJSON(string json){ return JsonConvert.DeserializeObject<IfcDerivedUnitElement>(json); }

        public override string GetStepParameters()
        {
            var parameters = new List<string>();
			parameters.Add(Unit != null ? Unit.ToStepValue() : "$");
			parameters.Add(Exponent.ToStepValue());

            return string.Join(", ", parameters.ToArray());
        }
	}
}
