// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ActorResource;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.CostResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.SharedFacilitiesElements;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcInventory
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcInventory : IIfcGroup
	{
		IfcInventoryTypeEnum? @PredefinedType { get;  set; }
		IIfcActorSelect @Jurisdiction { get;  set; }
		IItemSet<IIfcPerson> @ResponsiblePersons { get; }
		IfcDate? @LastUpdateDate { get;  set; }
		IIfcCostValue @CurrentValue { get;  set; }
		IIfcCostValue @OriginalValue { get;  set; }
	
	}
}

namespace Xbim.Ifc4.SharedFacilitiesElements
{
	[ExpressType("IfcInventory", 768)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcInventory : IfcGroup, IInstantiableEntity, IIfcInventory, IContainsEntityReferences, IEquatable<@IfcInventory>
	{
		#region IIfcInventory explicit implementation
		IfcInventoryTypeEnum? IIfcInventory.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		IIfcActorSelect IIfcInventory.Jurisdiction { 
 
 
			get { return @Jurisdiction; } 
			set { Jurisdiction = value as IfcActorSelect;}
		}	
		IItemSet<IIfcPerson> IIfcInventory.ResponsiblePersons { 
			get { return new Common.Collections.ProxyItemSet<IfcPerson, IIfcPerson>( @ResponsiblePersons); } 
		}	
		IfcDate? IIfcInventory.LastUpdateDate { 
 
			get { return @LastUpdateDate; } 
			set { LastUpdateDate = value;}
		}	
		IIfcCostValue IIfcInventory.CurrentValue { 
 
 
			get { return @CurrentValue; } 
			set { CurrentValue = value as IfcCostValue;}
		}	
		IIfcCostValue IIfcInventory.OriginalValue { 
 
 
			get { return @OriginalValue; } 
			set { OriginalValue = value as IfcCostValue;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcInventory(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_responsiblePersons = new OptionalItemSet<IfcPerson>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcInventoryTypeEnum? _predefinedType;
		private IfcActorSelect _jurisdiction;
		private readonly OptionalItemSet<IfcPerson> _responsiblePersons;
		private IfcDate? _lastUpdateDate;
		private IfcCostValue _currentValue;
		private IfcCostValue _originalValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 18)]
		public IfcInventoryTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public IfcActorSelect @Jurisdiction 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _jurisdiction;
				((IPersistEntity)this).Activate(false);
				return _jurisdiction;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _jurisdiction = v, _jurisdiction, value,  "Jurisdiction", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 20)]
		public IOptionalItemSet<IfcPerson> @ResponsiblePersons 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _responsiblePersons;
				((IPersistEntity)this).Activate(false);
				return _responsiblePersons;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcDate? @LastUpdateDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lastUpdateDate;
				((IPersistEntity)this).Activate(false);
				return _lastUpdateDate;
			} 
			set
			{
				SetValue( v =>  _lastUpdateDate = v, _lastUpdateDate, value,  "LastUpdateDate", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 22)]
		public IfcCostValue @CurrentValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _currentValue;
				((IPersistEntity)this).Activate(false);
				return _currentValue;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _currentValue = v, _currentValue, value,  "CurrentValue", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 23)]
		public IfcCostValue @OriginalValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _originalValue;
				((IPersistEntity)this).Activate(false);
				return _originalValue;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _originalValue = v, _originalValue, value,  "OriginalValue", 11);
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
                    _predefinedType = (IfcInventoryTypeEnum) System.Enum.Parse(typeof (IfcInventoryTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_jurisdiction = (IfcActorSelect)(value.EntityVal);
					return;
				case 7: 
					_responsiblePersons.InternalAdd((IfcPerson)value.EntityVal);
					return;
				case 8: 
					_lastUpdateDate = value.StringVal;
					return;
				case 9: 
					_currentValue = (IfcCostValue)(value.EntityVal);
					return;
				case 10: 
					_originalValue = (IfcCostValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcInventory other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@Jurisdiction != null)
					yield return @Jurisdiction;
				foreach(var entity in @ResponsiblePersons)
					yield return entity;
				if (@CurrentValue != null)
					yield return @CurrentValue;
				if (@OriginalValue != null)
					yield return @OriginalValue;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}