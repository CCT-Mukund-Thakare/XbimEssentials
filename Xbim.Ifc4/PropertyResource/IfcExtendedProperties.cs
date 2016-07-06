// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcExtendedProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcExtendedProperties : IIfcPropertyAbstraction
	{
		IfcIdentifier? @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IEnumerable<IIfcProperty> @Properties { get; }
	
	}
}

namespace Xbim.Ifc4.PropertyResource
{
	[ExpressType("IfcExtendedProperties", 1171)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcExtendedProperties : IfcPropertyAbstraction, IIfcExtendedProperties, IEquatable<@IfcExtendedProperties>
	{
		#region IIfcExtendedProperties explicit implementation
		IfcIdentifier? IIfcExtendedProperties.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcExtendedProperties.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IEnumerable<IIfcProperty> IIfcExtendedProperties.Properties { 
			get { return new Common.Collections.ProxyItemSet<IfcProperty, IIfcProperty>( @Properties); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExtendedProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_properties = new ItemSet<IfcProperty>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcIdentifier? _name;
		private IfcText? _description;
		private readonly ItemSet<IfcProperty> _properties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcIdentifier? @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 4)]
		public IItemSet<IfcProperty> @Properties 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _properties;
				((IPersistEntity)this).Activate(false);
				return _properties;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_properties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcExtendedProperties other)
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