// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelConnectsPorts
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelConnectsPorts : IIfcRelConnects
	{
		IIfcPort @RelatingPort { get;  set; }
		IIfcPort @RelatedPort { get;  set; }
		IIfcElement @RealizingElement { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IfcRelConnectsPorts", 215)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsPorts : IfcRelConnects, IInstantiableEntity, IIfcRelConnectsPorts, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelConnectsPorts>
	{
		#region IIfcRelConnectsPorts explicit implementation
		IIfcPort IIfcRelConnectsPorts.RelatingPort { 
 
 
			get { return @RelatingPort; } 
			set { RelatingPort = value as IfcPort;}
		}	
		IIfcPort IIfcRelConnectsPorts.RelatedPort { 
 
 
			get { return @RelatedPort; } 
			set { RelatedPort = value as IfcPort;}
		}	
		IIfcElement IIfcRelConnectsPorts.RealizingElement { 
 
 
			get { return @RealizingElement; } 
			set { RealizingElement = value as IfcElement;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsPorts(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPort _relatingPort;
		private IfcPort _relatedPort;
		private IfcElement _realizingElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcPort @RelatingPort 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingPort;
				((IPersistEntity)this).Activate(false);
				return _relatingPort;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingPort = v, _relatingPort, value,  "RelatingPort", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcPort @RelatedPort 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedPort;
				((IPersistEntity)this).Activate(false);
				return _relatedPort;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedPort = v, _relatedPort, value,  "RelatedPort", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcElement @RealizingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _realizingElement;
				((IPersistEntity)this).Activate(false);
				return _realizingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _realizingElement = v, _realizingElement, value,  "RealizingElement", 7);
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
					_relatingPort = (IfcPort)(value.EntityVal);
					return;
				case 5: 
					_relatedPort = (IfcPort)(value.EntityVal);
					return;
				case 6: 
					_realizingElement = (IfcElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsPorts other)
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
				if (@RelatingPort != null)
					yield return @RelatingPort;
				if (@RelatedPort != null)
					yield return @RelatedPort;
				if (@RealizingElement != null)
					yield return @RealizingElement;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingPort != null)
					yield return @RelatingPort;
				if (@RelatedPort != null)
					yield return @RelatedPort;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}