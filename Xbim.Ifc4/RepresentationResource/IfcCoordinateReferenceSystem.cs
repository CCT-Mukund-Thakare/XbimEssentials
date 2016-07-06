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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.RepresentationResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCoordinateReferenceSystem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCoordinateReferenceSystem : IPersistEntity, IfcCoordinateReferenceSystemSelect
	{
		IfcLabel @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IfcIdentifier? @GeodeticDatum { get;  set; }
		IfcIdentifier? @VerticalDatum { get;  set; }
		IEnumerable<IIfcCoordinateOperation> @HasCoordinateOperation {  get; }
	
	}
}

namespace Xbim.Ifc4.RepresentationResource
{
	[ExpressType("IfcCoordinateReferenceSystem", 1144)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcCoordinateReferenceSystem : PersistEntity, IIfcCoordinateReferenceSystem, IEquatable<@IfcCoordinateReferenceSystem>
	{
		#region IIfcCoordinateReferenceSystem explicit implementation
		IfcLabel IIfcCoordinateReferenceSystem.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcCoordinateReferenceSystem.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IfcIdentifier? IIfcCoordinateReferenceSystem.GeodeticDatum { 
 
			get { return @GeodeticDatum; } 
			set { GeodeticDatum = value;}
		}	
		IfcIdentifier? IIfcCoordinateReferenceSystem.VerticalDatum { 
 
			get { return @VerticalDatum; } 
			set { VerticalDatum = value;}
		}	
		 
		IEnumerable<IIfcCoordinateOperation> IIfcCoordinateReferenceSystem.HasCoordinateOperation {  get { return @HasCoordinateOperation; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCoordinateReferenceSystem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcIdentifier? _geodeticDatum;
		private IfcIdentifier? _verticalDatum;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcLabel @Name 
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
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
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
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcIdentifier? @GeodeticDatum 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _geodeticDatum;
				((IPersistEntity)this).Activate(false);
				return _geodeticDatum;
			} 
			set
			{
				SetValue( v =>  _geodeticDatum = v, _geodeticDatum, value,  "GeodeticDatum", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcIdentifier? @VerticalDatum 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _verticalDatum;
				((IPersistEntity)this).Activate(false);
				return _verticalDatum;
			} 
			set
			{
				SetValue( v =>  _verticalDatum = v, _verticalDatum, value,  "VerticalDatum", 4);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("SourceCRS")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 5)]
		public IEnumerable<IfcCoordinateOperation> @HasCoordinateOperation 
		{ 
			get 
			{
				return Model.Instances.Where<IfcCoordinateOperation>(e => Equals(e.SourceCRS), "SourceCRS", this);
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
					_geodeticDatum = value.StringVal;
					return;
				case 3: 
					_verticalDatum = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCoordinateReferenceSystem other)
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