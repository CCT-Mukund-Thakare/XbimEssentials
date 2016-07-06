// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MaterialResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialClassificationRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialClassificationRelationship : IPersistEntity
	{
		IEnumerable<IIfcClassificationNotationSelect> @MaterialClassifications { get; }
		IIfcMaterial @ClassifiedMaterial { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.MaterialResource
{
	[ExpressType("IfcMaterialClassificationRelationship", 8)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialClassificationRelationship : PersistEntity, IInstantiableEntity, IIfcMaterialClassificationRelationship, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcMaterialClassificationRelationship>
	{
		#region IIfcMaterialClassificationRelationship explicit implementation
		IEnumerable<IIfcClassificationNotationSelect> IIfcMaterialClassificationRelationship.MaterialClassifications { 
			get { return new Common.Collections.ProxyItemSet<IfcClassificationNotationSelect, IIfcClassificationNotationSelect>( @MaterialClassifications); } 
		}	
		IIfcMaterial IIfcMaterialClassificationRelationship.ClassifiedMaterial { 
 
 
			get { return @ClassifiedMaterial; } 
			set { ClassifiedMaterial = value as IfcMaterial;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialClassificationRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_materialClassifications = new ItemSet<IfcClassificationNotationSelect>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcClassificationNotationSelect> _materialClassifications;
		private IfcMaterial _classifiedMaterial;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 1)]
		public IItemSet<IfcClassificationNotationSelect> @MaterialClassifications 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _materialClassifications;
				((IPersistEntity)this).Activate(false);
				return _materialClassifications;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcMaterial @ClassifiedMaterial 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _classifiedMaterial;
				((IPersistEntity)this).Activate(false);
				return _classifiedMaterial;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _classifiedMaterial = v, _classifiedMaterial, value,  "ClassifiedMaterial", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_materialClassifications.InternalAdd((IfcClassificationNotationSelect)value.EntityVal);
					return;
				case 1: 
					_classifiedMaterial = (IfcMaterial)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialClassificationRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @MaterialClassifications)
					yield return entity;
				if (@ClassifiedMaterial != null)
					yield return @ClassifiedMaterial;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ClassifiedMaterial != null)
					yield return @ClassifiedMaterial;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}