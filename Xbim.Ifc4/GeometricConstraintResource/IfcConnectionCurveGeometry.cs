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
using Xbim.Ifc4.GeometricConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConnectionCurveGeometry
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConnectionCurveGeometry : IIfcConnectionGeometry
	{
		IIfcCurveOrEdgeCurve @CurveOnRelatingElement { get;  set; }
		IIfcCurveOrEdgeCurve @CurveOnRelatedElement { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcConnectionCurveGeometry", 590)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionCurveGeometry : IfcConnectionGeometry, IInstantiableEntity, IIfcConnectionCurveGeometry, IContainsEntityReferences, IEquatable<@IfcConnectionCurveGeometry>
	{
		#region IIfcConnectionCurveGeometry explicit implementation
		IIfcCurveOrEdgeCurve IIfcConnectionCurveGeometry.CurveOnRelatingElement { 
 
 
			get { return @CurveOnRelatingElement; } 
			set { CurveOnRelatingElement = value as IfcCurveOrEdgeCurve;}
		}	
		IIfcCurveOrEdgeCurve IIfcConnectionCurveGeometry.CurveOnRelatedElement { 
 
 
			get { return @CurveOnRelatedElement; } 
			set { CurveOnRelatedElement = value as IfcCurveOrEdgeCurve;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionCurveGeometry(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCurveOrEdgeCurve _curveOnRelatingElement;
		private IfcCurveOrEdgeCurve _curveOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcCurveOrEdgeCurve @CurveOnRelatingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveOnRelatingElement;
				((IPersistEntity)this).Activate(false);
				return _curveOnRelatingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _curveOnRelatingElement = v, _curveOnRelatingElement, value,  "CurveOnRelatingElement", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcCurveOrEdgeCurve @CurveOnRelatedElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curveOnRelatedElement;
				((IPersistEntity)this).Activate(false);
				return _curveOnRelatedElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _curveOnRelatedElement = v, _curveOnRelatedElement, value,  "CurveOnRelatedElement", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_curveOnRelatingElement = (IfcCurveOrEdgeCurve)(value.EntityVal);
					return;
				case 1: 
					_curveOnRelatedElement = (IfcCurveOrEdgeCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConnectionCurveGeometry other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@CurveOnRelatingElement != null)
					yield return @CurveOnRelatingElement;
				if (@CurveOnRelatedElement != null)
					yield return @CurveOnRelatedElement;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}