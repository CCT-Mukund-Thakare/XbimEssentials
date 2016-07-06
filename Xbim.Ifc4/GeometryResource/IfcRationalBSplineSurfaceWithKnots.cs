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
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRationalBSplineSurfaceWithKnots
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRationalBSplineSurfaceWithKnots : IIfcBSplineSurfaceWithKnots
	{
		IItemSet<IItemSet<IfcReal>> @WeightsData { get; }
		List<List<IfcReal>> @Weights  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcRationalBSplineSurfaceWithKnots", 1242)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRationalBSplineSurfaceWithKnots : IfcBSplineSurfaceWithKnots, IInstantiableEntity, IIfcRationalBSplineSurfaceWithKnots, IContainsEntityReferences, IEquatable<@IfcRationalBSplineSurfaceWithKnots>
	{
		#region IIfcRationalBSplineSurfaceWithKnots explicit implementation
		IItemSet<IItemSet<IfcReal>> IIfcRationalBSplineSurfaceWithKnots.WeightsData { 
			get { return @WeightsData; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRationalBSplineSurfaceWithKnots(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_weightsData = new ItemSet<IItemSet<IfcReal>>( this, 0,  13);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IItemSet<IfcReal>> _weightsData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 2, -1, 15)]
		public IItemSet<IItemSet<IfcReal>> @WeightsData 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _weightsData;
				((IPersistEntity)this).Activate(false);
				return _weightsData;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Array, EntityAttributeType.Array, 0, -1, 0)]
		public List<List<IfcReal>> @Weights 
		{
			get 
			{
				//## Getter for Weights
                return WeightsData.Select(wd => wd.ToList()).ToList();
				//##
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 12: 
					((ItemSet<IfcReal>)_weightsData
						.InternalGetAt(nestedIndex[0]) )
						.InternalAdd((IfcReal)(value.RealVal));
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRationalBSplineSurfaceWithKnots other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach (var item in @ControlPointsList)
					foreach (var entity in item)
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