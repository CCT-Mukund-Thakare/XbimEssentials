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
using Xbim.Ifc4.GeometricConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcGrid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGrid : IIfcProduct
	{
		IItemSet<IIfcGridAxis> @UAxes { get; }
		IItemSet<IIfcGridAxis> @VAxes { get; }
		IItemSet<IIfcGridAxis> @WAxes { get; }
		IfcGridTypeEnum? @PredefinedType { get;  set; }
		IEnumerable<IIfcRelContainedInSpatialStructure> @ContainedInStructure {  get; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcGrid", 564)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGrid : IfcProduct, IInstantiableEntity, IIfcGrid, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcGrid>
	{
		#region IIfcGrid explicit implementation
		IItemSet<IIfcGridAxis> IIfcGrid.UAxes { 
			get { return new Common.Collections.ProxyItemSet<IfcGridAxis, IIfcGridAxis>( @UAxes); } 
		}	
		IItemSet<IIfcGridAxis> IIfcGrid.VAxes { 
			get { return new Common.Collections.ProxyItemSet<IfcGridAxis, IIfcGridAxis>( @VAxes); } 
		}	
		IItemSet<IIfcGridAxis> IIfcGrid.WAxes { 
			get { return new Common.Collections.ProxyItemSet<IfcGridAxis, IIfcGridAxis>( @WAxes); } 
		}	
		IfcGridTypeEnum? IIfcGrid.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		 
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcGrid.ContainedInStructure {  get { return @ContainedInStructure; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGrid(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_uAxes = new ItemSet<IfcGridAxis>( this, 0,  8);
			_vAxes = new ItemSet<IfcGridAxis>( this, 0,  9);
			_wAxes = new OptionalItemSet<IfcGridAxis>( this, 0,  10);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcGridAxis> _uAxes;
		private readonly ItemSet<IfcGridAxis> _vAxes;
		private readonly OptionalItemSet<IfcGridAxis> _wAxes;
		private IfcGridTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 20)]
		public IItemSet<IfcGridAxis> @UAxes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _uAxes;
				((IPersistEntity)this).Activate(false);
				return _uAxes;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 21)]
		public IItemSet<IfcGridAxis> @VAxes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vAxes;
				((IPersistEntity)this).Activate(false);
				return _vAxes;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 22)]
		public IOptionalItemSet<IfcGridAxis> @WAxes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _wAxes;
				((IPersistEntity)this).Activate(false);
				return _wAxes;
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 23)]
		public IfcGridTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 11);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedElements")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 24)]
		public IEnumerable<IfcRelContainedInSpatialStructure> @ContainedInStructure 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelContainedInSpatialStructure>(e => e.RelatedElements != null &&  e.RelatedElements.Contains(this), "RelatedElements", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_uAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 8: 
					_vAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 9: 
					_wAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 10: 
                    _predefinedType = (IfcGridTypeEnum) System.Enum.Parse(typeof (IfcGridTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGrid other)
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
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				foreach(var entity in @UAxes)
					yield return entity;
				foreach(var entity in @VAxes)
					yield return entity;
				foreach(var entity in @WAxes)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				foreach(var entity in @UAxes)
					yield return entity;
				foreach(var entity in @VAxes)
					yield return entity;
				foreach(var entity in @WAxes)
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