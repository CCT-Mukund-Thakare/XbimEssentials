// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ActorResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPersonAndOrganization
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPersonAndOrganization : IPersistEntity, IfcActorSelect, IfcObjectReferenceSelect
	{
		IIfcPerson @ThePerson { get;  set; }
		IIfcOrganization @TheOrganization { get;  set; }
		IItemSet<IIfcActorRole> @Roles { get; }
	
	}
}

namespace Xbim.Ifc2x3.ActorResource
{
	[ExpressType("IfcPersonAndOrganization", 663)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPersonAndOrganization : PersistEntity, IInstantiableEntity, IIfcPersonAndOrganization, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcPersonAndOrganization>
	{
		#region IIfcPersonAndOrganization explicit implementation
		IIfcPerson IIfcPersonAndOrganization.ThePerson { 
 
 
			get { return @ThePerson; } 
			set { ThePerson = value as IfcPerson;}
		}	
		IIfcOrganization IIfcPersonAndOrganization.TheOrganization { 
 
 
			get { return @TheOrganization; } 
			set { TheOrganization = value as IfcOrganization;}
		}	
		IItemSet<IIfcActorRole> IIfcPersonAndOrganization.Roles { 
			get { return new Common.Collections.ProxyItemSet<IfcActorRole, IIfcActorRole>( @Roles); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPersonAndOrganization(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_roles = new OptionalItemSet<IfcActorRole>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcPerson _thePerson;
		private IfcOrganization _theOrganization;
		private readonly OptionalItemSet<IfcActorRole> _roles;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcPerson @ThePerson 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thePerson;
				((IPersistEntity)this).Activate(false);
				return _thePerson;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _thePerson = v, _thePerson, value,  "ThePerson", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcOrganization @TheOrganization 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _theOrganization;
				((IPersistEntity)this).Activate(false);
				return _theOrganization;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _theOrganization = v, _theOrganization, value,  "TheOrganization", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 3)]
		public IOptionalItemSet<IfcActorRole> @Roles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _roles;
				((IPersistEntity)this).Activate(false);
				return _roles;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_thePerson = (IfcPerson)(value.EntityVal);
					return;
				case 1: 
					_theOrganization = (IfcOrganization)(value.EntityVal);
					return;
				case 2: 
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPersonAndOrganization other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ThePerson != null)
					yield return @ThePerson;
				if (@TheOrganization != null)
					yield return @TheOrganization;
				foreach(var entity in @Roles)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ThePerson != null)
					yield return @ThePerson;
				if (@TheOrganization != null)
					yield return @TheOrganization;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}