// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConversionBasedUnitWithOffset
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConversionBasedUnitWithOffset : IIfcConversionBasedUnit
	{
		IfcReal @ConversionOffset { get;  set; }
	
	}
}

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IfcConversionBasedUnitWithOffset", 1140)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConversionBasedUnitWithOffset : IfcConversionBasedUnit, IInstantiableEntity, IIfcConversionBasedUnitWithOffset, IContainsEntityReferences, IEquatable<@IfcConversionBasedUnitWithOffset>
	{
		#region IIfcConversionBasedUnitWithOffset explicit implementation
		IfcReal IIfcConversionBasedUnitWithOffset.ConversionOffset { 
 
			get { return @ConversionOffset; } 
			set { ConversionOffset = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConversionBasedUnitWithOffset(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcReal _conversionOffset;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcReal @ConversionOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _conversionOffset;
				((IPersistEntity)this).Activate(false);
				return _conversionOffset;
			} 
			set
			{
				SetValue( v =>  _conversionOffset = v, _conversionOffset, value,  "ConversionOffset", 5);
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
					_conversionOffset = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConversionBasedUnitWithOffset other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Dimensions != null)
					yield return @Dimensions;
				if (@ConversionFactor != null)
					yield return @ConversionFactor;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}