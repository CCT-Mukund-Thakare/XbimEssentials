// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.StructuralAnalysisDomain;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralSurfaceMemberVarying
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralSurfaceMemberVarying : IIfcStructuralSurfaceMember
	{
		IItemSet<IfcPositiveLengthMeasure> @SubsequentThickness { get; }
		IIfcShapeAspect @VaryingThicknessLocation { get;  set; }
		List<IfcPositiveLengthMeasure> @VaryingThickness  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IfcStructuralSurfaceMemberVarying", 421)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralSurfaceMemberVarying : IfcStructuralSurfaceMember, IInstantiableEntity, IIfcStructuralSurfaceMemberVarying, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcStructuralSurfaceMemberVarying>
	{
		#region IIfcStructuralSurfaceMemberVarying explicit implementation
		IItemSet<IfcPositiveLengthMeasure> IIfcStructuralSurfaceMemberVarying.SubsequentThickness { 
			get { return @SubsequentThickness; } 
		}	
		IIfcShapeAspect IIfcStructuralSurfaceMemberVarying.VaryingThicknessLocation { 
 
 
			get { return @VaryingThicknessLocation; } 
			set { VaryingThicknessLocation = value as IfcShapeAspect;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralSurfaceMemberVarying(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_subsequentThickness = new ItemSet<IfcPositiveLengthMeasure>( this, 0,  10);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcPositiveLengthMeasure> _subsequentThickness;
		private IfcShapeAspect _varyingThicknessLocation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1, 19)]
		public IItemSet<IfcPositiveLengthMeasure> @SubsequentThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _subsequentThickness;
				((IPersistEntity)this).Activate(false);
				return _subsequentThickness;
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public IfcShapeAspect @VaryingThicknessLocation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _varyingThicknessLocation;
				((IPersistEntity)this).Activate(false);
				return _varyingThicknessLocation;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _varyingThicknessLocation = v, _varyingThicknessLocation, value,  "VaryingThicknessLocation", 11);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.List, EntityAttributeType.None, 3, -1, 0)]
		public List<IfcPositiveLengthMeasure> @VaryingThickness 
		{
			get 
			{
				//## Getter for VaryingThickness
			    var result = new List<IfcPositiveLengthMeasure> {Thickness ?? 0};
                result.AddRange(SubsequentThickness);
			    return result;
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					_subsequentThickness.InternalAdd(value.RealVal);
					return;
				case 10: 
					_varyingThicknessLocation = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralSurfaceMemberVarying other)
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
				if (@VaryingThicknessLocation != null)
					yield return @VaryingThicknessLocation;
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
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}