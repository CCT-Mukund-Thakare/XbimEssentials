// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.RepresentationResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcGeometricRepresentationContext
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGeometricRepresentationContext : IIfcRepresentationContext
	{
		IfcDimensionCount @CoordinateSpaceDimension { get;  set; }
		double? @Precision { get;  set; }
		IIfcAxis2Placement @WorldCoordinateSystem { get;  set; }
		IIfcDirection @TrueNorth { get;  set; }
		IEnumerable<IIfcGeometricRepresentationSubContext> @HasSubContexts {  get; }
	
	}
}

namespace Xbim.Ifc2x3.RepresentationResource
{
	[ExpressType("IfcGeometricRepresentationContext", 555)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeometricRepresentationContext : IfcRepresentationContext, IInstantiableEntity, IIfcGeometricRepresentationContext, IContainsEntityReferences, IEquatable<@IfcGeometricRepresentationContext>
	{
		#region IIfcGeometricRepresentationContext explicit implementation
		IfcDimensionCount IIfcGeometricRepresentationContext.CoordinateSpaceDimension { 
 
			get { return @CoordinateSpaceDimension; } 
			set { CoordinateSpaceDimension = value;}
		}	
		double? IIfcGeometricRepresentationContext.Precision { 
 
			get { return @Precision; } 
			set { Precision = value;}
		}	
		IIfcAxis2Placement IIfcGeometricRepresentationContext.WorldCoordinateSystem { 
 
 
			get { return @WorldCoordinateSystem; } 
			set { WorldCoordinateSystem = value as IfcAxis2Placement;}
		}	
		IIfcDirection IIfcGeometricRepresentationContext.TrueNorth { 
 
 
			get { return @TrueNorth; } 
			set { TrueNorth = value as IfcDirection;}
		}	
		 
		IEnumerable<IIfcGeometricRepresentationSubContext> IIfcGeometricRepresentationContext.HasSubContexts {  get { return @HasSubContexts; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricRepresentationContext(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDimensionCount _coordinateSpaceDimension;
		private double? _precision;
		private IfcAxis2Placement _worldCoordinateSystem;
		private IfcDirection _trueNorth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public virtual IfcDimensionCount @CoordinateSpaceDimension 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordinateSpaceDimension;
				((IPersistEntity)this).Activate(false);
				return _coordinateSpaceDimension;
			} 
			set
			{
				SetValue( v =>  _coordinateSpaceDimension = v, _coordinateSpaceDimension, value,  "CoordinateSpaceDimension", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public virtual double? @Precision 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _precision;
				((IPersistEntity)this).Activate(false);
				return _precision;
			} 
			set
			{
				SetValue( v =>  _precision = v, _precision, value,  "Precision", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public virtual IfcAxis2Placement @WorldCoordinateSystem 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _worldCoordinateSystem;
				((IPersistEntity)this).Activate(false);
				return _worldCoordinateSystem;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _worldCoordinateSystem = v, _worldCoordinateSystem, value,  "WorldCoordinateSystem", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public virtual IfcDirection @TrueNorth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _trueNorth;
				((IPersistEntity)this).Activate(false);
				return _trueNorth;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _trueNorth = v, _trueNorth, value,  "TrueNorth", 6);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ParentContext")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 8)]
		public IEnumerable<IfcGeometricRepresentationSubContext> @HasSubContexts 
		{ 
			get 
			{
				return Model.Instances.Where<IfcGeometricRepresentationSubContext>(e => Equals(e.ParentContext), "ParentContext", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_coordinateSpaceDimension = value.IntegerVal;
					return;
				case 3: 
					_precision = value.RealVal;
					return;
				case 4: 
					_worldCoordinateSystem = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 5: 
					_trueNorth = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGeometricRepresentationContext other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@WorldCoordinateSystem != null)
					yield return @WorldCoordinateSystem;
				if (@TrueNorth != null)
					yield return @TrueNorth;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}