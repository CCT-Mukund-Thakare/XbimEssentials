// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometricConstraintResource;
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
    /// Readonly interface for IfcRelConnectsWithEccentricity
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelConnectsWithEccentricity : IIfcRelConnectsStructuralMember
	{
		IIfcConnectionGeometry @ConnectionConstraint { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IfcRelConnectsWithEccentricity", 322)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsWithEccentricity : IfcRelConnectsStructuralMember, IInstantiableEntity, IIfcRelConnectsWithEccentricity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelConnectsWithEccentricity>
	{
		#region IIfcRelConnectsWithEccentricity explicit implementation
		IIfcConnectionGeometry IIfcRelConnectsWithEccentricity.ConnectionConstraint { 
 
 
			get { return @ConnectionConstraint; } 
			set { ConnectionConstraint = value as IfcConnectionGeometry;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsWithEccentricity(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcConnectionGeometry _connectionConstraint;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 11)]
		public IfcConnectionGeometry @ConnectionConstraint 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _connectionConstraint;
				((IPersistEntity)this).Activate(false);
				return _connectionConstraint;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _connectionConstraint = v, _connectionConstraint, value,  "ConnectionConstraint", 11);
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
					_connectionConstraint = (IfcConnectionGeometry)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsWithEccentricity other)
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
				if (@RelatingStructuralMember != null)
					yield return @RelatingStructuralMember;
				if (@RelatedStructuralConnection != null)
					yield return @RelatedStructuralConnection;
				if (@AppliedCondition != null)
					yield return @AppliedCondition;
				if (@AdditionalConditions != null)
					yield return @AdditionalConditions;
				if (@ConditionCoordinateSystem != null)
					yield return @ConditionCoordinateSystem;
				if (@ConnectionConstraint != null)
					yield return @ConnectionConstraint;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingStructuralMember != null)
					yield return @RelatingStructuralMember;
				if (@RelatedStructuralConnection != null)
					yield return @RelatedStructuralConnection;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}