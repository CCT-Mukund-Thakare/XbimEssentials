// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using Xbim.Ifc2x3.ActorResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProcessExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWorkControl
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWorkControl : IIfcControl
	{
		IfcIdentifier @Identifier { get;  set; }
		IIfcDateTimeSelect @CreationDate { get;  set; }
		IItemSet<IIfcPerson> @Creators { get; }
		IfcLabel? @Purpose { get;  set; }
		IfcTimeMeasure? @Duration { get;  set; }
		IfcTimeMeasure? @TotalFloat { get;  set; }
		IIfcDateTimeSelect @StartTime { get;  set; }
		IIfcDateTimeSelect @FinishTime { get;  set; }
		IfcWorkControlTypeEnum? @WorkControlType { get;  set; }
		IfcLabel? @UserDefinedControlType { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProcessExtension
{
	[ExpressType("IfcWorkControl", 185)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcWorkControl : IfcControl, IIfcWorkControl, IEquatable<@IfcWorkControl>
	{
		#region IIfcWorkControl explicit implementation
		IfcIdentifier IIfcWorkControl.Identifier { 
 
			get { return @Identifier; } 
			set { Identifier = value;}
		}	
		IIfcDateTimeSelect IIfcWorkControl.CreationDate { 
 
 
			get { return @CreationDate; } 
			set { CreationDate = value as IfcDateTimeSelect;}
		}	
		IItemSet<IIfcPerson> IIfcWorkControl.Creators { 
			get { return new Common.Collections.ProxyItemSet<IfcPerson, IIfcPerson>( @Creators); } 
		}	
		IfcLabel? IIfcWorkControl.Purpose { 
 
			get { return @Purpose; } 
			set { Purpose = value;}
		}	
		IfcTimeMeasure? IIfcWorkControl.Duration { 
 
			get { return @Duration; } 
			set { Duration = value;}
		}	
		IfcTimeMeasure? IIfcWorkControl.TotalFloat { 
 
			get { return @TotalFloat; } 
			set { TotalFloat = value;}
		}	
		IIfcDateTimeSelect IIfcWorkControl.StartTime { 
 
 
			get { return @StartTime; } 
			set { StartTime = value as IfcDateTimeSelect;}
		}	
		IIfcDateTimeSelect IIfcWorkControl.FinishTime { 
 
 
			get { return @FinishTime; } 
			set { FinishTime = value as IfcDateTimeSelect;}
		}	
		IfcWorkControlTypeEnum? IIfcWorkControl.WorkControlType { 
 
			get { return @WorkControlType; } 
			set { WorkControlType = value;}
		}	
		IfcLabel? IIfcWorkControl.UserDefinedControlType { 
 
			get { return @UserDefinedControlType; } 
			set { UserDefinedControlType = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkControl(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_creators = new OptionalItemSet<IfcPerson>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcIdentifier _identifier;
		private IfcDateTimeSelect _creationDate;
		private readonly OptionalItemSet<IfcPerson> _creators;
		private IfcLabel? _purpose;
		private IfcTimeMeasure? _duration;
		private IfcTimeMeasure? _totalFloat;
		private IfcDateTimeSelect _startTime;
		private IfcDateTimeSelect _finishTime;
		private IfcWorkControlTypeEnum? _workControlType;
		private IfcLabel? _userDefinedControlType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcIdentifier @Identifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _identifier;
				((IPersistEntity)this).Activate(false);
				return _identifier;
			} 
			set
			{
				SetValue( v =>  _identifier = v, _identifier, value,  "Identifier", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcDateTimeSelect @CreationDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creationDate;
				((IPersistEntity)this).Activate(false);
				return _creationDate;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _creationDate = v, _creationDate, value,  "CreationDate", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 14)]
		public IOptionalItemSet<IfcPerson> @Creators 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creators;
				((IPersistEntity)this).Activate(false);
				return _creators;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public IfcLabel? @Purpose 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _purpose;
				((IPersistEntity)this).Activate(false);
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public IfcTimeMeasure? @Duration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _duration;
				((IPersistEntity)this).Activate(false);
				return _duration;
			} 
			set
			{
				SetValue( v =>  _duration = v, _duration, value,  "Duration", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 17)]
		public IfcTimeMeasure? @TotalFloat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _totalFloat;
				((IPersistEntity)this).Activate(false);
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 18)]
		public IfcDateTimeSelect @StartTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startTime;
				((IPersistEntity)this).Activate(false);
				return _startTime;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _startTime = v, _startTime, value,  "StartTime", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public IfcDateTimeSelect @FinishTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _finishTime;
				((IPersistEntity)this).Activate(false);
				return _finishTime;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _finishTime = v, _finishTime, value,  "FinishTime", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 20)]
		public IfcWorkControlTypeEnum? @WorkControlType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _workControlType;
				((IPersistEntity)this).Activate(false);
				return _workControlType;
			} 
			set
			{
				SetValue( v =>  _workControlType = v, _workControlType, value,  "WorkControlType", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcLabel? @UserDefinedControlType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedControlType;
				((IPersistEntity)this).Activate(false);
				return _userDefinedControlType;
			} 
			set
			{
				SetValue( v =>  _userDefinedControlType = v, _userDefinedControlType, value,  "UserDefinedControlType", 15);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_identifier = value.StringVal;
					return;
				case 6: 
					_creationDate = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 7: 
					_creators.InternalAdd((IfcPerson)value.EntityVal);
					return;
				case 8: 
					_purpose = value.StringVal;
					return;
				case 9: 
					_duration = value.RealVal;
					return;
				case 10: 
					_totalFloat = value.RealVal;
					return;
				case 11: 
					_startTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 12: 
					_finishTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 13: 
                    _workControlType = (IfcWorkControlTypeEnum) System.Enum.Parse(typeof (IfcWorkControlTypeEnum), value.EnumVal, true);
					return;
				case 14: 
					_userDefinedControlType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWorkControl other)
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