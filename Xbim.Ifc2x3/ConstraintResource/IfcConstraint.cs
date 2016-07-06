// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConstraint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConstraint : IPersistEntity
	{
		IfcLabel @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IfcConstraintEnum @ConstraintGrade { get;  set; }
		IfcLabel? @ConstraintSource { get;  set; }
		IIfcActorSelect @CreatingActor { get;  set; }
		IIfcDateTimeSelect @CreationTime { get;  set; }
		IfcLabel? @UserDefinedGrade { get;  set; }
		IEnumerable<IIfcConstraintClassificationRelationship> @ClassifiedAs {  get; }
		IEnumerable<IIfcConstraintRelationship> @RelatesConstraints {  get; }
		IEnumerable<IIfcConstraintRelationship> @IsRelatedWith {  get; }
		IEnumerable<IIfcPropertyConstraintRelationship> @PropertiesForConstraint {  get; }
		IEnumerable<IIfcConstraintAggregationRelationship> @Aggregates {  get; }
		IEnumerable<IIfcConstraintAggregationRelationship> @IsAggregatedIn {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ConstraintResource
{
	[ExpressType("IfcConstraint", 81)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstraint : PersistEntity, IIfcConstraint, IEquatable<@IfcConstraint>
	{
		#region IIfcConstraint explicit implementation
		IfcLabel IIfcConstraint.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcConstraint.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IfcConstraintEnum IIfcConstraint.ConstraintGrade { 
 
			get { return @ConstraintGrade; } 
			set { ConstraintGrade = value;}
		}	
		IfcLabel? IIfcConstraint.ConstraintSource { 
 
			get { return @ConstraintSource; } 
			set { ConstraintSource = value;}
		}	
		IIfcActorSelect IIfcConstraint.CreatingActor { 
 
 
			get { return @CreatingActor; } 
			set { CreatingActor = value as IfcActorSelect;}
		}	
		IIfcDateTimeSelect IIfcConstraint.CreationTime { 
 
 
			get { return @CreationTime; } 
			set { CreationTime = value as IfcDateTimeSelect;}
		}	
		IfcLabel? IIfcConstraint.UserDefinedGrade { 
 
			get { return @UserDefinedGrade; } 
			set { UserDefinedGrade = value;}
		}	
		 
		IEnumerable<IIfcConstraintClassificationRelationship> IIfcConstraint.ClassifiedAs {  get { return @ClassifiedAs; } }
		IEnumerable<IIfcConstraintRelationship> IIfcConstraint.RelatesConstraints {  get { return @RelatesConstraints; } }
		IEnumerable<IIfcConstraintRelationship> IIfcConstraint.IsRelatedWith {  get { return @IsRelatedWith; } }
		IEnumerable<IIfcPropertyConstraintRelationship> IIfcConstraint.PropertiesForConstraint {  get { return @PropertiesForConstraint; } }
		IEnumerable<IIfcConstraintAggregationRelationship> IIfcConstraint.Aggregates {  get { return @Aggregates; } }
		IEnumerable<IIfcConstraintAggregationRelationship> IIfcConstraint.IsAggregatedIn {  get { return @IsAggregatedIn; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstraint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcConstraintEnum _constraintGrade;
		private IfcLabel? _constraintSource;
		private IfcActorSelect _creatingActor;
		private IfcDateTimeSelect _creationTime;
		private IfcLabel? _userDefinedGrade;
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
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 3)]
		public IfcConstraintEnum @ConstraintGrade 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _constraintGrade;
				((IPersistEntity)this).Activate(false);
				return _constraintGrade;
			} 
			set
			{
				SetValue( v =>  _constraintGrade = v, _constraintGrade, value,  "ConstraintGrade", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLabel? @ConstraintSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _constraintSource;
				((IPersistEntity)this).Activate(false);
				return _constraintSource;
			} 
			set
			{
				SetValue( v =>  _constraintSource = v, _constraintSource, value,  "ConstraintSource", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcActorSelect @CreatingActor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creatingActor;
				((IPersistEntity)this).Activate(false);
				return _creatingActor;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _creatingActor = v, _creatingActor, value,  "CreatingActor", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcDateTimeSelect @CreationTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creationTime;
				((IPersistEntity)this).Activate(false);
				return _creationTime;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _creationTime = v, _creationTime, value,  "CreationTime", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcLabel? @UserDefinedGrade 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedGrade;
				((IPersistEntity)this).Activate(false);
				return _userDefinedGrade;
			} 
			set
			{
				SetValue( v =>  _userDefinedGrade = v, _userDefinedGrade, value,  "UserDefinedGrade", 7);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ClassifiedConstraint")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 8)]
		public IEnumerable<IfcConstraintClassificationRelationship> @ClassifiedAs 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintClassificationRelationship>(e => Equals(e.ClassifiedConstraint), "ClassifiedConstraint", this);
			} 
		}
		[InverseProperty("RelatingConstraint")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 9)]
		public IEnumerable<IfcConstraintRelationship> @RelatesConstraints 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintRelationship>(e => Equals(e.RelatingConstraint), "RelatingConstraint", this);
			} 
		}
		[InverseProperty("RelatedConstraints")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 10)]
		public IEnumerable<IfcConstraintRelationship> @IsRelatedWith 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintRelationship>(e => e.RelatedConstraints != null &&  e.RelatedConstraints.Contains(this), "RelatedConstraints", this);
			} 
		}
		[InverseProperty("RelatingConstraint")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 11)]
		public IEnumerable<IfcPropertyConstraintRelationship> @PropertiesForConstraint 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPropertyConstraintRelationship>(e => Equals(e.RelatingConstraint), "RelatingConstraint", this);
			} 
		}
		[InverseProperty("RelatingConstraint")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 12)]
		public IEnumerable<IfcConstraintAggregationRelationship> @Aggregates 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintAggregationRelationship>(e => Equals(e.RelatingConstraint), "RelatingConstraint", this);
			} 
		}
		[InverseProperty("RelatedConstraints")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 13)]
		public IEnumerable<IfcConstraintAggregationRelationship> @IsAggregatedIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcConstraintAggregationRelationship>(e => e.RelatedConstraints != null &&  e.RelatedConstraints.Contains(this), "RelatedConstraints", this);
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
                    _constraintGrade = (IfcConstraintEnum) System.Enum.Parse(typeof (IfcConstraintEnum), value.EnumVal, true);
					return;
				case 3: 
					_constraintSource = value.StringVal;
					return;
				case 4: 
					_creatingActor = (IfcActorSelect)(value.EntityVal);
					return;
				case 5: 
					_creationTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 6: 
					_userDefinedGrade = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstraint other)
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