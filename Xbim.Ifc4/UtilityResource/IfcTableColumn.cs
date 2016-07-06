// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.UtilityResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTableColumn
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTableColumn : IPersistEntity
	{
		IfcIdentifier? @Identifier { get;  set; }
		IfcLabel? @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IIfcUnit @Unit { get;  set; }
		IIfcReference @ReferencePath { get;  set; }
	
	}
}

namespace Xbim.Ifc4.UtilityResource
{
	[ExpressType("IfcTableColumn", 1292)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTableColumn : PersistEntity, IInstantiableEntity, IIfcTableColumn, IContainsEntityReferences, IEquatable<@IfcTableColumn>
	{
		#region IIfcTableColumn explicit implementation
		IfcIdentifier? IIfcTableColumn.Identifier { 
 
			get { return @Identifier; } 
			set { Identifier = value;}
		}	
		IfcLabel? IIfcTableColumn.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcTableColumn.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IIfcUnit IIfcTableColumn.Unit { 
 
 
			get { return @Unit; } 
			set { Unit = value as IfcUnit;}
		}	
		IIfcReference IIfcTableColumn.ReferencePath { 
 
 
			get { return @ReferencePath; } 
			set { ReferencePath = value as IfcReference;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTableColumn(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identifier;
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcUnit _unit;
		private IfcReference _referencePath;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcIdentifier? @Identifier 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _identifier;
				((IPersistEntity)this).Activate(false);
				return _identifier;
			} 
			set
			{
				SetValue( v =>  _identifier = v, _identifier, value,  "Identifier", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
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
				SetValue( v =>  _description = v, _description, value,  "Description", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unit;
				((IPersistEntity)this).Activate(false);
				return _unit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcReference @ReferencePath 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _referencePath;
				((IPersistEntity)this).Activate(false);
				return _referencePath;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _referencePath = v, _referencePath, value,  "ReferencePath", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_identifier = value.StringVal;
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				case 4: 
					_referencePath = (IfcReference)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTableColumn other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
				if (@ReferencePath != null)
					yield return @ReferencePath;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}