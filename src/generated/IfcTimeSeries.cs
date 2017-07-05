/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcTimeSeries : Entity 
	{
		public IfcTimeSeries(IfcTimeSeriesUnit unit,
				String name,
				String description,
				String startTime,
				String endTime,
				IfcTimeSeriesDataTypeEnum timeSeriesDataType,
				Boolean timeSeriesDataTypeSpecified,
				IfcDataOriginEnum dataOrigin,
				Boolean dataOriginSpecified,
				String userDefinedDataOrigin,
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
			this.unitField = unit;
			this.nameField = name;
			this.descriptionField = description;
			this.startTimeField = startTime;
			this.endTimeField = endTime;
			this.timeSeriesDataTypeField = timeSeriesDataType;
			this.timeSeriesDataTypeSpecifiedField = timeSeriesDataTypeSpecified;
			this.dataOriginField = dataOrigin;
			this.dataOriginSpecifiedField = dataOriginSpecified;
			this.userDefinedDataOriginField = userDefinedDataOrigin;
		}
	}
}