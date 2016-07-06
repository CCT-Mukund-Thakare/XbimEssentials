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
using Xbim.Ifc4.CostResource;
using Xbim.Ifc4.QuantityResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.SharedMgmtElements;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCostItem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCostItem : IIfcControl
	{
		IfcCostItemTypeEnum? @PredefinedType { get;  set; }
		IItemSet<IIfcCostValue> @CostValues { get; }
		IItemSet<IIfcPhysicalQuantity> @CostQuantities { get; }
	
	}
}

namespace Xbim.Ifc4.SharedMgmtElements
{
	[ExpressType("IfcCostItem", 694)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCostItem : IfcControl, IInstantiableEntity, IIfcCostItem, IContainsEntityReferences, IEquatable<@IfcCostItem>
	{
		#region IIfcCostItem explicit implementation
		IfcCostItemTypeEnum? IIfcCostItem.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		IItemSet<IIfcCostValue> IIfcCostItem.CostValues { 
			get { return new Common.Collections.ProxyItemSet<IfcCostValue, IIfcCostValue>( @CostValues); } 
		}	
		IItemSet<IIfcPhysicalQuantity> IIfcCostItem.CostQuantities { 
			get { return new Common.Collections.ProxyItemSet<IfcPhysicalQuantity, IIfcPhysicalQuantity>( @CostQuantities); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostItem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_costValues = new OptionalItemSet<IfcCostValue>( this, 0,  8);
			_costQuantities = new OptionalItemSet<IfcPhysicalQuantity>( this, 0,  9);
		}

		#region Explicit attribute fields
		private IfcCostItemTypeEnum? _predefinedType;
		private readonly OptionalItemSet<IfcCostValue> _costValues;
		private readonly OptionalItemSet<IfcPhysicalQuantity> _costQuantities;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 19)]
		public IfcCostItemTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 20)]
		public IOptionalItemSet<IfcCostValue> @CostValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _costValues;
				((IPersistEntity)this).Activate(false);
				return _costValues;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 21)]
		public IOptionalItemSet<IfcPhysicalQuantity> @CostQuantities 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _costQuantities;
				((IPersistEntity)this).Activate(false);
				return _costQuantities;
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
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
                    _predefinedType = (IfcCostItemTypeEnum) System.Enum.Parse(typeof (IfcCostItemTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					_costValues.InternalAdd((IfcCostValue)value.EntityVal);
					return;
				case 8: 
					_costQuantities.InternalAdd((IfcPhysicalQuantity)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCostItem other)
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
				foreach(var entity in @CostValues)
					yield return entity;
				foreach(var entity in @CostQuantities)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}