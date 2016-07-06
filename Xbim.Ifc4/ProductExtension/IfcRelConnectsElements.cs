// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.GeometricConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelConnectsElements
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelConnectsElements : IIfcRelConnects
	{
		IIfcConnectionGeometry @ConnectionGeometry { get;  set; }
		IIfcElement @RelatingElement { get;  set; }
		IIfcElement @RelatedElement { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcRelConnectsElements", 312)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsElements : IfcRelConnects, IInstantiableEntity, IIfcRelConnectsElements, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelConnectsElements>
	{
		#region IIfcRelConnectsElements explicit implementation
		IIfcConnectionGeometry IIfcRelConnectsElements.ConnectionGeometry { 
 
 
			get { return @ConnectionGeometry; } 
			set { ConnectionGeometry = value as IfcConnectionGeometry;}
		}	
		IIfcElement IIfcRelConnectsElements.RelatingElement { 
 
 
			get { return @RelatingElement; } 
			set { RelatingElement = value as IfcElement;}
		}	
		IIfcElement IIfcRelConnectsElements.RelatedElement { 
 
 
			get { return @RelatedElement; } 
			set { RelatedElement = value as IfcElement;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsElements(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcConnectionGeometry _connectionGeometry;
		private IfcElement _relatingElement;
		private IfcElement _relatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcConnectionGeometry @ConnectionGeometry 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _connectionGeometry;
				((IPersistEntity)this).Activate(false);
				return _connectionGeometry;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _connectionGeometry = v, _connectionGeometry, value,  "ConnectionGeometry", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcElement @RelatingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingElement;
				((IPersistEntity)this).Activate(false);
				return _relatingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingElement = v, _relatingElement, value,  "RelatingElement", 6);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcElement @RelatedElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedElement;
				((IPersistEntity)this).Activate(false);
				return _relatedElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedElement = v, _relatedElement, value,  "RelatedElement", 7);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_connectionGeometry = (IfcConnectionGeometry)(value.EntityVal);
					return;
				case 5: 
					_relatingElement = (IfcElement)(value.EntityVal);
					return;
				case 6: 
					_relatedElement = (IfcElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsElements other)
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
				if (@ConnectionGeometry != null)
					yield return @ConnectionGeometry;
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedElement != null)
					yield return @RelatedElement;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedElement != null)
					yield return @RelatedElement;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}