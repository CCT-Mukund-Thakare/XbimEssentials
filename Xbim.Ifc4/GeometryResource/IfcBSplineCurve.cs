// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBSplineCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBSplineCurve : IIfcBoundedCurve
	{
		IfcInteger @Degree { get;  set; }
		IItemSet<IIfcCartesianPoint> @ControlPointsList { get; }
		IfcBSplineCurveForm @CurveForm { get;  set; }
		IfcLogical @ClosedCurve { get;  set; }
		IfcLogical @SelfIntersect { get;  set; }
		IfcInteger @UpperIndexOnControlPoints  { get ; }
		List<Common.Geometry.XbimPoint3D> @ControlPoints  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcBSplineCurve", 167)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcBSplineCurve : IfcBoundedCurve, IIfcBSplineCurve, IEquatable<@IfcBSplineCurve>
	{
		#region IIfcBSplineCurve explicit implementation
		IfcInteger IIfcBSplineCurve.Degree { 
 
			get { return @Degree; } 
			set { Degree = value;}
		}	
		IItemSet<IIfcCartesianPoint> IIfcBSplineCurve.ControlPointsList { 
			get { return new Common.Collections.ProxyItemSet<IfcCartesianPoint, IIfcCartesianPoint>( @ControlPointsList); } 
		}	
		IfcBSplineCurveForm IIfcBSplineCurve.CurveForm { 
 
			get { return @CurveForm; } 
			set { CurveForm = value;}
		}	
		IfcLogical IIfcBSplineCurve.ClosedCurve { 
 
			get { return @ClosedCurve; } 
			set { ClosedCurve = value;}
		}	
		IfcLogical IIfcBSplineCurve.SelfIntersect { 
 
			get { return @SelfIntersect; } 
			set { SelfIntersect = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBSplineCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_controlPointsList = new ItemSet<IfcCartesianPoint>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcInteger _degree;
		private readonly ItemSet<IfcCartesianPoint> _controlPointsList;
		private IfcBSplineCurveForm _curveForm;
		private IfcLogical _closedCurve;
		private IfcLogical _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcInteger @Degree 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _degree;
				((IPersistEntity)this).Activate(false);
				return _degree;
			} 
			set
			{
				SetValue( v =>  _degree = v, _degree, value,  "Degree", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1, 4)]
		public IItemSet<IfcCartesianPoint> @ControlPointsList 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _controlPointsList;
				((IPersistEntity)this).Activate(false);
				return _controlPointsList;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 5)]
		public IfcBSplineCurveForm @CurveForm 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveForm;
				((IPersistEntity)this).Activate(false);
				return _curveForm;
			} 
			set
			{
				SetValue( v =>  _curveForm = v, _curveForm, value,  "CurveForm", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcLogical @ClosedCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _closedCurve;
				((IPersistEntity)this).Activate(false);
				return _closedCurve;
			} 
			set
			{
				SetValue( v =>  _closedCurve = v, _closedCurve, value,  "ClosedCurve", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcLogical @SelfIntersect 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _selfIntersect;
				((IPersistEntity)this).Activate(false);
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect", 5);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcInteger @UpperIndexOnControlPoints 
		{
			get 
			{
				//## Getter for UpperIndexOnControlPoints
			    return ControlPointsList.Count - 1;
			    //##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Array, EntityAttributeType.Class, 0, -1, 0)]
		public List<Common.Geometry.XbimPoint3D> @ControlPoints 
		{
			get 
			{
				//## Getter for ControlPoints
			    return ControlPointsList.Select(p => new Common.Geometry.XbimPoint3D(p.X, p.Y, p.Z)).ToList();
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_degree = value.IntegerVal;
					return;
				case 1: 
					_controlPointsList.InternalAdd((IfcCartesianPoint)value.EntityVal);
					return;
				case 2: 
                    _curveForm = (IfcBSplineCurveForm) System.Enum.Parse(typeof (IfcBSplineCurveForm), value.EnumVal, true);
					return;
				case 3: 
					_closedCurve = value.BooleanVal;
					return;
				case 4: 
					_selfIntersect = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBSplineCurve other)
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