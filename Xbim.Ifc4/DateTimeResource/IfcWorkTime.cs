// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.DateTimeResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWorkTime
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWorkTime : IIfcSchedulingTime
	{
		IIfcRecurrencePattern @RecurrencePattern { get;  set; }
		IfcDate? @Start { get;  set; }
		IfcDate? @Finish { get;  set; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IfcWorkTime", 1319)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWorkTime : IfcSchedulingTime, IInstantiableEntity, IIfcWorkTime, IContainsEntityReferences, IEquatable<@IfcWorkTime>
	{
		#region IIfcWorkTime explicit implementation
		IIfcRecurrencePattern IIfcWorkTime.RecurrencePattern { 
 
 
			get { return @RecurrencePattern; } 
			set { RecurrencePattern = value as IfcRecurrencePattern;}
		}	
		IfcDate? IIfcWorkTime.Start { 
 
			get { return @Start; } 
			set { Start = value;}
		}	
		IfcDate? IIfcWorkTime.Finish { 
 
			get { return @Finish; } 
			set { Finish = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkTime(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcRecurrencePattern _recurrencePattern;
		private IfcDate? _start;
		private IfcDate? _finish;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcRecurrencePattern @RecurrencePattern 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _recurrencePattern;
				((IPersistEntity)this).Activate(false);
				return _recurrencePattern;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _recurrencePattern = v, _recurrencePattern, value,  "RecurrencePattern", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcDate? @Start 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _start;
				((IPersistEntity)this).Activate(false);
				return _start;
			} 
			set
			{
				SetValue( v =>  _start = v, _start, value,  "Start", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcDate? @Finish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _finish;
				((IPersistEntity)this).Activate(false);
				return _finish;
			} 
			set
			{
				SetValue( v =>  _finish = v, _finish, value,  "Finish", 6);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_recurrencePattern = (IfcRecurrencePattern)(value.EntityVal);
					return;
				case 4: 
					_start = value.StringVal;
					return;
				case 5: 
					_finish = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWorkTime other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RecurrencePattern != null)
					yield return @RecurrencePattern;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}