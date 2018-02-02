	
using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using STEP;
	
namespace IFC
{
    /// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpositivelengthmeasure.htm
	/// </summary>
	public class IfcPositiveLengthMeasure : BaseIfc
	{
		internal IfcLengthMeasure value;

		public IfcPositiveLengthMeasure(IfcLengthMeasure value){ this.value = value; }	
		public static implicit operator IfcLengthMeasure(IfcPositiveLengthMeasure v){ return v.value; }
		public static implicit operator IfcPositiveLengthMeasure(IfcLengthMeasure v){ return new IfcPositiveLengthMeasure(v); }	
		public static IfcPositiveLengthMeasure FromJSON(string json){ return JsonConvert.DeserializeObject<IfcPositiveLengthMeasure>(json); }
        public override string ToString(){ return value.ToString(); }
		public override string ToStepValue(bool isSelectOption = false){
			if(isSelectOption){ return $"{GetType().Name.ToUpper()}({value.ToStepValue(isSelectOption)})"; }
			else{ return value.ToStepValue(isSelectOption); }
        }
	}
}
