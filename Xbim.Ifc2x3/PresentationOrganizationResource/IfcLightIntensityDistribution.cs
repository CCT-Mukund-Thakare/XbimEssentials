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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationOrganizationResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLightIntensityDistribution
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLightIntensityDistribution : IPersistEntity, IfcLightDistributionDataSourceSelect
	{
		IfcLightDistributionCurveEnum @LightDistributionCurve { get;  set; }
		IItemSet<IIfcLightDistributionData> @DistributionData { get; }
	
	}
}

namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[ExpressType("IfcLightIntensityDistribution", 754)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightIntensityDistribution : PersistEntity, IInstantiableEntity, IIfcLightIntensityDistribution, IContainsEntityReferences, IEquatable<@IfcLightIntensityDistribution>
	{
		#region IIfcLightIntensityDistribution explicit implementation
		IfcLightDistributionCurveEnum IIfcLightIntensityDistribution.LightDistributionCurve { 
 
			get { return @LightDistributionCurve; } 
			set { LightDistributionCurve = value;}
		}	
		IItemSet<IIfcLightDistributionData> IIfcLightIntensityDistribution.DistributionData { 
			get { return new Common.Collections.ProxyItemSet<IfcLightDistributionData, IIfcLightDistributionData>( @DistributionData); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightIntensityDistribution(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_distributionData = new ItemSet<IfcLightDistributionData>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcLightDistributionCurveEnum _lightDistributionCurve;
		private readonly ItemSet<IfcLightDistributionData> _distributionData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 1)]
		public IfcLightDistributionCurveEnum @LightDistributionCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lightDistributionCurve;
				((IPersistEntity)this).Activate(false);
				return _lightDistributionCurve;
			} 
			set
			{
				SetValue( v =>  _lightDistributionCurve = v, _lightDistributionCurve, value,  "LightDistributionCurve", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 2)]
		public IItemSet<IfcLightDistributionData> @DistributionData 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _distributionData;
				((IPersistEntity)this).Activate(false);
				return _distributionData;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _lightDistributionCurve = (IfcLightDistributionCurveEnum) System.Enum.Parse(typeof (IfcLightDistributionCurveEnum), value.EnumVal, true);
					return;
				case 1: 
					_distributionData.InternalAdd((IfcLightDistributionData)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLightIntensityDistribution other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @DistributionData)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}