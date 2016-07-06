// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgServiceElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcEnergyProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcEnergyProperties : IIfcPropertySetDefinition
	{
		IfcEnergySequenceEnum? @EnergySequence { get;  set; }
		IfcLabel? @UserDefinedEnergySequence { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[ExpressType("IfcEnergyProperties", 176)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEnergyProperties : IfcPropertySetDefinition, IInstantiableEntity, IIfcEnergyProperties, IContainsEntityReferences, IEquatable<@IfcEnergyProperties>
	{
		#region IIfcEnergyProperties explicit implementation
		IfcEnergySequenceEnum? IIfcEnergyProperties.EnergySequence { 
 
			get { return @EnergySequence; } 
			set { EnergySequence = value;}
		}	
		IfcLabel? IIfcEnergyProperties.UserDefinedEnergySequence { 
 
			get { return @UserDefinedEnergySequence; } 
			set { UserDefinedEnergySequence = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEnergyProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcEnergySequenceEnum? _energySequence;
		private IfcLabel? _userDefinedEnergySequence;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 8)]
		public IfcEnergySequenceEnum? @EnergySequence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _energySequence;
				((IPersistEntity)this).Activate(false);
				return _energySequence;
			} 
			set
			{
				SetValue( v =>  _energySequence = v, _energySequence, value,  "EnergySequence", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcLabel? @UserDefinedEnergySequence 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedEnergySequence;
				((IPersistEntity)this).Activate(false);
				return _userDefinedEnergySequence;
			} 
			set
			{
				SetValue( v =>  _userDefinedEnergySequence = v, _userDefinedEnergySequence, value,  "UserDefinedEnergySequence", 6);
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
                    _energySequence = (IfcEnergySequenceEnum) System.Enum.Parse(typeof (IfcEnergySequenceEnum), value.EnumVal, true);
					return;
				case 5: 
					_userDefinedEnergySequence = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcEnergyProperties other)
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
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}