// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ActorResource;
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
    /// Readonly interface for IfcActor
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcActor : IIfcObject
	{
		IIfcActorSelect @TheActor { get;  set; }
		IEnumerable<IIfcRelAssignsToActor> @IsActingUpon {  get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcActor", 250)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcActor : IfcObject, IInstantiableEntity, IIfcActor, IContainsEntityReferences, IEquatable<@IfcActor>
	{
		#region IIfcActor explicit implementation
		IIfcActorSelect IIfcActor.TheActor { 
 
 
			get { return @TheActor; } 
			set { TheActor = value as IfcActorSelect;}
		}	
		 
		IEnumerable<IIfcRelAssignsToActor> IIfcActor.IsActingUpon {  get { return @IsActingUpon; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcActor(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcActorSelect _theActor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 17)]
		public IfcActorSelect @TheActor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _theActor;
				((IPersistEntity)this).Activate(false);
				return _theActor;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _theActor = v, _theActor, value,  "TheActor", 6);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingActor")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 18)]
		public IEnumerable<IfcRelAssignsToActor> @IsActingUpon 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToActor>(e => Equals(e.RelatingActor), "RelatingActor", this);
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
					_theActor = (IfcActorSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcActor other)
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
				if (@TheActor != null)
					yield return @TheActor;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}