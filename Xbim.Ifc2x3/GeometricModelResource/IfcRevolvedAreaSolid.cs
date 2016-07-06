// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRevolvedAreaSolid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRevolvedAreaSolid : IIfcSweptAreaSolid
	{
		IIfcAxis1Placement @Axis { get;  set; }
		IfcPlaneAngleMeasure @Angle { get;  set; }
		Common.Geometry.XbimLine @AxisLine  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcRevolvedAreaSolid", 515)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRevolvedAreaSolid : IfcSweptAreaSolid, IInstantiableEntity, IIfcRevolvedAreaSolid, IContainsEntityReferences, IEquatable<@IfcRevolvedAreaSolid>
	{
		#region IIfcRevolvedAreaSolid explicit implementation
		IIfcAxis1Placement IIfcRevolvedAreaSolid.Axis { 
 
 
			get { return @Axis; } 
			set { Axis = value as IfcAxis1Placement;}
		}	
		IfcPlaneAngleMeasure IIfcRevolvedAreaSolid.Angle { 
 
			get { return @Angle; } 
			set { Angle = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRevolvedAreaSolid(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAxis1Placement _axis;
		private IfcPlaneAngleMeasure _angle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcAxis1Placement @Axis 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _axis;
				((IPersistEntity)this).Activate(false);
				return _axis;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _axis = v, _axis, value,  "Axis", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPlaneAngleMeasure @Angle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _angle;
				((IPersistEntity)this).Activate(false);
				return _angle;
			} 
			set
			{
				SetValue( v =>  _angle = v, _angle, value,  "Angle", 4);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public Common.Geometry.XbimLine @AxisLine 
		{
			get 
			{
				//## Getter for AxisLine
                if (Axis != null)
                {
                    return new Common.Geometry.XbimLine
                    {
                        Pnt = new Common.Geometry.XbimPoint3D(Axis.Location.X, Axis.Location.Y, Axis.Location.Z),
                        Orientation = Axis.Z,
                    };
                }
                return null;
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
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_axis = (IfcAxis1Placement)(value.EntityVal);
					return;
				case 3: 
					_angle = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRevolvedAreaSolid other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SweptArea != null)
					yield return @SweptArea;
				if (@Position != null)
					yield return @Position;
				if (@Axis != null)
					yield return @Axis;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}