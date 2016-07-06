// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProcessExtension;
using Xbim.Ifc2x3.ProductExtension;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.FacilitiesMgmtDomain;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMove
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMove : IIfcTask
	{
		IIfcSpatialStructureElement @MoveFrom { get;  set; }
		IIfcSpatialStructureElement @MoveTo { get;  set; }
		IItemSet<IfcText> @PunchList { get; }
	
	}
}

namespace Xbim.Ifc2x3.FacilitiesMgmtDomain
{
	[ExpressType("IfcMove", 74)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMove : IfcTask, IInstantiableEntity, IIfcMove, IContainsEntityReferences, IEquatable<@IfcMove>
	{
		#region IIfcMove explicit implementation
		IIfcSpatialStructureElement IIfcMove.MoveFrom { 
 
 
			get { return @MoveFrom; } 
			set { MoveFrom = value as IfcSpatialStructureElement;}
		}	
		IIfcSpatialStructureElement IIfcMove.MoveTo { 
 
 
			get { return @MoveTo; } 
			set { MoveTo = value as IfcSpatialStructureElement;}
		}	
		IItemSet<IfcText> IIfcMove.PunchList { 
			get { return @PunchList; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMove(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_punchList = new OptionalItemSet<IfcText>( this, 0,  13);
		}

		#region Explicit attribute fields
		private IfcSpatialStructureElement _moveFrom;
		private IfcSpatialStructureElement _moveTo;
		private readonly OptionalItemSet<IfcText> _punchList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public IfcSpatialStructureElement @MoveFrom 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _moveFrom;
				((IPersistEntity)this).Activate(false);
				return _moveFrom;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _moveFrom = v, _moveFrom, value,  "MoveFrom", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public IfcSpatialStructureElement @MoveTo 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _moveTo;
				((IPersistEntity)this).Activate(false);
				return _moveTo;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _moveTo = v, _moveTo, value,  "MoveTo", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.ListUnique, EntityAttributeType.None, 1, -1, 21)]
		public IOptionalItemSet<IfcText> @PunchList 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _punchList;
				((IPersistEntity)this).Activate(false);
				return _punchList;
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
				case 6: 
				case 7: 
				case 8: 
				case 9: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 10: 
					_moveFrom = (IfcSpatialStructureElement)(value.EntityVal);
					return;
				case 11: 
					_moveTo = (IfcSpatialStructureElement)(value.EntityVal);
					return;
				case 12: 
					_punchList.InternalAdd(value.StringVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMove other)
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
				if (@MoveFrom != null)
					yield return @MoveFrom;
				if (@MoveTo != null)
					yield return @MoveTo;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}