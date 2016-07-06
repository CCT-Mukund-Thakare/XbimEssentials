// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.DateTimeResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCalendarDate
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCalendarDate : IPersistEntity, IfcDateTimeSelect, IfcObjectReferenceSelect
	{
		IfcDayInMonthNumber @DayComponent { get;  set; }
		IfcMonthInYearNumber @MonthComponent { get;  set; }
		IfcYearNumber @YearComponent { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.DateTimeResource
{
	[ExpressType("IfcCalendarDate", 407)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCalendarDate : PersistEntity, IInstantiableEntity, IIfcCalendarDate, IEquatable<@IfcCalendarDate>
	{
		#region IIfcCalendarDate explicit implementation
		IfcDayInMonthNumber IIfcCalendarDate.DayComponent { 
 
			get { return @DayComponent; } 
			set { DayComponent = value;}
		}	
		IfcMonthInYearNumber IIfcCalendarDate.MonthComponent { 
 
			get { return @MonthComponent; } 
			set { MonthComponent = value;}
		}	
		IfcYearNumber IIfcCalendarDate.YearComponent { 
 
			get { return @YearComponent; } 
			set { YearComponent = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCalendarDate(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDayInMonthNumber _dayComponent;
		private IfcMonthInYearNumber _monthComponent;
		private IfcYearNumber _yearComponent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcDayInMonthNumber @DayComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _dayComponent;
				((IPersistEntity)this).Activate(false);
				return _dayComponent;
			} 
			set
			{
				SetValue( v =>  _dayComponent = v, _dayComponent, value,  "DayComponent", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcMonthInYearNumber @MonthComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _monthComponent;
				((IPersistEntity)this).Activate(false);
				return _monthComponent;
			} 
			set
			{
				SetValue( v =>  _monthComponent = v, _monthComponent, value,  "MonthComponent", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcYearNumber @YearComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _yearComponent;
				((IPersistEntity)this).Activate(false);
				return _yearComponent;
			} 
			set
			{
				SetValue( v =>  _yearComponent = v, _yearComponent, value,  "YearComponent", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_dayComponent = value.IntegerVal;
					return;
				case 1: 
					_monthComponent = value.IntegerVal;
					return;
				case 2: 
					_yearComponent = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCalendarDate other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}