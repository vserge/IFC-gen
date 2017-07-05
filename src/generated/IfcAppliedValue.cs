/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public partial class IfcAppliedValue : Entity 
	{
		public IfcAppliedValue(IfcAppliedValueAppliedValue appliedValue,
				IfcMeasureWithUnit unitBasis,
				IfcAppliedValueComponents components,
				String name,
				String description,
				String applicableDate,
				String fixedUntilDate,
				String category,
				String condition,
				IfcArithmeticOperatorEnum arithmeticOperator,
				Boolean arithmeticOperatorSpecified,
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
			this.appliedValueField = appliedValue;
			this.unitBasisField = unitBasis;
			this.componentsField = components;
			this.nameField = name;
			this.descriptionField = description;
			this.applicableDateField = applicableDate;
			this.fixedUntilDateField = fixedUntilDate;
			this.categoryField = category;
			this.conditionField = condition;
			this.arithmeticOperatorField = arithmeticOperator;
			this.arithmeticOperatorSpecifiedField = arithmeticOperatorSpecified;
		}
	}
}