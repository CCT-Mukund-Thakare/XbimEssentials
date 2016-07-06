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
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcObject
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcObject : IIfcObjectDefinition
	{
		IfcLabel? @ObjectType { get;  set; }
		IEnumerable<IIfcRelDefinesByObject> @IsDeclaredBy {  get; }
		IEnumerable<IIfcRelDefinesByObject> @Declares {  get; }
		IEnumerable<IIfcRelDefinesByType> @IsTypedBy {  get; }
		IEnumerable<IIfcRelDefinesByProperties> @IsDefinedBy {  get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcObject", 21)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcObject : IfcObjectDefinition, IIfcObject, IEquatable<@IfcObject>
	{
		#region IIfcObject explicit implementation
		IfcLabel? IIfcObject.ObjectType { 
 
			get { return @ObjectType; } 
			set { ObjectType = value;}
		}	
		 
		IEnumerable<IIfcRelDefinesByObject> IIfcObject.IsDeclaredBy {  get { return @IsDeclaredBy; } }
		IEnumerable<IIfcRelDefinesByObject> IIfcObject.Declares {  get { return @Declares; } }
		IEnumerable<IIfcRelDefinesByType> IIfcObject.IsTypedBy {  get { return @IsTypedBy; } }
		IEnumerable<IIfcRelDefinesByProperties> IIfcObject.IsDefinedBy {  get { return @IsDefinedBy; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObject(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _objectType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcLabel? @ObjectType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _objectType;
				((IPersistEntity)this).Activate(false);
				return _objectType;
			} 
			set
			{
				SetValue( v =>  _objectType = v, _objectType, value,  "ObjectType", 5);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 13)]
		public IEnumerable<IfcRelDefinesByObject> @IsDeclaredBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByObject>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		[InverseProperty("RelatingObject")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 14)]
		public IEnumerable<IfcRelDefinesByObject> @Declares 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByObject>(e => Equals(e.RelatingObject), "RelatingObject", this);
			} 
		}
		[InverseProperty("RelatedObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 15)]
		public IEnumerable<IfcRelDefinesByType> @IsTypedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByType>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		[InverseProperty("RelatedObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 16)]
		public IEnumerable<IfcRelDefinesByProperties> @IsDefinedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByProperties>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
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
					_objectType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcObject other)
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