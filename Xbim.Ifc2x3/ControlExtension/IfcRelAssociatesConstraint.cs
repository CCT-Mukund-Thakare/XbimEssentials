// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ControlExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAssociatesConstraint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssociatesConstraint : IIfcRelAssociates
	{
		IfcLabel @Intent { get;  set; }
		IIfcConstraint @RelatingConstraint { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ControlExtension
{
	[ExpressType("IfcRelAssociatesConstraint", 711)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssociatesConstraint : IfcRelAssociates, IInstantiableEntity, IIfcRelAssociatesConstraint, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelAssociatesConstraint>
	{
		#region IIfcRelAssociatesConstraint explicit implementation
		IfcLabel IIfcRelAssociatesConstraint.Intent { 
 
			get { return @Intent; } 
			set { Intent = value;}
		}	
		IIfcConstraint IIfcRelAssociatesConstraint.RelatingConstraint { 
 
 
			get { return @RelatingConstraint; } 
			set { RelatingConstraint = value as IfcConstraint;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssociatesConstraint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _intent;
		private IfcConstraint _relatingConstraint;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcLabel @Intent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _intent;
				((IPersistEntity)this).Activate(false);
				return _intent;
			} 
			set
			{
				SetValue( v =>  _intent = v, _intent, value,  "Intent", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcConstraint @RelatingConstraint 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingConstraint;
				((IPersistEntity)this).Activate(false);
				return _relatingConstraint;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingConstraint = v, _relatingConstraint, value,  "RelatingConstraint", 7);
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
					_intent = value.StringVal;
					return;
				case 6: 
					_relatingConstraint = (IfcConstraint)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssociatesConstraint other)
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
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingConstraint != null)
					yield return @RelatingConstraint;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedObjects)
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